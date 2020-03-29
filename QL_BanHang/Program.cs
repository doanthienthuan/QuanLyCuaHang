using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using QL_BanHang.View;
using System.IO;

namespace QL_BanHang
{
    
    static class Program
    {
        public static string con_string = "";
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        
        static void Main()
        {
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if(File.Exists("Config.txt") == false)
            {
                Application.Run(new frmConfig());
            }
            else
            {
                StreamReader fr = new StreamReader("Config.txt");
                string s = fr.ReadLine();
                string server, db, user, pw;
                server = fr.ReadLine();
                db = fr.ReadLine();
                if (s.Equals("sql") == true)
                {
                    user = fr.ReadLine();
                    pw = fr.ReadLine(); 
                    Program.con_string = @"server="+ server +";database=+"+ db +";User ID="+ user+";Password=+"+pw+"";
                }
                else
                {
                    Program.con_string = @"Data Source="+server+";Initial Catalog="+db+";Integrated Security=True";
                }
                Application.Run(new frmDangNhap());
            }
            
        }
    }
}
