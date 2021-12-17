﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
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
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var container = new StructureMap.Container(new TypeRegistery());
            var frmLogin = container.GetInstance<UI.LoginForm>();
            Application.Run(frmLogin);
            var result = frmLogin.DialogResult;
            if (result == DialogResult.OK)
            {
                var frmMain = container.GetInstance<MainForm>();
                frmMain.container = container;
                frmMain.ShowDialog();
            }
        }
    }
}