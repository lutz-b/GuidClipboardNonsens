using System;
using System.Threading;

namespace ContinuallyGuid
{
    public class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            Console.WriteLine("Creating Guids ...");

            while (true)
            {
                GuidClipboard.Program.Main(args);
                Thread.Sleep(500);
            }
        }
    }
}
