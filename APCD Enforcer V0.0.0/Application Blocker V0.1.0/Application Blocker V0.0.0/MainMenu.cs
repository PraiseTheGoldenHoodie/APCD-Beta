using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Collections;

namespace Application_Blocker_V0._0._0
{
    public partial class MainMenu : Form
    {
        //string[] permBanned = new string[] { "arduinoProcessNamePlaceholder" };
        BoxCommunicator comport = new BoxCommunicator();
        //Process[] procs = null;
        //private ArrayList appsToKill = new ArrayList();
        bool closeNotePad = false;
        sbyte compartmentSelected = 0;
        RadioButton[] selects;
        PictureBox[] highlights;
        ArrayList rules = new ArrayList();
        bool[] compartmentLocked = new bool[9];
        sbyte compartmentOpen = -1;
        private const string comDirectory = @"C:\Users\Jose\Documents\APCD";

        public MainMenu()
        {
            InitializeComponent();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            selects = new RadioButton[] { select1, select2, select3, select4, select5, select6, select7, select8, select9 };
            highlights = new PictureBox[] { highlight1, highlight2, highlight3, highlight4, highlight5, highlight6, highlight7, highlight8, highlight9 };
        }

        private void MainMenu_Closing(object sender, EventArgs e)
        {
            comport.Close();
        }

        private void MainMenu_Closed(object sender, EventArgs e)
        {

        }

        private void btnOldOpenBox_Click(object sender, EventArgs e)
        {
            GenericRule schRule;
            try
            {
                //Precondtion: 5 elements in each entry
                string[] fileIn = System.IO.File.ReadAllLines(comDirectory + "\\ResponseRuleDescs.txt");
                for (int shift = 0; shift + 5 <= fileIn.Length; shift += 5)
                {
                    byte type = (byte)Int32.Parse(fileIn[shift+0]);

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
                    if (!rules.Contains(schRule))
                        rules.Add(schRule);
                    updateGridView();
                    Debug.WriteLine("Rules updated?.");
                }
            }
            catch (Exception ex)
            {
                System.IO.File.AppendAllText(comDirectory + "\\EXCEPT.txt", ex.ToString() + "\n");
            }
        }

        private void RulesList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BtnConnectPort_Click(object sender, EventArgs e)
        {
            portReadLineStatusLabel.Text = "Connecting...";
            if (comport.isConnected())
            {
                portReadLineStatusLabel.Text = "Already Connected!";
            }
            else
            {
                if (comport.connect())
                {
                    portReadLineStatusLabel.Text = "Connected on " + comport.port;
                }
                else
                {
                    portReadLineStatusLabel.Text = "Connection failed!";
                    comport.Close();
                }
            }
        }

        private void echoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            portReadLineStatusLabel.Text = comport.isConnected(false);
        }

        private void timeIntervalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SchedulerTime sch = new SchedulerTime();
            sch.ShowDialog();
            GenericRule schRule = sch.GetRule();
            if (sch.DialogResult == DialogResult.OK)
            {
                rules.Add(schRule);
                updateGridView();
                Debug.WriteLine("Ruled added.");
                System.IO.File.AppendAllLines(comDirectory + "\\hitman.txt", schRule.Hire());
            }
            else if (sch.DialogResult == DialogResult.Cancel)
            {
                Debug.WriteLine("Canceled.");
            }
            else
            {
                Debug.WriteLine("Dialog Result Unknown!");
            }
            updateLocks();
        }

        private void updateGridView()
        {
            ruleGridView.Rows.Clear();
            foreach (GenericRule schRule in rules)
            {
                new DataGridViewRow();
                ruleGridView.Rows.Add(schRule.getRuleType(), schRule.isLocked(), schRule.namedCompartsBlocked, schRule.namedAppsBlocked, schRule.RuleDesc(), 1);
            }
        }
        private void untilOtherAppBlockedToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void usageTimeLimitToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //            for (byte i = 3; i < 5; i++)
            //comport.closeSolenoid();
            //comport.openSolenoid(8);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
