using System;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Microsoft.SqlServer.Management.Common;
using Microsoft.SqlServer.Management.Smo;

namespace InfoTrucker
{
    public static class PublicValue
    {
        public static string SmsUsername { get; set; }
        public static string SmsPassword { get; set; }
        public static string SmsNumber { get; set; }
        public static decimal SmsPrice { get; set; }
        public static bool CloseForce { get; set; }

        public static string CancelStr { get => "انصراف"; }
        public static string CloseStr { get => "بستن"; }

        public static string Fullname { get; set; }
        public static int UserID { get; set; }

        private static string SoftwareName => @"مرکز اسناد";

        public static void LoginFault()
        {
            XtraMessageBox.Show($"نام کاربری یا رمز عبور اشتباه است پس از بررسی مجدداً وارد شوید", SoftwareName,
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public static void ValidationProviderFaultMessage()
        {
            XtraMessageBox.Show($"مقادیر الزامی فرم را وارد نمائید", SoftwareName,
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public static void ErrorSaveMessage()
        {
            XtraMessageBox.Show($"اطلاعات ثبت نشد پس از بررسی دوباره تلاش کنید", SoftwareName,
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void SaveMessage()
        {
            XtraMessageBox.Show($"اطلاعات با موفقیت ثبت شد", SoftwareName,
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void ExseptionMessage(string message)
        {
            XtraMessageBox.Show(message, "Administrator",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private static Random random = new Random();

        public static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        public static void SuccsessSendSMS(string reciveId)
        {
            XtraMessageBox.Show($"پیامک با موفقیت ارسال شد کد پیگیری {reciveId}", SoftwareName,
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// Backup a whole database to the specified file.
        /// </summary>
        /// <remarks>
        /// The database must not be in use when backing up
        /// The folder holding the file must have appropriate permissions given
        /// </remarks>
        /// <param name="backUpFile">Full path to file to hold the backup</param>
        public static void BackupDatabase(string backUpFile)
        {

            ServerConnection con = new ServerConnection(@".");
            Server server = new Server(con);
            Backup source = new Backup();
            source.Action = BackupActionType.Database;
            source.Database = "infoTruckerDB";
            BackupDeviceItem destination = new BackupDeviceItem(backUpFile, DeviceType.File);
            source.Devices.Add(destination);
            source.SqlBackup(server);
            con.Disconnect();
        }
        /// <summary>
        /// Restore a whole database from a backup file.
        /// </summary>
        /// <remarks>
        /// The database must not be in use when backing up
        /// The folder holding the file must have appropriate permissions given
        /// </remarks>
        /// <param name="backUpFile">Full path to file to holding the backup</param>
        public static void RestoreDatabase(string backUpFile)
        {
            ServerConnection con = new ServerConnection(@".");
            Server server = new Server(con);
            Restore destination = new Restore();
            destination.Action = RestoreActionType.Database;
            destination.Database = "infoTruckerDB";
            BackupDeviceItem source = new BackupDeviceItem(backUpFile, DeviceType.File);
            destination.Devices.Add(source);
            destination.ReplaceDatabase = true;
            destination.SqlRestore(server);
        }

        public List<string> GetServerInstance()
        {
            var list = new List<string>();
            list.Add(".");
            list.Add("(local)");
            list.Add(@".\SQLEXPRESS");
            list.Add(@"(LocalDB)\MSSQLLocalDB");
            list.Add(string.Format(@"{0}", Environment.MachineName));
            list.Add(string.Format(@"{0}\SQLEXPRESS", Environment.MachineName));
            DataTable dt = SqlDataSourceEnumerator.Instance.GetDataSources();
            foreach (DataRow dr in dt.Rows)
                list.Add(string.Concat(dr["ServerName"], "\\", dr["InstanceName"]));
            return list;
        }

        public List<string> GetDatabaseListByServerName(ConnectionStrViewModel model)
        {
            var result = new List<string>();
            if (model.WindowsAuthentication)
            {
                var srvConn = new ServerConnection(model.Server_Instance);
                srvConn.LoginSecure = true;
                var srv = new Server(srvConn);
                foreach (Database database in srv.Databases)
                    result.Add(database.Name);
                return result;
            }
            else
            {
                var srvConn = new ServerConnection(model.Server_Instance);
                srvConn.LoginSecure = false;

                var srv = new Server(srvConn);
                srv.ConnectionContext.Login = model.UserID;
                srv.ConnectionContext.Password = model.Password;
                foreach (Database database in srv.Databases)
                    result.Add(database.Name);
                return result;
            }
        }




        public bool SqlServerConnect(ConnectionStrViewModel model)
        {
            var servConn = new ServerConnection(model.Server_Instance);
            servConn.ServerInstance = model.Server_Instance;
            servConn.LoginSecure = model.WindowsAuthentication;
            if (!model.WindowsAuthentication)
            {
                servConn.Login = model.UserID;
                servConn.Password = model.Password;
            }
            servConn.Connect();
            return servConn.IsOpen;
        }

        public bool SaveAppSetting(ConnectionStrViewModel model)
        {
            try
            {
                if (model.WindowsAuthentication)
                {
                    var connectionString = "";
                    if (model.InstanceName == null)
                    {
                        connectionString =
                           $"Data Source = {model.ServerName} ; Initial Catalog = {model.DatabaseName} ; Integrated Security = SSPI;";
                    }
                    else
                    {
                        connectionString =
                            $"Data Source = {model.ServerName}\\{model.InstanceName} ; Initial Catalog = {model.DatabaseName} ; Integrated Security = SSPI;";
                    }

                    AppSetting appSetting = new AppSetting();
                    appSetting.SaveConnectionString("Conn", connectionString);
                    return true;
                }
                else
                {
                    var connectionString = "";
                    if (model.InstanceName == null)
                    {
                        connectionString =
                            $"Data Source = {model.ServerName};Initial Catalog={model.DatabaseName};" +
                            $"User ID={model.UserID};" +
                            $"Password={model.Password};";
                    }
                    else
                    {
                        connectionString =
                            $"Data Source = {model.ServerName}\\{model.InstanceName};Initial Catalog={model.DatabaseName};" +
                            $"User ID={model.UserID};" +
                            $"Password={model.Password};";
                    }

                    AppSetting appSetting = new AppSetting();
                    appSetting.SaveConnectionString("Conn", connectionString);
                    return true;
                }
            }
            catch
            {
                return false;
            }

        }
    }
}
}