using System;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace InfoTrucker
{
    public static class PublicValue
    {
        public static string SmsUsername => @"iaubijar";
        public static string SmsPassword => @"M4228056";
        public static string SmsNumber => @"30007227001374";

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


    }
}