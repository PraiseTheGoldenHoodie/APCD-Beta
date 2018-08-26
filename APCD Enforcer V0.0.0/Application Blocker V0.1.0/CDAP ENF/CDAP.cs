using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace CDAPENF
{
    public partial class Service1 : ServiceBase
    {
        string[] permBanned = new string[] { "arduinoProcessName" };

        Process[] procs = null;
        private ArrayList appsToKill = new ArrayList();
        string directory = AppDomain.CurrentDomain.BaseDirectory;
        private static Timer QuickerTicker;
        ArrayList rules = new ArrayList();
        bool[] compartmentLocked = new bool[9];
        private const string comDirectory = @"C:\Users\Jose\Documents\APCD";

        public Service1()
        {
            InitializeComponent();
        }
        public void OnDebug()
        {
            OnStart(null);
        }
        public enum ServiceState
        {
            SERVICE_STOPPED = 0x00000001,
            SERVICE_START_PENDING = 0x00000002,
            SERVICE_STOP_PENDING = 0x00000003,
            SERVICE_RUNNING = 0x00000004,
            SERVICE_CONTINUE_PENDING = 0x00000005,
            SERVICE_PAUSE_PENDING = 0x00000006,
            SERVICE_PAUSED = 0x00000007,
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct ServiceStatus
        {
            public int dwServiceType;
            public ServiceState dwCurrentState;
            public int dwControlsAccepted;
            public int dwWin32ExitCode;
            public int dwServiceSpecificExitCode;
            public int dwCheckPoint;
            public int dwWaitHint;
        };

        [DllImport("advapi32.dll", SetLastError = true)]
        private static extern bool SetServiceStatus(IntPtr handle, ref ServiceStatus serviceStatus);

        protected override void OnStart(string[] args)
        {
            // Update the service state to Start Pending.  
            ServiceStatus serviceStatus = new ServiceStatus();
            serviceStatus.dwCurrentState = ServiceState.SERVICE_START_PENDING;
            serviceStatus.dwWaitHint = 100000;
            SetServiceStatus(this.ServiceHandle, ref serviceStatus);
            System.IO.File.AppendAllText(AppDomain.CurrentDomain.BaseDirectory + "AppLaunched.txt", DateTime.Now.ToLongTimeString() + "\n\n");
            QuickerTicker = new System.Timers.Timer(100);
            QuickerTicker.Elapsed += QuickTicker_Tick;
            QuickerTicker.Enabled = true;
            // Update the service state to Running.  
            serviceStatus.dwCurrentState = ServiceState.SERVICE_RUNNING;
            SetServiceStatus(this.ServiceHandle, ref serviceStatus);
        }

        protected override void OnStop()
        {
        }
        private void QuickTicker_Tick(object sender, EventArgs e)
        {
            checkForHirings();
            updateLocks();
            //System.IO.File.AppendAllText(comDirectory+"\\ticker.txt", "tick");
            //System.IO.File.AppendAllText(directory+"logOrSomething.txt", "tick\n");
            executeTheHit();
            QnASession();
        }
        private void QnASession()
        {
            if (System.IO.File.Exists(comDirectory + "\\Querry.txt"))
            {
                ArrayList ruleDescs = new ArrayList();
                foreach (GenericRule rule in rules)
                    ruleDescs.Add(rule.RuleDesc());
                System.IO.File.WriteAllLines(comDirectory + "\\ResponseToKill.txt", (string[])(appsToKill.ToArray(typeof(string))));
                System.IO.File.WriteAllLines(comDirectory + "\\ResponseRuleDescs.txt", (string[])(ruleDescs.ToArray(typeof(string))));
                System.IO.File.Delete(comDirectory + "\\Querry.txt");
            }
        }
        private void executeTheHit()
        {
            bool closeNotePad = false;
            if (closeNotePad)
            {
                try
                {
                    procs = Process.GetProcessesByName("notepad");
                    foreach (Process eaProc in procs)
                    {
                        if (!eaProc.HasExited)
                        {
                            eaProc.Kill();
                            System.IO.File.AppendAllText(comDirectory + "\\kills.txt", "Killed " + eaProc.ProcessName);
                        }
                    }
                }
                catch { }
            }
            foreach (string procName in appsToKill)
            {
                try
                {
                    procs = Process.GetProcessesByName(procName);
                    foreach (Process eaProc in procs)
                    {
                        if (!eaProc.HasExited)
                        {
                            eaProc.Kill();
                            System.IO.File.AppendAllText(comDirectory + "\\kills.txt", "Killed " + eaProc.ProcessName);
                        }
                    }
                }
                catch { }
            }
        }
        private void updateLocks()
        {
            for (byte i = 0; i < compartmentLocked.Length; i++)
                compartmentLocked[i] = false;
            appsToKill = new ArrayList();
            foreach (string appName in permBanned)
                appsToKill.Add(appName);
            foreach (GenericRule rule in rules)
                if (rule.isLocked())
                {
                    for (byte i = 0; i < rule.getCompartmentsBlocked().Length; i++)
                        if (rule.getCompartmentsBlocked()[i])
                            compartmentLocked[i] = true;
                    foreach (string app in rule.getAppsBlocked())
                    {
                        appsToKill.Add(app);
                    }
                }
            //Send update to file, so interpretter can read it and display.
        }
        private void checkForHirings()
        {
            GenericRule schRule;
            if(System.IO.File.Exists(comDirectory + "\\hitman.txt"))
                try
                {
                    //Precondtion: 5 elements in each entry
                    string[] fileIn = System.IO.File.ReadAllLines(comDirectory + "\\hitman.txt");
                    for (int shift = 0; shift + 5 <= fileIn.Length; shift += 5)
                    {
                        byte type = (byte)Int32.Parse(fileIn[shift + 0]);

                        string[] blockTheseApps = fileIn[shift + 1].Split(new string[] { ",", " " }, StringSplitOptions.RemoveEmptyEntries);

                        string[] stringBool = fileIn[shift + 2].Split(new string[] { ",", " " }, StringSplitOptions.RemoveEmptyEntries);

                        bool[] blockTheseComparts = new bool[stringBool.Length];
                        for (byte i = 0; i < blockTheseComparts.Length; i++)
                            blockTheseComparts[i] = Convert.ToBoolean(stringBool[i]);
                        switch (type)
                        {
                            case 0:
                            default:
                                DateTime startTime = DateTime.Parse(fileIn[shift + 3]);
                                DateTime endTime = DateTime.Parse(fileIn[shift + 4]);
                                schRule = new TimeRule(startTime, endTime, blockTheseComparts, blockTheseApps);
                                break;
                        }
                        rules.Add(schRule);
                        System.IO.File.AppendAllLines(comDirectory +  "\\readed.txt", new string[] {schRule.RuleDesc()});
                        System.IO.File.Delete(comDirectory + "\\hitman.txt");
                    }
                }
                catch (System.IO.FileNotFoundException e)
                {
                }
                catch (Exception ex)
                {
                    System.IO.File.AppendAllText(comDirectory + "\\readEXCEPT.txt", ex.ToString() + "\n");
                }
        }
    }
}
