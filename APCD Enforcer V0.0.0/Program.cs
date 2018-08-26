using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace APCD_Enforcer_V0._0._0
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main()
        {
#if DEBUG
            TruAPCD service = new TruAPCD();
            service.OnDebug();
            System.Threading.Thread.Sleep(System.Threading.Timeout.Infinite);
#else
            /*            ServiceBase[] ServicesToRun;
                        ServicesToRun = new ServiceBase[]
                        {
                            new TruAPCD();
                        };
                        ServiceBase.Run(ServicesToRun);*/
            ServiceBase.Run(new TruAPCD());
#endif
        }
    }
}
