using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using InfoTrucker.DTO;
using Microsoft.SqlServer.Management.Common;
using Microsoft.SqlServer.Management.Smo;

namespace InfoTrucker.UI.Admin
{
    public partial class NewDBForm : XtraForm
    {

        private ConnectionStrDTO _connectionStr;
        private List<string> _databaseList;
        public ConnectionStrDTO ConnectionStr { get => _connectionStr; set => _connectionStr = value; }
        public List<string> DatabaseList { get => _databaseList; set => _databaseList = value; }
        public NewDBForm()
        {
            InitializeComponent();
            progressBar.Visible = false;

        }



        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (dx.Validate())
            {

                var folderBrowserDialog = new FolderBrowserDialog { ShowNewFolderButton = true };
                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    var folder = folderBrowserDialog.SelectedPath;
                    var scriptNew = Properties.Resources.sqlScriptForNewDatabase.Replace("95", cbxDataBase.Text).Replace("AddressFileForSave", folder);
                    var srvConn = new ServerConnection(_connectionStr.Server_Instance);
                    srvConn.LoginSecure = _connectionStr.WindowsAuthentication;
                    srvConn.ServerInstance = _connectionStr.Server_Instance;
                    if (!_connectionStr.WindowsAuthentication)
                    {
                        srvConn.Password = _connectionStr.Password;
                        srvConn.Login = _connectionStr.UserID;
                    }

                    var result = _setDatabase.SqlServerConnect(_connectionStr);
                    if (result)
                    {
                        try
                        {
                            var srv = new Server(srvConn);
                            srv.ConnectionContext.ExecuteNonQuery(scriptNew);
                            srv.ConnectionContext.ExecuteNonQuery(Properties.Resources.ScriptCompany.Replace("95", cbxDataBase.Text.Trim()));
                            srv.ConnectionContext.ExecuteNonQuery(Properties.Resources.ScriptApplicationUser.Replace("95", cbxDataBase.Text.Trim()));
                            srv.ConnectionContext.ExecuteNonQuery(Properties.Resources.ScriptUnitOfMa.Replace("95", cbxDataBase.Text.Trim()));
                            srv.ConnectionContext.ExecuteNonQuery(Properties.Resources.ScriptMenu.Replace("95", cbxDataBase.Text.Trim()));
                            _connectionStr.DatabaseName = cbxDataBase.Text.Trim();
                            var connectionString = _setDatabase.SaveAppSetting(_connectionStr);
                            if (connectionString)
                            {
                                XtraMessageBox.Show("بانک اطلاعاتی جدید با موفقیت ایجاد شد", "بانک اطلاعاتی",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                                PublicValue.CloseForce = true;
                                Close();
                            }
                            else
                            {
                                PublicValue.ErrorSaveMessage();
                            }
                        }
                        catch (Exception exception)
                        {
                            XtraMessageBox.Show(exception.Message, "Error");
                        }

                    }
                    else
                        XtraMessageBox.Show("ارتباط با سرور ممکن نیست", "خطا", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                }

            }
            else
            {
                PublicValue.ValidationProviderFaultMessage();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void NewDBForm_Load(object sender, EventArgs e)
        {
            txtServer.Text = _connectionStr.ServerName;
            txtAuthentication.Text = _connectionStr.WindowsAuthentication ? @"Windows Authentication" : @"SQL Server Authentication";
            txtUser.Text = _connectionStr.UserID;
            cbxDataBase.Properties.Items.AddRange(_databaseList);
        }
    }
}
