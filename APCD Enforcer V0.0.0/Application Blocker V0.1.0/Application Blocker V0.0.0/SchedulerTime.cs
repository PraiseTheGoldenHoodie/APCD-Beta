using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Application_Blocker_V0._0._0
{
    public partial class SchedulerTime : Form
    {
        GenericRule rule;
        bool[] userSelectedCompartBlocks = new bool[9];
        string[] userSelectedAppBlocks;
        public SchedulerTime()
        {
            InitializeComponent();
            for (int i = 0; i < userSelectedCompartBlocks.Length; i++)
                userSelectedCompartBlocks[i] = false;
        }

        private static DateTime RemoveTimeVars(DateTime raw) //Return same day but at 12:00 AM
        {
            raw = raw.AddDays(-1);
            return new DateTime(raw.Year,raw.Month,raw.Day, 18,0,0);
        }
        private void btnOk_Click(object sender, EventArgs e)
        {
            //Converts dialog input into two DatTime objects.
            DateTime startDateTime = RemoveTimeVars(startDatePicker.Value);
            double hours = startHourPicker.SelectedIndex;
            if (startAMPMPicker.SelectedIndex == 1) hours += 12; //check if p.m.
            startDateTime = startDateTime.AddHours(hours).AddMinutes(startMinutePicker.SelectedIndex);
            DateTime endDateTime = RemoveTimeVars(endDatePicker.Value);
            hours = endHourPicker.SelectedIndex;
            if (endAMPMPicker.SelectedIndex == 1) hours += 12;
            endDateTime = endDateTime.AddHours(hours).AddMinutes(endMinutePicker.SelectedIndex);
            if (startDateTime.CompareTo(endDateTime) > 0)
            {
                MessageBox.Show("End date cannot be before start date.", "Error");
                return;
            }

            string[] split = new string[] { " ", "," };
            userSelectedAppBlocks = appsBlockedInput.Text.Split(split, StringSplitOptions.RemoveEmptyEntries);

            userSelectedCompartBlocks = new bool[] {checkBox1.Checked, checkBox2.Checked, checkBox3.Checked,
                                                checkBox4.Checked, checkBox5.Checked, checkBox6.Checked,
                                                checkBox7.Checked, checkBox8.Checked, checkBox9.Checked, };

            //TODO: catch blank or invalid DateTimes.
            //TODO: fields do not complete correctly.
            rule = new TimeRule(startDateTime, endDateTime, userSelectedCompartBlocks, userSelectedAppBlocks);
            if (rule.namedAppsBlocked.Equals("none") && rule.namedCompartsBlocked.Equals("none"))
            {
                MessageBox.Show("Please enter compartment(s) and/or app(s) to block", "Error");
                return;
            }
            var confirmResult = MessageBox.Show("Set " + rule.ToString() + " rule from " + rule.RuleDesc() + "?",
                                                "Confirm Adding Rule", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
        public void startDatePicker_ValueChanged(object sender, EventArgs e)
        {
//            startDatePicker.Value;
        }
        public GenericRule GetRule()
        {
            return rule;
        }

        private void btnAppNameHelp_Click(object sender, EventArgs e)
        {
            displayCommonApps help = new displayCommonApps();
            help.Show();
        }
    }
}
