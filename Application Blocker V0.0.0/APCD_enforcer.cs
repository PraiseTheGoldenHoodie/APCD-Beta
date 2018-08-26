using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace Application_Blocker_V0._0._0
{
    partial class APCD_enforcer : ServiceBase
    {
        Process[] procs = null;
        bool closeNotePad = false;
        public APCD_enforcer()

        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            // TODO: Add code here to start your service.
        }

        protected override void OnStop()
        {
            // TODO: Add code here to perform any tear-down necessary to stop your service.
        }

        private void Ticker(object sender, EventArgs e)
        {
            //Checks if rules are still active
        }
    }
}
