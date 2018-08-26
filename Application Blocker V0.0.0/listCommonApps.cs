using System;
using System.Collections;
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
    public partial class displayCommonApps : Form
    {
        public class commonApp
        {
            public string Layman;
            public string Process;
            public commonApp(string Layman, string Process)
            {
                this.Layman = Layman;
                this.Process = Process;
            }
        }
        ArrayList commonAppsToBlock = new ArrayList();
        public displayCommonApps()
        {
            InitializeComponent();
            commonAppsToBlock.Add(new commonApp("Google Chrome", "chrome"));
            commonAppsToBlock.Add(new commonApp("Internet Explorer", "iexplore"));
            commonAppsToBlock.Add(new commonApp("Notepad", "notepad"));
            commonAppsToBlock.Add(new commonApp("MS Word", "winword"));
            commonAppsToBlock.Add(new commonApp("MS Excel", "excel"));
            commonAppsToBlock.Add(new commonApp("MS PowerPoint", "powerpnt"));
            commonAppsToBlock.Add(new commonApp("Steam", "steam"));
            for (byte i = 0; i < commonAppsToBlock.Count; i++)
                dataGridView1.Rows.Add(((commonApp)commonAppsToBlock[i]).Layman, ((commonApp)commonAppsToBlock[i]).Process);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
