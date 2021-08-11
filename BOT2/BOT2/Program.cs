using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;

namespace BOT2
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Functions.Start("notepad.exe");
            Thread.Sleep(3000);
            Functions.Write("تم ");
            Thread.Sleep(200);
            Functions.Write("اختراق ");
            Thread.Sleep(200);
            Functions.Write("الجهاز ");
            Thread.Sleep(4000);
            Functions.Write("{ENTER}");
            Functions.Write("اطفي الجهاز ؟  ");
            Thread.Sleep(4000);
            Functions.LeftMouseClick(9999999, 999999);
            Thread.Sleep(3000);
            Functions.Write("%{F4}");
            Thread.Sleep(2000);
            Functions.Start("notepad.exe");
            Thread.Sleep(3000);
            Functions.Write("لا بمزح ! ");
            Thread.Sleep(2000);
            Thread.Sleep(1000);
            for (int i = 0; i <= 50; i++)
            {  Functions.Start("cmd.exe");
                Thread.Sleep(50);
                Functions.LeftMouseClick(9999999, 999999);
            }
            Functions.Start("notepad.exe");
            Thread.Sleep(1000);
            Functions.Write("شكرا جزيلا ، هذا الفايروس من عمل جميل ابويوسف");


            //Application.Run(new Form1());

        }
    }
}
