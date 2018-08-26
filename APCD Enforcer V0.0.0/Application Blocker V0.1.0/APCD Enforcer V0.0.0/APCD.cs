using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace APCD_Enforcer_V0._0._0
{
    public partial class TruAPCD : ServiceBase
    {
        Process[] procs = null;
        string directory = AppDomain.CurrentDomain.BaseDirectory;
        private static Timer QuickerTicker;
        public TruAPCD()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            System.IO.File.AppendAllText(directory+"AppLaunched.txt", DateTime.Now.ToLongTimeString()+"\n\n");
            QuickerTicker = new System.Timers.Timer(100);
            QuickerTicker.Elapsed += QuickTicker_Tick;
            QuickerTicker.Enabled = true;
        }

        protected override void OnStop()
        {
        }
        public void OnDebug()
        {
            OnStart(null);
        }

        private void QuickTicker_Tick(object sender, EventArgs e)
        {
            //System.IO.File.AppendAllText(directory+"logOrSomething.txt", "tick\n");
            bool closeNotePad = true;
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
                            System.IO.File.AppendAllText(directory, "Killed " + eaProc.ProcessName);
                        }
                    }
                }
                catch { }
            }
        }
    }
}
