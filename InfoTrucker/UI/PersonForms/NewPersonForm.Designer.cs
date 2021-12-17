
namespace InfoTrucker.UI.PersonForms
{
    partial class NewPersonForm
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
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.PersonTabPage = new DevExpress.XtraTab.XtraTabPage();
            this.JobTabPage = new DevExpress.XtraTab.XtraTabPage();
            this.AddressTabPage = new DevExpress.XtraTab.XtraTabPage();
            this.BottonSidePanel = new DevExpress.XtraEditors.SidePanel();
            this.sidePanel1 = new DevExpress.XtraEditors.SidePanel();
            this.PictureSidePanel = new DevExpress.XtraEditors.SidePanel();
            this.InformationSidePanel = new DevExpress.XtraEditors.SidePanel();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.NameLabel = new DevExpress.XtraEditors.LabelControl();
            this.textEdit2 = new DevExpress.XtraEditors.TextEdit();
            this.FamilyLabel = new DevExpress.XtraEditors.LabelControl();
            this.textEdit3 = new DevExpress.XtraEditors.TextEdit();
            this.FatherLabel = new DevExpress.XtraEditors.LabelControl();
            this.textEdit4 = new DevExpress.XtraEditors.TextEdit();
            this.BrithLabel = new DevExpress.XtraEditors.LabelControl();
            this.textEdit5 = new DevExpress.XtraEditors.TextEdit();
            this.NationalLabel = new DevExpress.XtraEditors.LabelControl();
            this.textEdit6 = new DevExpress.XtraEditors.TextEdit();
            this.SerialSHLabel = new DevExpress.XtraEditors.LabelControl();
            this.textEdit7 = new DevExpress.XtraEditors.TextEdit();
            this.ShLabel = new DevExpress.XtraEditors.LabelControl();
            this.textEdit8 = new DevExpress.XtraEditors.TextEdit();
            this.MahalTavalodLabel = new DevExpress.XtraEditors.LabelControl();
            this.textEdit9 = new DevExpress.XtraEditors.TextEdit();
            this.IdLabel = new DevExpress.XtraEditors.LabelControl();
            this.PersonPictureEdit = new DevExpress.XtraEditors.PictureEdit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.PersonTabPage.SuspendLayout();
            this.sidePanel1.SuspendLayout();
            this.PictureSidePanel.SuspendLayout();
            this.InformationSidePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit4.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit5.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit6.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit7.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit8.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit9.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PersonPictureEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.AppearancePage.Header.Options.UseTextOptions = true;
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl1.Location = new System.Drawing.Point(0, 0);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.PersonTabPage;
            this.xtraTabControl1.Size = new System.Drawing.Size(800, 400);
            this.xtraTabControl1.TabIndex = 0;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.PersonTabPage,
            this.JobTabPage,
            this.AddressTabPage});
            // 
            // PersonTabPage
            // 
            this.PersonTabPage.Controls.Add(this.InformationSidePanel);
            this.PersonTabPage.Controls.Add(this.PictureSidePanel);
            this.PersonTabPage.Name = "PersonTabPage";
            this.PersonTabPage.Size = new System.Drawing.Size(794, 365);
            this.PersonTabPage.Text = "مشخصات فردی";
            // 
            // JobTabPage
            // 
            this.JobTabPage.Name = "JobTabPage";
            this.JobTabPage.Size = new System.Drawing.Size(794, 365);
            this.JobTabPage.Text = "مشخصات شغلی";
            // 
            // AddressTabPage
            // 
            this.AddressTabPage.Name = "AddressTabPage";
            this.AddressTabPage.Size = new System.Drawing.Size(794, 151);
            this.AddressTabPage.Text = "اطلاعات تماس";
            // 
            // BottonSidePanel
            // 
            this.BottonSidePanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BottonSidePanel.Location = new System.Drawing.Point(0, 400);
            this.BottonSidePanel.Name = "BottonSidePanel";
            this.BottonSidePanel.Size = new System.Drawing.Size(800, 50);
            this.BottonSidePanel.TabIndex = 1;
            this.BottonSidePanel.Text = "sidePanel1";
            // 
            // sidePanel1
            // 
            this.sidePanel1.Controls.Add(this.xtraTabControl1);
            this.sidePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sidePanel1.Location = new System.Drawing.Point(0, 0);
            this.sidePanel1.Name = "sidePanel1";
            this.sidePanel1.Size = new System.Drawing.Size(800, 400);
            this.sidePanel1.TabIndex = 2;
            this.sidePanel1.Text = "sidePanel1";
            // 
            // PictureSidePanel
            // 
            this.PictureSidePanel.Controls.Add(this.PersonPictureEdit);
            this.PictureSidePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.PictureSidePanel.Location = new System.Drawing.Point(0, 0);
            this.PictureSidePanel.Name = "PictureSidePanel";
            this.PictureSidePanel.Size = new System.Drawing.Size(232, 365);
            this.PictureSidePanel.TabIndex = 0;
            this.PictureSidePanel.Text = "sidePanel2";
            // 
            // InformationSidePanel
            // 
            this.InformationSidePanel.Controls.Add(this.IdLabel);
            this.InformationSidePanel.Controls.Add(this.MahalTavalodLabel);
            this.InformationSidePanel.Controls.Add(this.ShLabel);
            this.InformationSidePanel.Controls.Add(this.SerialSHLabel);
            this.InformationSidePanel.Controls.Add(this.NationalLabel);
            this.InformationSidePanel.Controls.Add(this.BrithLabel);
            this.InformationSidePanel.Controls.Add(this.FatherLabel);
            this.InformationSidePanel.Controls.Add(this.FamilyLabel);
            this.InformationSidePanel.Controls.Add(this.NameLabel);
            this.InformationSidePanel.Controls.Add(this.textEdit9);
            this.InformationSidePanel.Controls.Add(this.textEdit8);
            this.InformationSidePanel.Controls.Add(this.textEdit7);
            this.InformationSidePanel.Controls.Add(this.textEdit6);
            this.InformationSidePanel.Controls.Add(this.textEdit5);
            this.InformationSidePanel.Controls.Add(this.textEdit4);
            this.InformationSidePanel.Controls.Add(this.textEdit3);
            this.InformationSidePanel.Controls.Add(this.textEdit2);
            this.InformationSidePanel.Controls.Add(this.textEdit1);
            this.InformationSidePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InformationSidePanel.Location = new System.Drawing.Point(232, 0);
            this.InformationSidePanel.Name = "InformationSidePanel";
            this.InformationSidePanel.Size = new System.Drawing.Size(562, 365);
            this.InformationSidePanel.TabIndex = 1;
            this.InformationSidePanel.Text = "sidePanel3";
            // 
            // textEdit1
            // 
            this.textEdit1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textEdit1.Location = new System.Drawing.Point(20, 54);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Parmida_ActivePlusMultiKeys = false;
            this.textEdit1.Size = new System.Drawing.Size(405, 26);
            this.textEdit1.TabIndex = 0;
            // 
            // NameLabel
            // 
            this.NameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NameLabel.Location = new System.Drawing.Point(439, 57);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(14, 20);
            this.NameLabel.TabIndex = 1;
            this.NameLabel.Text = "نام";
            // 
            // textEdit2
            // 
            this.textEdit2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textEdit2.Location = new System.Drawing.Point(20, 86);
            this.textEdit2.Name = "textEdit2";
            this.textEdit2.Parmida_ActivePlusMultiKeys = false;
            this.textEdit2.Size = new System.Drawing.Size(405, 26);
            this.textEdit2.TabIndex = 0;
            // 
            // FamilyLabel
            // 
            this.FamilyLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.FamilyLabel.Location = new System.Drawing.Point(439, 89);
            this.FamilyLabel.Name = "FamilyLabel";
            this.FamilyLabel.Size = new System.Drawing.Size(60, 20);
            this.FamilyLabel.TabIndex = 1;
            this.FamilyLabel.Text = "نام خانوادگی";
            // 
            // textEdit3
            // 
            this.textEdit3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textEdit3.Location = new System.Drawing.Point(20, 118);
            this.textEdit3.Name = "textEdit3";
            this.textEdit3.Parmida_ActivePlusMultiKeys = false;
            this.textEdit3.Size = new System.Drawing.Size(405, 26);
            this.textEdit3.TabIndex = 0;
            // 
            // FatherLabel
            // 
            this.FatherLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.FatherLabel.Location = new System.Drawing.Point(439, 121);
            this.FatherLabel.Name = "FatherLabel";
            this.FatherLabel.Size = new System.Drawing.Size(34, 20);
            this.FatherLabel.TabIndex = 1;
            this.FatherLabel.Text = "نام پدر";
            // 
            // textEdit4
            // 
            this.textEdit4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textEdit4.Location = new System.Drawing.Point(20, 150);
            this.textEdit4.Name = "textEdit4";
            this.textEdit4.Parmida_ActivePlusMultiKeys = false;
            this.textEdit4.Size = new System.Drawing.Size(405, 26);
            this.textEdit4.TabIndex = 0;
            // 
            // BrithLabel
            // 
            this.BrithLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BrithLabel.Location = new System.Drawing.Point(439, 153);
            this.BrithLabel.Name = "BrithLabel";
            this.BrithLabel.Size = new System.Drawing.Size(47, 20);
            this.BrithLabel.TabIndex = 1;
            this.BrithLabel.Text = "تاریخ تولد";
            // 
            // textEdit5
            // 
            this.textEdit5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textEdit5.Location = new System.Drawing.Point(20, 182);
            this.textEdit5.Name = "textEdit5";
            this.textEdit5.Parmida_ActivePlusMultiKeys = false;
            this.textEdit5.Size = new System.Drawing.Size(405, 26);
            this.textEdit5.TabIndex = 0;
            // 
            // NationalLabel
            // 
            this.NationalLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NationalLabel.Location = new System.Drawing.Point(439, 185);
            this.NationalLabel.Name = "NationalLabel";
            this.NationalLabel.Size = new System.Drawing.Size(32, 20);
            this.NationalLabel.TabIndex = 1;
            this.NationalLabel.Text = "کد ملی";
            // 
            // textEdit6
            // 
            this.textEdit6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textEdit6.Location = new System.Drawing.Point(20, 214);
            this.textEdit6.Name = "textEdit6";
            this.textEdit6.Parmida_ActivePlusMultiKeys = false;
            this.textEdit6.Size = new System.Drawing.Size(405, 26);
            this.textEdit6.TabIndex = 0;
            // 
            // SerialSHLabel
            // 
            this.SerialSHLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SerialSHLabel.Location = new System.Drawing.Point(439, 217);
            this.SerialSHLabel.Name = "SerialSHLabel";
            this.SerialSHLabel.Size = new System.Drawing.Size(110, 20);
            this.SerialSHLabel.TabIndex = 1;
            this.SerialSHLabel.Text = "شماره سریال شناسنامه";
            // 
            // textEdit7
            // 
            this.textEdit7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textEdit7.Location = new System.Drawing.Point(20, 246);
            this.textEdit7.Name = "textEdit7";
            this.textEdit7.Parmida_ActivePlusMultiKeys = false;
            this.textEdit7.Size = new System.Drawing.Size(405, 26);
            this.textEdit7.TabIndex = 0;
            // 
            // ShLabel
            // 
            this.ShLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ShLabel.Location = new System.Drawing.Point(439, 249);
            this.ShLabel.Name = "ShLabel";
            this.ShLabel.Size = new System.Drawing.Size(76, 20);
            this.ShLabel.TabIndex = 1;
            this.ShLabel.Text = "شماره شناسنامه";
            // 
            // textEdit8
            // 
            this.textEdit8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textEdit8.Location = new System.Drawing.Point(20, 278);
            this.textEdit8.Name = "textEdit8";
            this.textEdit8.Parmida_ActivePlusMultiKeys = false;
            this.textEdit8.Size = new System.Drawing.Size(405, 26);
            this.textEdit8.TabIndex = 0;
            // 
            // MahalTavalodLabel
            // 
            this.MahalTavalodLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MahalTavalodLabel.Location = new System.Drawing.Point(439, 281);
            this.MahalTavalodLabel.Name = "MahalTavalodLabel";
            this.MahalTavalodLabel.Size = new System.Drawing.Size(44, 20);
            this.MahalTavalodLabel.TabIndex = 1;
            this.MahalTavalodLabel.Text = "محل تولد";
            // 
            // textEdit9
            // 
            this.textEdit9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textEdit9.Location = new System.Drawing.Point(20, 22);
            this.textEdit9.Name = "textEdit9";
            this.textEdit9.Parmida_ActivePlusMultiKeys = false;
            this.textEdit9.Size = new System.Drawing.Size(405, 26);
            this.textEdit9.TabIndex = 0;
            // 
            // IdLabel
            // 
            this.IdLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.IdLabel.Location = new System.Drawing.Point(439, 25);
            this.IdLabel.Name = "IdLabel";
            this.IdLabel.Size = new System.Drawing.Size(64, 20);
            this.IdLabel.TabIndex = 1;
            this.IdLabel.Text = "شماره پرونده";
            // 
            // PersonPictureEdit
            // 
            this.PersonPictureEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PersonPictureEdit.Location = new System.Drawing.Point(11, 12);
            this.PersonPictureEdit.Name = "PersonPictureEdit";
            this.PersonPictureEdit.Parmida_ActivePlusMultiKeys = false;
            this.PersonPictureEdit.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.PersonPictureEdit.Size = new System.Drawing.Size(208, 257);
            this.PersonPictureEdit.TabIndex = 2;
            // 
            // NewPersonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.sidePanel1);
            this.Controls.Add(this.BottonSidePanel);
            this.Name = "NewPersonForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "NewPersonForm";
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.PersonTabPage.ResumeLayout(false);
            this.sidePanel1.ResumeLayout(false);
            this.PictureSidePanel.ResumeLayout(false);
            this.InformationSidePanel.ResumeLayout(false);
            this.InformationSidePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit4.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit5.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit6.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit7.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit8.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit9.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PersonPictureEdit.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage PersonTabPage;
        private DevExpress.XtraTab.XtraTabPage JobTabPage;
        private DevExpress.XtraTab.XtraTabPage AddressTabPage;
        private DevExpress.XtraEditors.SidePanel BottonSidePanel;
        private DevExpress.XtraEditors.SidePanel sidePanel1;
        private DevExpress.XtraEditors.SidePanel InformationSidePanel;
        private DevExpress.XtraEditors.LabelControl IdLabel;
        private DevExpress.XtraEditors.LabelControl MahalTavalodLabel;
        private DevExpress.XtraEditors.LabelControl ShLabel;
        private DevExpress.XtraEditors.LabelControl SerialSHLabel;
        private DevExpress.XtraEditors.LabelControl NationalLabel;
        private DevExpress.XtraEditors.LabelControl BrithLabel;
        private DevExpress.XtraEditors.LabelControl FatherLabel;
        private DevExpress.XtraEditors.LabelControl FamilyLabel;
        private DevExpress.XtraEditors.LabelControl NameLabel;
        private DevExpress.XtraEditors.TextEdit textEdit9;
        private DevExpress.XtraEditors.TextEdit textEdit8;
        private DevExpress.XtraEditors.TextEdit textEdit7;
        private DevExpress.XtraEditors.TextEdit textEdit6;
        private DevExpress.XtraEditors.TextEdit textEdit5;
        private DevExpress.XtraEditors.TextEdit textEdit4;
        private DevExpress.XtraEditors.TextEdit textEdit3;
        private DevExpress.XtraEditors.TextEdit textEdit2;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraEditors.SidePanel PictureSidePanel;
        private DevExpress.XtraEditors.PictureEdit PersonPictureEdit;
    }
}