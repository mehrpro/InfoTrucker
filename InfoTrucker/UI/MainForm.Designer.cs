
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
            this.backstageViewControl1 = new DevExpress.XtraBars.Ribbon.BackstageViewControl();
            this.backstageViewClientControl1 = new DevExpress.XtraBars.Ribbon.BackstageViewClientControl();
            this.memoEdit2 = new DevExpress.XtraEditors.MemoEdit();
            this.btnRestore = new DevExpress.XtraEditors.SimpleButton();
            this.btnBackup = new DevExpress.XtraEditors.SimpleButton();
            this.memoEdit1 = new DevExpress.XtraEditors.MemoEdit();
            this.textEdit1 = new DevExpress.XtraEditors.MemoEdit();
            this.backstageViewTabItem1 = new DevExpress.XtraBars.Ribbon.BackstageViewTabItem();
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
            this.DocumentRibbonPage = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.PersonPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ReportRibbonPage = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ReportsRibbonPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.BillReportsRibbonPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.SmsRibbonPage = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.SendSmsRibbonPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar1 = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.SplashScreenManager = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::InfoTrucker.UI.WaitSaveSMSForm), true, true);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.backstageViewControl1)).BeginInit();
            this.backstageViewControl1.SuspendLayout();
            this.backstageViewClientControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.memoEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ApplicationButtonDropDownControl = this.backstageViewControl1;
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
            this.ReceiverButtonItem});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 15;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.DocumentRibbonPage,
            this.ReportRibbonPage,
            this.SmsRibbonPage});
            this.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2019;
            this.ribbonControl1.Size = new System.Drawing.Size(800, 174);
            this.ribbonControl1.StatusBar = this.ribbonStatusBar1;
            // 
            // backstageViewControl1
            // 
            this.backstageViewControl1.Controls.Add(this.backstageViewClientControl1);
            this.backstageViewControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.backstageViewControl1.Items.Add(this.backstageViewTabItem1);
            this.backstageViewControl1.Location = new System.Drawing.Point(0, 174);
            this.backstageViewControl1.Name = "backstageViewControl1";
            this.backstageViewControl1.OwnerControl = this.ribbonControl1;
            this.backstageViewControl1.SelectedTab = this.backstageViewTabItem1;
            this.backstageViewControl1.SelectedTabIndex = 0;
            this.backstageViewControl1.Size = new System.Drawing.Size(800, 396);
            this.backstageViewControl1.TabIndex = 3;
            // 
            // backstageViewClientControl1
            // 
            this.backstageViewClientControl1.Controls.Add(this.memoEdit2);
            this.backstageViewClientControl1.Controls.Add(this.btnRestore);
            this.backstageViewClientControl1.Controls.Add(this.btnBackup);
            this.backstageViewClientControl1.Controls.Add(this.memoEdit1);
            this.backstageViewClientControl1.Controls.Add(this.textEdit1);
            this.backstageViewClientControl1.Location = new System.Drawing.Point(1, 63);
            this.backstageViewClientControl1.Name = "backstageViewClientControl1";
            this.backstageViewClientControl1.Size = new System.Drawing.Size(625, 332);
            this.backstageViewClientControl1.TabIndex = 1;
            // 
            // memoEdit2
            // 
            this.memoEdit2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.memoEdit2.Location = new System.Drawing.Point(11, 18);
            this.memoEdit2.Name = "memoEdit2";
            this.memoEdit2.Parmida_ActivePlusMultiKeys = false;
            this.memoEdit2.Properties.Appearance.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.No;
            this.memoEdit2.Properties.AppearanceDisabled.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.No;
            this.memoEdit2.Properties.AppearanceFocused.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.No;
            this.memoEdit2.Properties.AppearanceReadOnly.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.No;
            this.memoEdit2.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.memoEdit2.Properties.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.memoEdit2.Size = new System.Drawing.Size(385, 88);
            this.memoEdit2.TabIndex = 3;
            // 
            // btnRestore
            // 
            this.btnRestore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRestore.ImageOptions.Image = global::InfoTrucker.Properties.Resources.icons8_database_restore_48;
            this.btnRestore.Location = new System.Drawing.Point(413, 136);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Size = new System.Drawing.Size(180, 90);
            this.btnRestore.TabIndex = 1;
            this.btnRestore.Text = "بازگردانی بانک";
            this.btnRestore.Click += new System.EventHandler(this.btnRestore_Click);
            // 
            // btnBackup
            // 
            this.btnBackup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBackup.ImageOptions.Image = global::InfoTrucker.Properties.Resources.icons8_data_backup_48;
            this.btnBackup.Location = new System.Drawing.Point(413, 16);
            this.btnBackup.Name = "btnBackup";
            this.btnBackup.Size = new System.Drawing.Size(180, 90);
            this.btnBackup.TabIndex = 0;
            this.btnBackup.Text = "پشتیبان گیری";
            this.btnBackup.Click += new System.EventHandler(this.btnBackup_Click);
            // 
            // memoEdit1
            // 
            this.memoEdit1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.memoEdit1.Location = new System.Drawing.Point(11, 138);
            this.memoEdit1.Name = "memoEdit1";
            this.memoEdit1.Parmida_ActivePlusMultiKeys = false;
            this.memoEdit1.Properties.Appearance.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.No;
            this.memoEdit1.Properties.AppearanceDisabled.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.No;
            this.memoEdit1.Properties.AppearanceFocused.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.No;
            this.memoEdit1.Properties.AppearanceReadOnly.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.No;
            this.memoEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.memoEdit1.Properties.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.memoEdit1.Size = new System.Drawing.Size(385, 88);
            this.memoEdit1.TabIndex = 2;
            // 
            // textEdit1
            // 
            this.textEdit1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textEdit1.Location = new System.Drawing.Point(11, 18);
            this.textEdit1.MenuManager = this.ribbonControl1;
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Parmida_ActivePlusMultiKeys = false;
            this.textEdit1.Properties.Appearance.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.No;
            this.textEdit1.Properties.AppearanceDisabled.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.No;
            this.textEdit1.Properties.AppearanceFocused.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.No;
            this.textEdit1.Properties.AppearanceReadOnly.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.No;
            this.textEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.textEdit1.Properties.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textEdit1.Size = new System.Drawing.Size(385, 88);
            this.textEdit1.TabIndex = 2;
            // 
            // backstageViewTabItem1
            // 
            this.backstageViewTabItem1.Caption = "بانک اطلاعاتی";
            this.backstageViewTabItem1.ContentControl = this.backstageViewClientControl1;
            this.backstageViewTabItem1.ImageOptions.ItemNormal.Image = global::InfoTrucker.Properties.Resources.icons8_database_48;
            this.backstageViewTabItem1.Name = "backstageViewTabItem1";
            this.backstageViewTabItem1.Selected = true;
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
            // 
            // DocumentRibbonPage
            // 
            this.DocumentRibbonPage.Appearance.Options.UseTextOptions = true;
            this.DocumentRibbonPage.Appearance.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.Yes;
            this.DocumentRibbonPage.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.PersonPageGroup});
            this.DocumentRibbonPage.Name = "DocumentRibbonPage";
            this.DocumentRibbonPage.Text = "اسناد";
            // 
            // PersonPageGroup
            // 
            this.PersonPageGroup.ItemLinks.Add(this.NewPersonButtonItem);
            this.PersonPageGroup.ItemLinks.Add(this.EditButtonItem);
            this.PersonPageGroup.Name = "PersonPageGroup";
            this.PersonPageGroup.Text = "رانندگان";
            // 
            // ReportRibbonPage
            // 
            this.ReportRibbonPage.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ReportsRibbonPageGroup,
            this.BillReportsRibbonPageGroup});
            this.ReportRibbonPage.Name = "ReportRibbonPage";
            this.ReportRibbonPage.Text = "گزارشات";
            // 
            // ReportsRibbonPageGroup
            // 
            this.ReportsRibbonPageGroup.ItemLinks.Add(this.PersonReportBottonItem);
            this.ReportsRibbonPageGroup.ItemLinks.Add(this.HoshmandReportButtonItem);
            this.ReportsRibbonPageGroup.Name = "ReportsRibbonPageGroup";
            this.ReportsRibbonPageGroup.Text = "گزارشات";
            // 
            // BillReportsRibbonPageGroup
            // 
            this.BillReportsRibbonPageGroup.ItemLinks.Add(this.MonthReportButtonItem);
            this.BillReportsRibbonPageGroup.ItemLinks.Add(this.ThreeMonthReportButtonItem);
            this.BillReportsRibbonPageGroup.ItemLinks.Add(this.SixMonthReportButtonItem);
            this.BillReportsRibbonPageGroup.ItemLinks.Add(this.YearReportButtonItem);
            this.BillReportsRibbonPageGroup.Name = "BillReportsRibbonPageGroup";
            this.BillReportsRibbonPageGroup.Text = "نوبت دهی";
            // 
            // SmsRibbonPage
            // 
            this.SmsRibbonPage.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.SendSmsRibbonPageGroup});
            this.SmsRibbonPage.Name = "SmsRibbonPage";
            this.SmsRibbonPage.Text = "سامانه پیام کوتاه";
            // 
            // SendSmsRibbonPageGroup
            // 
            this.SendSmsRibbonPageGroup.ItemLinks.Add(this.SendSmsButtonItem);
            this.SendSmsRibbonPageGroup.ItemLinks.Add(this.SendGroupSmsButtonItem);
            this.SendSmsRibbonPageGroup.ItemLinks.Add(this.SendStatusButtonItem);
            this.SendSmsRibbonPageGroup.ItemLinks.Add(this.ReceiverButtonItem);
            this.SendSmsRibbonPageGroup.Name = "SendSmsRibbonPageGroup";
            this.SendSmsRibbonPageGroup.Text = "پیام کوتاه";
            // 
            // ribbonStatusBar1
            // 
            this.ribbonStatusBar1.Location = new System.Drawing.Point(0, 535);
            this.ribbonStatusBar1.Name = "ribbonStatusBar1";
            this.ribbonStatusBar1.Ribbon = this.ribbonControl1;
            this.ribbonStatusBar1.Size = new System.Drawing.Size(800, 35);
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
            this.ClientSize = new System.Drawing.Size(800, 570);
            this.Controls.Add(this.ribbonStatusBar1);
            this.Controls.Add(this.backstageViewControl1);
            this.Controls.Add(this.ribbonControl1);
            this.IsMdiContainer = true;
            this.Name = "MainForm";
            this.Ribbon = this.ribbonControl1;
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StatusBar = this.ribbonStatusBar1;
            this.Text = "مرکز اسناد انجمن صنفی رانندگان";
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.backstageViewControl1)).EndInit();
            this.backstageViewControl1.ResumeLayout(false);
            this.backstageViewClientControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.memoEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage DocumentRibbonPage;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup PersonPageGroup;
        private DevExpress.XtraBars.BarButtonItem NewPersonButtonItem;
        private DevExpress.XtraBars.BarButtonItem EditButtonItem;
        private DevExpress.XtraBars.BarButtonItem PersonReportBottonItem;
        private DevExpress.XtraBars.BarButtonItem HoshmandReportButtonItem;
        private DevExpress.XtraBars.BarButtonItem MonthReportButtonItem;
        private DevExpress.XtraBars.BarButtonItem ThreeMonthReportButtonItem;
        private DevExpress.XtraBars.BarButtonItem SixMonthReportButtonItem;
        private DevExpress.XtraBars.BarButtonItem YearReportButtonItem;
        private DevExpress.XtraBars.Ribbon.RibbonPage ReportRibbonPage;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ReportsRibbonPageGroup;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarStaticItem barStaticItem1;
        private DevExpress.XtraBars.BarButtonItem SendSmsButtonItem;
        private DevExpress.XtraBars.BarButtonItem SendGroupSmsButtonItem;
        private DevExpress.XtraBars.BarButtonItem SendStatusButtonItem;
        private DevExpress.XtraBars.Ribbon.RibbonPage SmsRibbonPage;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup SendSmsRibbonPageGroup;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup BillReportsRibbonPageGroup;
        private DevExpress.XtraBars.BarButtonItem ReceiverButtonItem;
        private DevExpress.XtraSplashScreen.SplashScreenManager SplashScreenManager;
        private DevExpress.XtraBars.Ribbon.BackstageViewControl backstageViewControl1;
        private DevExpress.XtraBars.Ribbon.BackstageViewClientControl backstageViewClientControl1;
        private DevExpress.XtraBars.Ribbon.BackstageViewTabItem backstageViewTabItem1;
        private DevExpress.XtraEditors.SimpleButton btnBackup;
        private DevExpress.XtraEditors.SimpleButton btnRestore;
        private DevExpress.XtraEditors.MemoEdit textEdit1;
        private DevExpress.XtraEditors.MemoEdit memoEdit2;
        private DevExpress.XtraEditors.MemoEdit memoEdit1;
    }
}