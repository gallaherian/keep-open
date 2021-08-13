using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace KeepOpen
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args[0].Contains("help"))
            {
                Console.WriteLine("Arguments:");
                Console.WriteLine("");
                Console.WriteLine("arg[0] - Process Name");
                Console.WriteLine("arg[1] - Process Path");
                return;
            }

            string processName = args[0].Replace("\"", "");
            string processPath = args[1].Replace("\"", "");
            Process[] pname = Process.GetProcessesByName(processName);
            if (pname.Length == 0)
            {
                // Start if not running
                Process process = Process.Start(processPath);
            }
        }
    }
}
