using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Sql;
using InfoTrucker.DTO;
using InfoTrucker.Infrastructure;
using Microsoft.SqlServer.Management.Common;
using Microsoft.SqlServer.Management.Smo;


namespace InfoTrucker.Services
{
    public interface IDbRepository
    {
        /// <summary>
        /// لیست سرورها
        /// </summary>
        /// <returns></returns>
        List<string> GetServerInstance();
        /// <summary>
        /// لیست بانک های اطلاعاتی براساس نام سرور
        /// </summary>
        /// <param name="model">مدل</param>
        /// <returns></returns>
        List<string> GetDatabaseListByServerName(ConnectionStrDTO model);
        /// <summary>
        /// تست ارتباط با سرور
        /// </summary>
        /// <param name="model">مدل</param>
        /// <returns></returns>
        bool SqlServerConnect(ConnectionStrDTO model);
        /// <summary>
        /// ذخیره رشته اتطال
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        bool SaveAppSetting(ConnectionStrDTO model);
    }

    public class DbRepository : IDbRepository
    {
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

        public List<string> GetDatabaseListByServerName(ConnectionStrDTO model)
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




        public bool SqlServerConnect(ConnectionStrDTO model)
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

        public bool SaveAppSetting(ConnectionStrDTO model)
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
                    appSetting.SaveConnectionString("cn", connectionString);
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
                    appSetting.SaveConnectionString("cn", connectionString);
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
