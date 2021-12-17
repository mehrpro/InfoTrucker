using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using StructureMap;
using InfoTrucker.Infrastructure;
using InfoTrucker.UI;

namespace InfoTrucker
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("fa-IR");
            Thread.CurrentThread.CurrentUICulture = Thread.CurrentThread.CurrentCulture;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var container = new Container(new TypeRegistery());
            var frmLogin = container.GetInstance<UI.LoginForm>();
            Application.Run(frmLogin);
            var result = frmLogin.DialogResult;
            if (result == DialogResult.OK)
            {
                var frmMain = container.GetInstance<MainForm>();
                frmMain.container = container;
                frmMain.ShowDialog();
            }
            else
            {
                Environment.Exit(0);
            }
        }
    }
}
