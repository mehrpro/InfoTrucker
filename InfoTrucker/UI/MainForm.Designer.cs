
namespace InfoTrucker.UI
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.NewPersonButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.EditButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.PersonReportBottonItem = new DevExpress.XtraBars.BarButtonItem();
            this.HoshmandReportButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.MonthReportButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.ThreeMonthReportButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.SixMonthReportButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.YearReportButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barStaticItem1 = new DevExpress.XtraBars.BarStaticItem();
            this.SendSmsButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.SendGroupSmsButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.SendStatusButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.ReceiverButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem5 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem6 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem7 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem8 = new DevExpress.XtraBars.BarButtonItem();
            this.DocumentRibbonPage = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.PGPerson = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.PGPerson2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ReportRibbonPage = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.PGReports = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.PGBillReports = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.SmsRibbonPage = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.PGSendSms = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.SettingRibbonPage = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.PGUsers = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar1 = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.SplashScreenManager = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::InfoTrucker.UI.WaitSaveSMSForm), true, true);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.NewPersonButtonItem,
            this.EditButtonItem,
            this.PersonReportBottonItem,
            this.HoshmandReportButtonItem,
            this.MonthReportButtonItem,
            this.ThreeMonthReportButtonItem,
            this.SixMonthReportButtonItem,
            this.YearReportButtonItem,
            this.barButtonItem1,
            this.barStaticItem1,
            this.SendSmsButtonItem,
            this.SendGroupSmsButtonItem,
            this.SendStatusButtonItem,
            this.ReceiverButtonItem,
            this.barButtonItem2,
            this.barButtonItem3,
            this.barButtonItem4,
            this.barButtonItem5,
            this.barButtonItem6,
            this.barButtonItem7,
            this.barButtonItem8});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 22;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.DocumentRibbonPage,
            this.ReportRibbonPage,
            this.SmsRibbonPage,
            this.SettingRibbonPage});
            this.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2019;
            this.ribbonControl1.Size = new System.Drawing.Size(894, 174);
            this.ribbonControl1.StatusBar = this.ribbonStatusBar1;
            // 
            // NewPersonButtonItem
            // 
            this.NewPersonButtonItem.Caption = "عضو جدید";
            this.NewPersonButtonItem.Id = 1;
            this.NewPersonButtonItem.ImageOptions.Image = global::InfoTrucker.Properties.Resources.icons8_add_user_male_48;
            this.NewPersonButtonItem.Name = "NewPersonButtonItem";
            this.NewPersonButtonItem.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.NewPersonButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.NewPersonButtonItem_ItemClick);
            // 
            // EditButtonItem
            // 
            this.EditButtonItem.Caption = "ویرایش ";
            this.EditButtonItem.Id = 2;
            this.EditButtonItem.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("EditButtonItem.ImageOptions.SvgImage")));
            this.EditButtonItem.Name = "EditButtonItem";
            this.EditButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.EditButtonItem_ItemClick);
            // 
            // PersonReportBottonItem
            // 
            this.PersonReportBottonItem.Caption = "لیست اعضاء";
            this.PersonReportBottonItem.Id = 3;
            this.PersonReportBottonItem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("PersonReportBottonItem.ImageOptions.Image")));
            this.PersonReportBottonItem.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("PersonReportBottonItem.ImageOptions.LargeImage")));
            this.PersonReportBottonItem.Name = "PersonReportBottonItem";
            // 
            // HoshmandReportButtonItem
            // 
            this.HoshmandReportButtonItem.Caption = "لیست شماره هوشمند";
            this.HoshmandReportButtonItem.Id = 4;
            this.HoshmandReportButtonItem.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("HoshmandReportButtonItem.ImageOptions.SvgImage")));
            this.HoshmandReportButtonItem.Name = "HoshmandReportButtonItem";
            // 
            // MonthReportButtonItem
            // 
            this.MonthReportButtonItem.Caption = "گزارش ماهانه";
            this.MonthReportButtonItem.Id = 5;
            this.MonthReportButtonItem.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("MonthReportButtonItem.ImageOptions.SvgImage")));
            this.MonthReportButtonItem.Name = "MonthReportButtonItem";
            // 
            // ThreeMonthReportButtonItem
            // 
            this.ThreeMonthReportButtonItem.Caption = "گزارش سه ماهه";
            this.ThreeMonthReportButtonItem.Id = 6;
            this.ThreeMonthReportButtonItem.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("ThreeMonthReportButtonItem.ImageOptions.SvgImage")));
            this.ThreeMonthReportButtonItem.Name = "ThreeMonthReportButtonItem";
            // 
            // SixMonthReportButtonItem
            // 
            this.SixMonthReportButtonItem.Caption = "گزارش شش ماهه";
            this.SixMonthReportButtonItem.Id = 7;
            this.SixMonthReportButtonItem.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("SixMonthReportButtonItem.ImageOptions.SvgImage")));
            this.SixMonthReportButtonItem.Name = "SixMonthReportButtonItem";
            // 
            // YearReportButtonItem
            // 
            this.YearReportButtonItem.Caption = "گزارش سالانه";
            this.YearReportButtonItem.Id = 8;
            this.YearReportButtonItem.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("YearReportButtonItem.ImageOptions.SvgImage")));
            this.YearReportButtonItem.Name = "YearReportButtonItem";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "barButtonItem1";
            this.barButtonItem1.Id = 9;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // barStaticItem1
            // 
            this.barStaticItem1.Caption = "barStaticItem1";
            this.barStaticItem1.Id = 10;
            this.barStaticItem1.Name = "barStaticItem1";
            // 
            // SendSmsButtonItem
            // 
            this.SendSmsButtonItem.Caption = "ارسال تکی";
            this.SendSmsButtonItem.Id = 11;
            this.SendSmsButtonItem.ImageOptions.Image = global::InfoTrucker.Properties.Resources.icons8_new_message_32;
            this.SendSmsButtonItem.Name = "SendSmsButtonItem";
            this.SendSmsButtonItem.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.SendSmsButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.SendSmsButtonItem_ItemClick);
            // 
            // SendGroupSmsButtonItem
            // 
            this.SendGroupSmsButtonItem.Caption = "ارسال گروهی";
            this.SendGroupSmsButtonItem.Id = 12;
            this.SendGroupSmsButtonItem.ImageOptions.Image = global::InfoTrucker.Properties.Resources.icons8_subscription_32;
            this.SendGroupSmsButtonItem.Name = "SendGroupSmsButtonItem";
            this.SendGroupSmsButtonItem.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.SendGroupSmsButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.SendGroupSmsButtonItem_ItemClick);
            // 
            // SendStatusButtonItem
            // 
            this.SendStatusButtonItem.Caption = "پیام های ارسالی";
            this.SendStatusButtonItem.Enabled = false;
            this.SendStatusButtonItem.Id = 13;
            this.SendStatusButtonItem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("SendStatusButtonItem.ImageOptions.Image")));
            this.SendStatusButtonItem.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("SendStatusButtonItem.ImageOptions.LargeImage")));
            this.SendStatusButtonItem.Name = "SendStatusButtonItem";
            this.SendStatusButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.SendStatusButtonItem_ItemClick);
            // 
            // ReceiverButtonItem
            // 
            this.ReceiverButtonItem.Caption = "پیام های دریافتی";
            this.ReceiverButtonItem.Id = 14;
            this.ReceiverButtonItem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ReceiverButtonItem.ImageOptions.Image")));
            this.ReceiverButtonItem.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("ReceiverButtonItem.ImageOptions.LargeImage")));
            this.ReceiverButtonItem.Name = "ReceiverButtonItem";
            this.ReceiverButtonItem.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "رانندگان بومی ";
            this.barButtonItem2.Enabled = false;
            this.barButtonItem2.Id = 15;
            this.barButtonItem2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.ImageOptions.Image")));
            this.barButtonItem2.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.ImageOptions.LargeImage")));
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "مصوبات مالی رانندگان بومی";
            this.barButtonItem3.Enabled = false;
            this.barButtonItem3.Id = 16;
            this.barButtonItem3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem3.ImageOptions.Image")));
            this.barButtonItem3.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem3.ImageOptions.LargeImage")));
            this.barButtonItem3.Name = "barButtonItem3";
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.Caption = "مصوبات مالی اعضا انجمن";
            this.barButtonItem4.Enabled = false;
            this.barButtonItem4.Id = 17;
            this.barButtonItem4.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem4.ImageOptions.Image")));
            this.barButtonItem4.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem4.ImageOptions.LargeImage")));
            this.barButtonItem4.Name = "barButtonItem4";
            // 
            // barButtonItem5
            // 
            this.barButtonItem5.Caption = "مصوبات مالی اعضا غیر بومی";
            this.barButtonItem5.Enabled = false;
            this.barButtonItem5.Id = 18;
            this.barButtonItem5.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem5.ImageOptions.Image")));
            this.barButtonItem5.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem5.ImageOptions.LargeImage")));
            this.barButtonItem5.Name = "barButtonItem5";
            // 
            // barButtonItem6
            // 
            this.barButtonItem6.Caption = "رانندگان غیربومی";
            this.barButtonItem6.Enabled = false;
            this.barButtonItem6.Id = 19;
            this.barButtonItem6.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem6.ImageOptions.Image")));
            this.barButtonItem6.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem6.ImageOptions.LargeImage")));
            this.barButtonItem6.Name = "barButtonItem6";
            // 
            // barButtonItem7
            // 
            this.barButtonItem7.Caption = " کاربران";
            this.barButtonItem7.Id = 20;
            this.barButtonItem7.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem7.ImageOptions.Image")));
            this.barButtonItem7.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem7.ImageOptions.LargeImage")));
            this.barButtonItem7.Name = "barButtonItem7";
            // 
            // barButtonItem8
            // 
            this.barButtonItem8.Caption = "مجوز دسترسی";
            this.barButtonItem8.Id = 21;
            this.barButtonItem8.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem8.ImageOptions.Image")));
            this.barButtonItem8.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem8.ImageOptions.LargeImage")));
            this.barButtonItem8.Name = "barButtonItem8";
            // 
            // DocumentRibbonPage
            // 
            this.DocumentRibbonPage.Appearance.Options.UseTextOptions = true;
            this.DocumentRibbonPage.Appearance.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.Yes;
            this.DocumentRibbonPage.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.PGPerson,
            this.PGPerson2});
            this.DocumentRibbonPage.Name = "DocumentRibbonPage";
            this.DocumentRibbonPage.Text = "اسناد";
            // 
            // PGPerson
            // 
            this.PGPerson.ItemLinks.Add(this.NewPersonButtonItem);
            this.PGPerson.ItemLinks.Add(this.EditButtonItem);
            this.PGPerson.ItemLinks.Add(this.PersonReportBottonItem);
            this.PGPerson.Name = "PGPerson";
            this.PGPerson.Text = "رانندگان انجمن";
            // 
            // PGPerson2
            // 
            this.PGPerson2.ItemLinks.Add(this.barButtonItem2);
            this.PGPerson2.ItemLinks.Add(this.barButtonItem6);
            this.PGPerson2.ItemLinks.Add(this.barButtonItem3);
            this.PGPerson2.ItemLinks.Add(this.barButtonItem4);
            this.PGPerson2.ItemLinks.Add(this.barButtonItem5);
            this.PGPerson2.Name = "PGPerson2";
            this.PGPerson2.Text = "پایانه های نوبت دهی";
            // 
            // ReportRibbonPage
            // 
            this.ReportRibbonPage.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.PGReports,
            this.PGBillReports});
            this.ReportRibbonPage.Name = "ReportRibbonPage";
            this.ReportRibbonPage.Text = "گزارشات";
            // 
            // PGReports
            // 
            this.PGReports.ItemLinks.Add(this.HoshmandReportButtonItem);
            this.PGReports.Name = "PGReports";
            this.PGReports.Text = "گزارشات";
            this.PGReports.Visible = false;
            // 
            // PGBillReports
            // 
            this.PGBillReports.Enabled = false;
            this.PGBillReports.ItemLinks.Add(this.MonthReportButtonItem);
            this.PGBillReports.ItemLinks.Add(this.ThreeMonthReportButtonItem);
            this.PGBillReports.ItemLinks.Add(this.SixMonthReportButtonItem);
            this.PGBillReports.ItemLinks.Add(this.YearReportButtonItem);
            this.PGBillReports.Name = "PGBillReports";
            this.PGBillReports.Text = "نوبت دهی";
            // 
            // SmsRibbonPage
            // 
            this.SmsRibbonPage.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.PGSendSms});
            this.SmsRibbonPage.Name = "SmsRibbonPage";
            this.SmsRibbonPage.Text = "سامانه پیام کوتاه";
            // 
            // PGSendSms
            // 
            this.PGSendSms.ItemLinks.Add(this.SendSmsButtonItem);
            this.PGSendSms.ItemLinks.Add(this.SendGroupSmsButtonItem);
            this.PGSendSms.ItemLinks.Add(this.SendStatusButtonItem);
            this.PGSendSms.ItemLinks.Add(this.ReceiverButtonItem);
            this.PGSendSms.Name = "PGSendSms";
            this.PGSendSms.Text = "پیام کوتاه";
            // 
            // SettingRibbonPage
            // 
            this.SettingRibbonPage.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.PGUsers});
            this.SettingRibbonPage.Name = "SettingRibbonPage";
            this.SettingRibbonPage.Text = "مدیریت نرم افزار";
            this.SettingRibbonPage.Visible = false;
            // 
            // PGUsers
            // 
            this.PGUsers.ItemLinks.Add(this.barButtonItem7);
            this.PGUsers.ItemLinks.Add(this.barButtonItem8);
            this.PGUsers.Name = "PGUsers";
            this.PGUsers.Text = "مدیریت کاربران";
            // 
            // ribbonStatusBar1
            // 
            this.ribbonStatusBar1.Location = new System.Drawing.Point(0, 535);
            this.ribbonStatusBar1.Name = "ribbonStatusBar1";
            this.ribbonStatusBar1.Ribbon = this.ribbonControl1;
            this.ribbonStatusBar1.Size = new System.Drawing.Size(894, 35);
            // 
            // SplashScreenManager
            // 
            this.SplashScreenManager.ClosingDelay = 500;
            // 
            // MainForm
            // 
            this.AllowFormGlass = DevExpress.Utils.DefaultBoolean.True;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 570);
            this.Controls.Add(this.ribbonStatusBar1);
            this.Controls.Add(this.ribbonControl1);
            this.IsMdiContainer = true;
            this.Name = "MainForm";
            this.Ribbon = this.ribbonControl1;
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StatusBar = this.ribbonStatusBar1;
            this.Text = "مرکز اسناد انجمن صنفی رانندگان";
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage DocumentRibbonPage;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup PGPerson;
        private DevExpress.XtraBars.BarButtonItem NewPersonButtonItem;
        private DevExpress.XtraBars.BarButtonItem EditButtonItem;
        private DevExpress.XtraBars.BarButtonItem PersonReportBottonItem;
        private DevExpress.XtraBars.BarButtonItem HoshmandReportButtonItem;
        private DevExpress.XtraBars.BarButtonItem MonthReportButtonItem;
        private DevExpress.XtraBars.BarButtonItem ThreeMonthReportButtonItem;
        private DevExpress.XtraBars.BarButtonItem SixMonthReportButtonItem;
        private DevExpress.XtraBars.BarButtonItem YearReportButtonItem;
        private DevExpress.XtraBars.Ribbon.RibbonPage ReportRibbonPage;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup PGReports;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarStaticItem barStaticItem1;
        private DevExpress.XtraBars.BarButtonItem SendSmsButtonItem;
        private DevExpress.XtraBars.BarButtonItem SendGroupSmsButtonItem;
        private DevExpress.XtraBars.BarButtonItem SendStatusButtonItem;
        private DevExpress.XtraBars.Ribbon.RibbonPage SmsRibbonPage;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup PGSendSms;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup PGBillReports;
        private DevExpress.XtraBars.BarButtonItem ReceiverButtonItem;
        private DevExpress.XtraSplashScreen.SplashScreenManager SplashScreenManager;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup PGPerson2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private DevExpress.XtraBars.BarButtonItem barButtonItem5;
        private DevExpress.XtraBars.BarButtonItem barButtonItem6;
        private DevExpress.XtraBars.BarButtonItem barButtonItem7;
        private DevExpress.XtraBars.BarButtonItem barButtonItem8;
        private DevExpress.XtraBars.Ribbon.RibbonPage SettingRibbonPage;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup PGUsers;
    }
}