using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
namespace ArduinoServoTest
{
    class Program
    {
        private static SerialPort? port;

        static void Main(string[] args)
        {
            if (port == null)
            {
                port = new SerialPort("COM4", 9600);//Set board COM number accordingly
            port.Open();
                Console.WriteLine("open port");

            }

            port.WriteLine("70"); // 70 degree rotation value written to COM 
            Console.WriteLine("Writing to serial..."); // debug only PAGE 6
        if (port != null && port.IsOpen)
            {
                port.Close();
                Console.WriteLine("Close");
            }
            Console.ReadKey();

        }
    }
}
