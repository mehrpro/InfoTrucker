
namespace InfoTrucker.UI.SmsForms
{
    partial class SendSmsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SendSmsForm));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.CloseButton = new DevExpress.XtraEditors.SimpleButton();
            this.SmsNumberTextbox = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.SendButton = new DevExpress.XtraEditors.SimpleButton();
            this.MessageTextbox = new DevExpress.XtraEditors.MemoEdit();
            this.PersonListSearchLookUp = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SmsNumberTextbox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MessageTextbox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PersonListSearchLookUp.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.CaptionImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("groupControl1.CaptionImageOptions.Image")));
            this.groupControl1.Controls.Add(this.CloseButton);
            this.groupControl1.Controls.Add(this.SmsNumberTextbox);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.SendButton);
            this.groupControl1.Controls.Add(this.MessageTextbox);
            this.groupControl1.Controls.Add(this.PersonListSearchLookUp);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(361, 350);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "ارسال پیامک تکی";
            // 
            // CloseButton
            // 
            this.CloseButton.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("CloseButton.ImageOptions.Image")));
            this.CloseButton.Location = new System.Drawing.Point(28, 282);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(85, 45);
            this.CloseButton.TabIndex = 6;
            this.CloseButton.Text = "بستن";
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // SmsNumberTextbox
            // 
            this.SmsNumberTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SmsNumberTextbox.Location = new System.Drawing.Point(28, 67);
            this.SmsNumberTextbox.Name = "SmsNumberTextbox";
            this.SmsNumberTextbox.Parmida_ActivePlusMultiKeys = false;
            this.SmsNumberTextbox.Size = new System.Drawing.Size(229, 26);
            this.SmsNumberTextbox.TabIndex = 4;
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl1.Location = new System.Drawing.Point(263, 70);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(46, 20);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "شماره خط";
            // 
            // labelControl3
            // 
            this.labelControl3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl3.Location = new System.Drawing.Point(263, 133);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(50, 20);
            this.labelControl3.TabIndex = 3;
            this.labelControl3.Text = "متن پیامک";
            // 
            // labelControl2
            // 
            this.labelControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl2.Location = new System.Drawing.Point(263, 102);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(60, 20);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "شماره همراه";
            // 
            // SendButton
            // 
            this.SendButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SendButton.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("SendButton.ImageOptions.Image")));
            this.SendButton.Location = new System.Drawing.Point(119, 282);
            this.SendButton.Name = "SendButton";
            this.SendButton.Size = new System.Drawing.Size(85, 45);
            this.SendButton.TabIndex = 1;
            this.SendButton.Text = "ارسال";
            this.SendButton.Click += new System.EventHandler(this.SendButton_Click);
            // 
            // MessageTextbox
            // 
            this.MessageTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MessageTextbox.Location = new System.Drawing.Point(28, 131);
            this.MessageTextbox.Name = "MessageTextbox";
            this.MessageTextbox.Parmida_ActivePlusMultiKeys = false;
            this.MessageTextbox.Properties.Appearance.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.No;
            this.MessageTextbox.Properties.AppearanceDisabled.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.No;
            this.MessageTextbox.Properties.AppearanceFocused.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.No;
            this.MessageTextbox.Properties.AppearanceReadOnly.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.No;
            this.MessageTextbox.Size = new System.Drawing.Size(229, 145);
            this.MessageTextbox.TabIndex = 5;
            // 
            // PersonListSearchLookUp
            // 
            this.PersonListSearchLookUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PersonListSearchLookUp.Location = new System.Drawing.Point(28, 99);
            this.PersonListSearchLookUp.Name = "PersonListSearchLookUp";
            this.PersonListSearchLookUp.Parmida_ActivePlusMultiKeys = false;
            this.PersonListSearchLookUp.Properties.Appearance.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.No;
            this.PersonListSearchLookUp.Properties.AppearanceDisabled.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.No;
            this.PersonListSearchLookUp.Properties.AppearanceDropDown.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.No;
            this.PersonListSearchLookUp.Properties.AppearanceFocused.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.No;
            this.PersonListSearchLookUp.Properties.AppearanceReadOnly.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.No;
            this.PersonListSearchLookUp.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.PersonListSearchLookUp.Properties.NullText = "";
            this.PersonListSearchLookUp.Properties.PopupSizeable = false;
            this.PersonListSearchLookUp.Properties.PopupView = this.searchLookUpEdit1View;
            this.PersonListSearchLookUp.Size = new System.Drawing.Size(229, 26);
            this.PersonListSearchLookUp.TabIndex = 4;
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // SendSmsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 350);
            this.Controls.Add(this.groupControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SendSmsForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "ارسال پیام تکی";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SmsNumberTextbox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MessageTextbox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PersonListSearchLookUp.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton CloseButton;
        private DevExpress.XtraEditors.TextEdit SmsNumberTextbox;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton SendButton;
        private DevExpress.XtraEditors.MemoEdit MessageTextbox;
        private DevExpress.XtraEditors.SearchLookUpEdit PersonListSearchLookUp;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
    }
}