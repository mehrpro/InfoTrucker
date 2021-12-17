
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
            this.PeopleButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.DocumentRibbonPage = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.PersonPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.fluentDesignFormContainer1 = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.NewPersonButtonItem,
            this.PeopleButtonItem});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 3;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.DocumentRibbonPage});
            this.ribbonControl1.Size = new System.Drawing.Size(800, 176);
            // 
            // NewPersonButtonItem
            // 
            this.NewPersonButtonItem.Caption = "عضو جدید";
            this.NewPersonButtonItem.Id = 1;
            this.NewPersonButtonItem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("NewPersonButtonItem.ImageOptions.Image")));
            this.NewPersonButtonItem.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("NewPersonButtonItem.ImageOptions.LargeImage")));
            this.NewPersonButtonItem.Name = "NewPersonButtonItem";
            this.NewPersonButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.NewPersonButtonItem_ItemClick);
            // 
            // PeopleButtonItem
            // 
            this.PeopleButtonItem.Caption = "لیست اعضاء";
            this.PeopleButtonItem.Id = 2;
            this.PeopleButtonItem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("PeopleButtonItem.ImageOptions.Image")));
            this.PeopleButtonItem.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("PeopleButtonItem.ImageOptions.LargeImage")));
            this.PeopleButtonItem.Name = "PeopleButtonItem";
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
            this.PersonPageGroup.ItemLinks.Add(this.PeopleButtonItem);
            this.PersonPageGroup.Name = "PersonPageGroup";
            this.PersonPageGroup.Text = "رانندگان";
            // 
            // fluentDesignFormContainer1
            // 
            this.fluentDesignFormContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fluentDesignFormContainer1.Location = new System.Drawing.Point(0, 176);
            this.fluentDesignFormContainer1.Name = "fluentDesignFormContainer1";
            this.fluentDesignFormContainer1.Size = new System.Drawing.Size(800, 273);
            this.fluentDesignFormContainer1.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AllowFormGlass = DevExpress.Utils.DefaultBoolean.False;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 449);
            this.Controls.Add(this.fluentDesignFormContainer1);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "MainForm";
            this.Ribbon = this.ribbonControl1;
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
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
        private DevExpress.XtraBars.BarButtonItem PeopleButtonItem;
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer fluentDesignFormContainer1;
    }
}