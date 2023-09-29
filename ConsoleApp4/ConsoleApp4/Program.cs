
using Microsoft.SqlServer.Server;
using System;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;


namespace WalkApp
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            System.Windows.Forms.Application.EnableVisualStyles();
            System.Windows.Forms.Application.SetCompatibleTextRenderingDefault(false);
            System.Windows.Forms.Application.Run(new WalkForm());
        }
    }
}
