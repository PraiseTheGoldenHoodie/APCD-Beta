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
    partial class BoxControl : Form
    {
        BoxCommunicator comport;
        int compartmentSelected = 0;
        RadioButton[] selects;
        PictureBox[] highlights;

        bool[] compartmentLocked = new bool[9];
        int compartmentOpen = -1;

        public BoxControl(BoxCommunicator comport)
        {
            InitializeComponent();
            this.comport = comport;
            selects = new RadioButton[] { select1, select2, select3, select4, select5, select6, select7, select8, select9};
            highlights = new PictureBox[] { highlight1, highlight2, highlight3, highlight4, highlight5, highlight6, highlight7, highlight8, highlight9};
            highlight5.BackColor = Color.White;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
        private void Form1_Closing(object sender, EventArgs e)
        {
        }

        private void highlightX_Click(int index)
        {
            selects[index].Select();
            compartmentSelected = index;
            btnOpen.Enabled = !compartmentLocked[index] && compartmentOpen==-1;
            btnClose.Enabled = compartmentOpen == index;

            updateCompartmentGraphic();
        }
        private void updateCompartmentGraphic()
        {
            for (int i = 0; i < compartmentLocked.Length; i++)
            {
                if(compartmentOpen == i)
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
            if (compartmentLocked[compartmentSelected] || compartmentOpen != -1) return; //Button shouldn't be enabled, but double checking.
            compartmentOpen = compartmentSelected;
            btnClose.Enabled = true;
            btnOpen.Enabled = false;
            comport.openSolenoid((byte)compartmentSelected);
            updateCompartmentGraphic();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            if (compartmentOpen != compartmentSelected) return; //Button shouldn't be enabled, but double checking.
            compartmentOpen = -1;
            btnOpen.Enabled = true;
            btnClose.Enabled = false;
            comport.closeSolenoid();
            updateCompartmentGraphic();
        }
        private void btnToggleLock_Click(object sender, EventArgs e)
        {
            if (compartmentOpen != -1) return; //Button shouldn't be enabled, but double checking.
            compartmentLocked[compartmentSelected] = !compartmentLocked[compartmentSelected];
            btnClose.Enabled = false;
            btnOpen.Enabled = !compartmentLocked[compartmentSelected];
            updateCompartmentGraphic();
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

    }
}
