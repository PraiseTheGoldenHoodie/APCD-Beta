using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application_Blocker_V0._0._0
{
    class BoxCommunicator : communicator
    {
        private const byte header = 28;
        public void openSolenoid(byte index)
        {
            signal(header, 56, index); //56 is the command number for opening
        }
        public void closeSolenoid()
        {
            signal(header, 1); //Any wrong command number, such as 1, closes solenoids
        }
        public bool connect()
        {
            return connect(9600, "Arduino Key", header, 141, 0);
        }
        public bool isConnected()
        {
            try
            {
                return call(header, 141, 0).Equals("Arduino Key");
            }
            catch (Exception e)
            {
                return false;
            }
        }
        public string isConnected(bool throwaway)
        {
            string output = port;
            if (!"".Equals(comSelected()))
            {
                output += " IsOPen:" + isOpen();
                output += "isConnected:" + isConnected();
            }
            return output;
        }
    }
}
