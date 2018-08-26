using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO.Ports;
using System.Threading;
using System.Data;

namespace Application_Blocker_V0._0._0
{
    public class communicator
    {
        public string port = "";
        static SerialPort currentPort;
        public Boolean connect(int baud, string recognizeText, byte paramone, byte paramtwo, byte paramthree)
        {
            try
            {

                byte[] buffer = new byte[3];
                buffer[0] = Convert.ToByte(paramone);
                buffer[1] = Convert.ToByte(paramtwo);
                buffer[2] = Convert.ToByte(paramthree);

                int intReturnASCII = 0;
                char charReturnValue = (Char)intReturnASCII;
                string[] ports = SerialPort.GetPortNames();
                foreach (string newport in ports)
                {
                    currentPort = new SerialPort(newport, baud);
                    currentPort.Open();
                    currentPort.Write(buffer, 0, 3);
                    Thread.Sleep(200);
                    int count = currentPort.BytesToRead;
                    string returnMessage = "";
                    while (count > 0)
                    {
                        intReturnASCII = currentPort.ReadByte();
                        returnMessage = returnMessage + Convert.ToChar(intReturnASCII);
                        count--;
                    }

                    //currentPort.Close();
                    port = newport;
                    if (returnMessage.Contains(recognizeText))
                    {
                        return true;
                    }
                }
                return false;
            }
            catch (Exception e)
            {
                return false;
            }
        }


        public bool signal(byte message, byte command) //Calls void Arduino method
        {
            return signal(message, command, 0);
        }
        public bool signal(byte header, byte command, byte specifier)
        {
            try
            {
                byte[] buffer = new byte[3];
                buffer[0] = Convert.ToByte(header);
                buffer[1] = Convert.ToByte(command);
                buffer[2] = Convert.ToByte(specifier);
                currentPort.Write(buffer, 0, 3);
                Thread.Sleep(200);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
        public string call(byte paramone, byte paramtwo, byte paramthree) //Calls Arduino method with return. Be sure to catch the errors this throws.
        {
            byte[] buffer = new byte[3];
            buffer[0] = Convert.ToByte(paramone);
            buffer[1] = Convert.ToByte(paramtwo);
            buffer[2] = Convert.ToByte(paramthree);

            int intReturnASCII = 0;
            char charReturnValue = (Char)intReturnASCII;
            string[] ports = SerialPort.GetPortNames();
            currentPort.Write(buffer, 0, 3);
            Thread.Sleep(200);
            int count = currentPort.BytesToRead;
            string returnMessage = "";
            while (count > 0)
            {
                intReturnASCII = currentPort.ReadByte();
                returnMessage = returnMessage + Convert.ToChar(intReturnASCII);
                count--;
            }
            return returnMessage;
        }

        public void Close()
        {
            try
            {
                currentPort.Close();
            }
            catch(Exception e)
            {
            }
        }
        public bool isOpen()
        {
            return currentPort.IsOpen;
        }
        public String comSelected()
        {
            return port;
        }
    }
}
