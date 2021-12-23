
namespace InfoTrucker.UI.AdminForms
{
    partial class ScannerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScannerForm));
            this.ScanButton = new DevExpress.XtraEditors.SimpleButton();
            this.PreviewPicturebox = new DevExpress.XtraEditors.PictureEdit();
            this.BackButton = new DevExpress.XtraEditors.SimpleButton();
            this.ForwardButton = new DevExpress.XtraEditors.SimpleButton();
            this.EditButton = new DevExpress.XtraEditors.SimpleButton();
            this.SaveButton = new DevExpress.XtraEditors.SimpleButton();
            this.ScannerListComboBox = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.PictureSizeLabel = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.PreviewPicturebox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ScannerListComboBox.Properties)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ScanButton
            // 
            this.ScanButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ScanButton.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("ScanButton.ImageOptions.SvgImage")));
            this.ScanButton.Location = new System.Drawing.Point(161, 67);
            this.ScanButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ScanButton.Name = "ScanButton";
            this.ScanButton.Size = new System.Drawing.Size(100, 42);
            this.ScanButton.TabIndex = 0;
            this.ScanButton.Text = "scan";
            this.ScanButton.Click += new System.EventHandler(this.ScanButton_Click);
            // 
            // PreviewPicturebox
            // 
            this.PreviewPicturebox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PreviewPicturebox.Location = new System.Drawing.Point(11, 119);
            this.PreviewPicturebox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PreviewPicturebox.Name = "PreviewPicturebox";
            this.PreviewPicturebox.Parmida_ActivePlusMultiKeys = false;
            this.PreviewPicturebox.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.PreviewPicturebox.Size = new System.Drawing.Size(300, 396);
            this.PreviewPicturebox.TabIndex = 1;
            // 
            // BackButton
            // 
            this.BackButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BackButton.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.BackButton.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("BackButton.ImageOptions.SvgImage")));
            this.BackButton.Location = new System.Drawing.Point(11, 67);
            this.BackButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(42, 42);
            this.BackButton.TabIndex = 2;
            // 
            // ForwardButton
            // 
            this.ForwardButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ForwardButton.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.ForwardButton.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton2.ImageOptions.SvgImage")));
            this.ForwardButton.Location = new System.Drawing.Point(61, 67);
            this.ForwardButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ForwardButton.Name = "ForwardButton";
            this.ForwardButton.Size = new System.Drawing.Size(42, 42);
            this.ForwardButton.TabIndex = 3;
            // 
            // EditButton
            // 
            this.EditButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.EditButton.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.EditButton.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton1.ImageOptions.SvgImage")));
            this.EditButton.Location = new System.Drawing.Point(111, 67);
            this.EditButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(42, 42);
            this.EditButton.TabIndex = 4;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveButton.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.SaveButton.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton3.ImageOptions.SvgImage")));
            this.SaveButton.Location = new System.Drawing.Point(269, 67);
            this.SaveButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(42, 42);
            this.SaveButton.TabIndex = 5;
            // 
            // ScannerListComboBox
            // 
            this.ScannerListComboBox.Location = new System.Drawing.Point(102, 21);
            this.ScannerListComboBox.Name = "ScannerListComboBox";
            this.ScannerListComboBox.Parmida_ActivePlusMultiKeys = false;
            this.ScannerListComboBox.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ScannerListComboBox.Size = new System.Drawing.Size(209, 26);
            this.ScannerListComboBox.TabIndex = 6;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(14, 24);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(70, 20);
            this.labelControl1.TabIndex = 7;
            this.labelControl1.Text = "ScannerList";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PictureSizeLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 536);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(324, 22);
            this.statusStrip1.TabIndex = 8;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // PictureSizeLabel
            // 
            this.PictureSizeLabel.Name = "PictureSizeLabel";
            this.PictureSizeLabel.Size = new System.Drawing.Size(118, 17);
            this.PictureSizeLabel.Text = "toolStripStatusLabel1";
            // 
            // ScannerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 558);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.ScannerListComboBox);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.ForwardButton);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.PreviewPicturebox);
            this.Controls.Add(this.ScanButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ScannerForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "ScannerForm";
            this.Load += new System.EventHandler(this.ScannerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PreviewPicturebox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ScannerListComboBox.Properties)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton ScanButton;
        private DevExpress.XtraEditors.PictureEdit PreviewPicturebox;
        private DevExpress.XtraEditors.SimpleButton BackButton;
        private DevExpress.XtraEditors.SimpleButton ForwardButton;
        private DevExpress.XtraEditors.SimpleButton EditButton;
        private DevExpress.XtraEditors.SimpleButton SaveButton;
        private DevExpress.XtraEditors.ComboBoxEdit ScannerListComboBox;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel PictureSizeLabel;
    }
}