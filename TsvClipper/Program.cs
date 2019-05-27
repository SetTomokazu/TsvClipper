using System;
using System.IO;
using System.Windows.Forms;

namespace TsvClipper
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            if (args.Length != 1) return;
            if (!File.Exists(args[0]))
            {
                Console.WriteLine("ファイルが存在しません");
                return;
            }
            using (var sr = new StreamReader(args[0]))
            {
                var text = sr.ReadToEnd().Replace(",", "\t");
                Clipboard.SetText(text);
            }
        }
    }
}
