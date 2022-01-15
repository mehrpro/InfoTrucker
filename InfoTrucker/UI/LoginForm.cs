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
using InfoTrucker.Services;

namespace InfoTrucker.UI
{
    public partial class LoginForm : DevExpress.XtraEditors.XtraForm
    {
        private readonly IUnitofWork _unitofWork;
        private readonly IApplicationUserRepository _applicationUserRepository;
        private readonly ISmsConfigureRepository _smsConfigureRepository;


        public LoginForm(IUnitofWork unitofWork, IApplicationUserRepository applicationUserRepository, ISmsConfigureRepository smsConfigureRepository)
        {
            _unitofWork = unitofWork;
            _applicationUserRepository = applicationUserRepository;
            _smsConfigureRepository = smsConfigureRepository;
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            UsernameTextbox.Text = "admin";
            PasswordTextbox.Text = "Admin708801298";
        }

        private async void LoginButton_Click(object sender, EventArgs e)
        {
            var result = await _applicationUserRepository.LoginTask(UsernameTextbox.Text.Trim(), PasswordTextbox.Text.Trim());
            if (result)
            {
                _smsConfigureRepository.UpdateValue();
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

        private void pictureEdit1_DoubleClick(object sender, EventArgs e)
        {
            this.Hide();
            var frm = _container.GetInstance<SettingForm>();
            frm.ShowDialog();
            this.Show();
        }
    }
}
