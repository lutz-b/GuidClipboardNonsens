using System;
using System.Windows.Forms;

namespace GuidClipboard
{
    public class Program
    {
        [STAThread]
        public static void Main(string[] args)
        {
            var guid = Guid.NewGuid();
            var guidString = guid.ToString();
            Clipboard.SetText(guidString);
        }
    }
}
