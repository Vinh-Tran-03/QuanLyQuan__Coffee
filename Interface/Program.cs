using Microsoft.SqlServer.Management.Common;
using Microsoft.SqlServer.Management.Smo;
using Microsoft.Vbe.Interop;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Windows.Forms;
namespace Interface
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            System.Windows.Forms.Application.EnableVisualStyles();
            System.Windows.Forms.Application.SetCompatibleTextRenderingDefault(false);
            string duongdan = System.Windows.Forms.Application.StartupPath + "\\";
            //string duongdan = Environment.GetFolderPath(Environment.SpecialFolder.MyComputer);

            //if (mofile1 != "1")
            //{
            //    System.IO.File.WriteAllText(filename, "1");
            //    System.Windows.Forms.Application.Run(new KETNOISQL());
            //}
            if (System.IO.File.Exists(duongdan + "xacnhandaketnoi.txt"))
            {
                //string filename = duongdan + "savevalues.txt";
                string mofile = File.ReadAllText(duongdan + "xacnhandaketnoi.txt");
                //string mofile1 = File.ReadAllText(duongdan + "savevalues.txt");
                
                if(mofile == "daketnoi")
                {
                    System.Windows.Forms.Application.Run(new Home());
                }
            }
            else
            {
                System.Windows.Forms.Application.Run(new KETNOISQL());
            }
        }
    }
}
