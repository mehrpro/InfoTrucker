using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.Utils;
using InfoTrucker.Infrastructure;
using InfoTrucker.Models;

namespace InfoTrucker.UI
{
    public partial class LoginForm : DevExpress.XtraEditors.XtraForm
    {
        private readonly UnitofWork<AppDbContext> _unitofWork;

        public LoginForm(UnitofWork<AppDbContext> unitofWork)
        {
            _unitofWork = unitofWork;
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            UsernameTextbox.Text = PasswordTextbox.Text = "admin";
        }

        private async void LoginButton_Click(object sender, EventArgs e)
        {
            var result = await
            _unitofWork.ApplicationUser.LoginTask(UsernameTextbox.Text.Trim(), PasswordTextbox.Text.Trim());
            if (result)
            {
                _unitofWork.SmsConfigure.UpdateValue();
                this.DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                PublicValue.LoginFault();
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }
    }
}