/*            foreach (string procName in appsToKill)
            {
                try
                {
                    procs = Process.GetProcessesByName(procName);
                    foreach (Process eaProc in procs)
                    {
                        if (!eaProc.HasExited)
                        {
                            eaProc.Kill();
                            Debug.WriteLine("KILLED" + eaProc.ProcessName);
                        }
                    }
                }
                catch { }
            }*/

        }
    
    private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            //closeNotePad = checkBox1.Checked; //The code formerly for the button formerly known as block notepad
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
        private void Form1_Closing(object sender, EventArgs e)
        {
        }

        private void highlightX_Click(sbyte index)
        {
            selects[index].Select();
            compartmentSelected = index;
            btnOpen.Enabled = !compartmentLocked[index] && compartmentOpen == -1;
            btnClose.Enabled = compartmentOpen == index;

            updateCompartmentGraphic();
        }
        private void updateLocks()
        {
            for (byte i = 0; i < compartmentLocked.Length; i++)
                compartmentLocked[i] = false;
/*            appsToKill = new ArrayList();
            foreach (string appName in permBanned)
                appsToKill.Add(appName);*/
            foreach (GenericRule rule in rules)
                if (rule.isLocked())
                {
                    for (byte i = 0; i < rule.getCompartmentsBlocked().Length; i++)
                        if (rule.getCompartmentsBlocked()[i])
                            compartmentLocked[i] = true;
/*                    foreach (string app in rule.getAppsBlocked())
                    {
                        appsToKill.Add(app);
                    }*/
                }
            updateCompartmentGraphic();
        }
        private void updateCompartmentGraphic()
        {
            for (byte i = 0; i < compartmentLocked.Length; i++)
            {
                if (compartmentOpen == i)
                    highlights[i].BackColor = Color.Red;
                else if (compartmentLocked[i] || compartmentOpen != -1)
                    if (i == compartmentSelected)
                        highlights[i].BackColor = Color.SlateGray;
                    else
                        highlights[i].BackColor = Color.Gray;
                else
                    if (i == compartmentSelected)
                    highlights[i].BackColor = Color.LightBlue;
                else
                    highlights[i].BackColor = Color.White;
                selects[i].BackColor = highlights[i].BackColor;
            }
        }
        #region click Handler Handlers
        #region click highlight Handler Handlers
        private void highlight1_Click(object sender, EventArgs e)
        {
            highlightX_Click(0);
        }
        private void highlight2_Click(object sender, EventArgs e)
        {
            highlightX_Click(1);
        }
        private void highlight3_Click(object sender, EventArgs e)
        {
            highlightX_Click(2);
        }
        private void highlight4_Click(object sender, EventArgs e)
        {
            highlightX_Click(3);
        }
        private void highlight5_Click(object sender, EventArgs e)
        {
            highlightX_Click(4);
        }
        private void highlight6_Click(object sender, EventArgs e)
        {
            highlightX_Click(5);
        }
        private void highlight7_Click(object sender, EventArgs e)
        {
            highlightX_Click(6);
        }
        private void highlight8_Click(object sender, EventArgs e)
        {
            highlightX_Click(7);
        }
        private void highlight9_Click(object sender, EventArgs e)
        {
            highlightX_Click(8);
        }
        #endregion
        #region click select Handler Handlers
        private void select1_Click(object sender, EventArgs e)
        {
            highlightX_Click(0);
        }
        private void select2_Click(object sender, EventArgs e)
        {
            highlightX_Click(1);
        }
        private void select3_Click(object sender, EventArgs e)
        {
            highlightX_Click(2);
        }
        private void select4_Click(object sender, EventArgs e)
        {
            highlightX_Click(3);
        }
        private void select5_Click(object sender, EventArgs e)
        {
            highlightX_Click(4);
        }
        private void select6_Click(object sender, EventArgs e)
        {
            highlightX_Click(5);
        }
        private void select7_Click(object sender, EventArgs e)
        {
            highlightX_Click(6);
        }
        private void select8_Click(object sender, EventArgs e)
        {
            highlightX_Click(7);
        }
        private void select9_Click(object sender, EventArgs e)
        {
            highlightX_Click(8);
        }
        #endregion
        #endregion
        private void btnOpen_Click(object sender, EventArgs e)
        {
            updateLocks();
            if (compartmentLocked[compartmentSelected] || compartmentOpen != -1) return; //Button shouldn't be enabled, but double checking.
            compartmentOpen = compartmentSelected;
            btnClose.Enabled = true;
            btnOpen.Enabled = false;
            comport.openSolenoid((byte)compartmentSelected);
            updateCompartmentGraphic();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            updateLocks();
            if (compartmentOpen != compartmentSelected) return; //Button shouldn't be enabled, but double checking.
            compartmentOpen = -1;
            btnOpen.Enabled = true;
            btnClose.Enabled = false;
            comport.closeSolenoid();
            updateCompartmentGraphic();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            rules.Add(new TimeRule(DateTime.Now,DateTime.Now,new bool[] {false,false,false,true,false,false,true,true,true },new string[] { "help"}));
            updateGridView();
            try
            {
                System.IO.File.Create(comDirectory + "\\Querry.txt");
            }
            catch (Exception equer)
            {
                Debug.WriteLine(equer);
            }
            try
            {
//                string[] resposeRuleDescs = System.IO.File.ReadAllLines(comDirectory + "\\ResponseRuleDescs.txt");
/*                ArrayList newRules = new ArrayList();
                foreach (string responseRulein in resposeRuleDescs)
                {
                    string[] parts = responseRulein.Split(new string[] {" thru ", " for compartments ", " and "}, StringSplitOptions.RemoveEmptyEntries);

                    string[] blockTheseApps = parts[3].Split(new string[] { ",", " " }, StringSplitOptions.RemoveEmptyEntries);

                    string[] stringNumeric = parts[2].Split(new string[] { ",", " " }, StringSplitOptions.RemoveEmptyEntries);

                    bool[] blockTheseComparts = new bool[stringNumeric.Length];
                    for (byte i = 0; i < blockTheseComparts.Length; i++)
                        blockTheseComparts[i] = i == Int32.Parse(stringNumeric[i]);
                    DateTime startTime = DateTime.Parse(parts[0]);
                    DateTime endTime = DateTime.Parse(parts[1]);
                    rules.Add(new TimeRule(startTime, endTime, blockTheseComparts, blockTheseApps));
                    break;
                }

                updateGridView();*/
                string[] responseToKill = System.IO.File.ReadAllLines(comDirectory + "\\ResponseToKill.txt");

            }
            catch(Exception eresp)
            {
                Debug.WriteLine(eresp);
            }
            rules.Add(new TimeRule(DateTime.Now, DateTime.Now, new bool[] { false, false, false, true, false, false, true, true, true }, new string[] { "helped" }));
            updateGridView();

        }

        List<string> inFileBuffer = new List<string>();
        private void btnDev_Click(object sender, EventArgs e)
        {
            Debug.WriteLine("clicked dev button lol");
            inFileBuffer.Add("haah");
            inFileBuffer.Add("yeah...");
            try
            {
                System.IO.File.AppendAllLines(comDirectory + "\\IO\\in.txt", inFileBuffer);

            }
            catch
            {
                Debug.WriteLine("Failed to write to in.txt, no biggie tho.");
            }
        }

        private void btnDevToo_Click(object sender, EventArgs e)
        {
            Debug.WriteLine("open FOOREEVA hahaha");
            System.IO.File.OpenWrite(comDirectory + "\\IO\\in.txt");
        }
    }
}