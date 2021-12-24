
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
            this.DocumentRibbonPage = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.PersonPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ReportRibbonPage = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ReportsRibbonPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.PersonReportBottonItem = new DevExpress.XtraBars.BarButtonItem();
            this.HoshmandReportButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.MonthReportButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.ThreeMonthReportButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.SixMonthReportButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.YearReportButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonStatusBar1 = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barStaticItem1 = new DevExpress.XtraBars.BarStaticItem();
            this.SmsRibbonPage = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.SendSmsRibbonPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.SendSmsButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.SendGroupSmsButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.InboxButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.BillReportsRibbonPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
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
            this.InboxButtonItem});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 14;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.DocumentRibbonPage,
            this.ReportRibbonPage,
            this.SmsRibbonPage});
            this.ribbonControl1.Size = new System.Drawing.Size(800, 175);
            this.ribbonControl1.StatusBar = this.ribbonStatusBar1;
            // 
            // NewPersonButtonItem
            // 
            this.NewPersonButtonItem.Caption = "عضو جدید";
            this.NewPersonButtonItem.Id = 1;
            this.NewPersonButtonItem.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("NewPersonButtonItem.ImageOptions.SvgImage")));
            this.NewPersonButtonItem.Name = "NewPersonButtonItem";
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
            // PersonReportBottonItem
            // 
            this.PersonReportBottonItem.Caption = "لیست اعضاء";
            this.PersonReportBottonItem.Id = 3;
            this.PersonReportBottonItem.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem1.ImageOptions.SvgImage")));
            this.PersonReportBottonItem.Name = "PersonReportBottonItem";
            // 
            // HoshmandReportButtonItem
            // 
            this.HoshmandReportButtonItem.Caption = "لیست شماره هوشمند";
            this.HoshmandReportButtonItem.Id = 4;
            this.HoshmandReportButtonItem.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem2.ImageOptions.SvgImage")));
            this.HoshmandReportButtonItem.Name = "HoshmandReportButtonItem";
            // 
            // MonthReportButtonItem
            // 
            this.MonthReportButtonItem.Caption = "گزارش ماهانه";
            this.MonthReportButtonItem.Id = 5;
            this.MonthReportButtonItem.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem3.ImageOptions.SvgImage")));
            this.MonthReportButtonItem.Name = "MonthReportButtonItem";
            // 
            // ThreeMonthReportButtonItem
            // 
            this.ThreeMonthReportButtonItem.Caption = "گزارش سه ماهه";
            this.ThreeMonthReportButtonItem.Id = 6;
            this.ThreeMonthReportButtonItem.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem4.ImageOptions.SvgImage")));
            this.ThreeMonthReportButtonItem.Name = "ThreeMonthReportButtonItem";
            // 
            // SixMonthReportButtonItem
            // 
            this.SixMonthReportButtonItem.Caption = "گزارش شش ماهه";
            this.SixMonthReportButtonItem.Id = 7;
            this.SixMonthReportButtonItem.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem5.ImageOptions.SvgImage")));
            this.SixMonthReportButtonItem.Name = "SixMonthReportButtonItem";
            // 
            // YearReportButtonItem
            // 
            this.YearReportButtonItem.Caption = "گزارش سالانه";
            this.YearReportButtonItem.Id = 8;
            this.YearReportButtonItem.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem6.ImageOptions.SvgImage")));
            this.YearReportButtonItem.Name = "YearReportButtonItem";
            // 
            // ribbonStatusBar1
            // 
            this.ribbonStatusBar1.Location = new System.Drawing.Point(0, 534);
            this.ribbonStatusBar1.Name = "ribbonStatusBar1";
            this.ribbonStatusBar1.Ribbon = this.ribbonControl1;
            this.ribbonStatusBar1.Size = new System.Drawing.Size(800, 36);
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
            this.SendSmsRibbonPageGroup.ItemLinks.Add(this.InboxButtonItem);
            this.SendSmsRibbonPageGroup.Name = "SendSmsRibbonPageGroup";
            this.SendSmsRibbonPageGroup.Text = "پیام کوتاه";
            // 
            // SendSmsButtonItem
            // 
            this.SendSmsButtonItem.Caption = "ارسال تکی";
            this.SendSmsButtonItem.Id = 11;
            this.SendSmsButtonItem.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem2.ImageOptions.SvgImage1")));
            this.SendSmsButtonItem.Name = "SendSmsButtonItem";
            // 
            // SendGroupSmsButtonItem
            // 
            this.SendGroupSmsButtonItem.Caption = "ارسال گروهی";
            this.SendGroupSmsButtonItem.Id = 12;
            this.SendGroupSmsButtonItem.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem3.ImageOptions.SvgImage1")));
            this.SendGroupSmsButtonItem.Name = "SendGroupSmsButtonItem";
            // 
            // InboxButtonItem
            // 
            this.InboxButtonItem.Caption = "صندوق ارسال";
            this.InboxButtonItem.Id = 13;
            this.InboxButtonItem.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem4.ImageOptions.SvgImage1")));
            this.InboxButtonItem.Name = "InboxButtonItem";
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
            // MainForm
            // 
            this.AllowFormGlass = DevExpress.Utils.DefaultBoolean.True;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 570);
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
        private DevExpress.XtraBars.BarButtonItem InboxButtonItem;
        private DevExpress.XtraBars.Ribbon.RibbonPage SmsRibbonPage;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup SendSmsRibbonPageGroup;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup BillReportsRibbonPageGroup;
    }
}