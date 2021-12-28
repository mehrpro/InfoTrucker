
namespace InfoTrucker.UI.SmsForms
{
    partial class SendSmsGroupForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SendSmsGroupForm));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.PersonGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.FullName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Mobile1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SendSMS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CloseButton = new DevExpress.XtraEditors.SimpleButton();
            this.ReciverNumberTextbox = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.CalcuterTextbx = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.CreditTextbox = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.SmsNumberTextbox = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.SendButton = new DevExpress.XtraEditors.SimpleButton();
            this.MessageTextbox = new DevExpress.XtraEditors.MemoEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.SMSPageTextbox = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PersonGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReciverNumberTextbox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CalcuterTextbx.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CreditTextbox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SmsNumberTextbox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MessageTextbox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SMSPageTextbox.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.CaptionImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("groupControl1.CaptionImageOptions.Image")));
            this.groupControl1.Controls.Add(this.PersonGridControl);
            this.groupControl1.Controls.Add(this.CloseButton);
            this.groupControl1.Controls.Add(this.SMSPageTextbox);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.ReciverNumberTextbox);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.CalcuterTextbx);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.CreditTextbox);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.SmsNumberTextbox);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.SendButton);
            this.groupControl1.Controls.Add(this.MessageTextbox);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(818, 504);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "ارسال پیامک گروهی";
            // 
            // PersonGridControl
            // 
            this.PersonGridControl.Location = new System.Drawing.Point(12, 93);
            this.PersonGridControl.MainView = this.gridView1;
            this.PersonGridControl.Name = "PersonGridControl";
            this.PersonGridControl.Size = new System.Drawing.Size(468, 399);
            this.PersonGridControl.TabIndex = 17;
            this.PersonGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.ColumnFilterButton.Options.UseTextOptions = true;
            this.gridView1.Appearance.ColumnFilterButton.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.ColumnFilterButtonActive.Options.UseTextOptions = true;
            this.gridView1.Appearance.ColumnFilterButtonActive.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.CustomizationFormHint.Options.UseTextOptions = true;
            this.gridView1.Appearance.CustomizationFormHint.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.DetailTip.Options.UseTextOptions = true;
            this.gridView1.Appearance.DetailTip.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.Empty.Options.UseTextOptions = true;
            this.gridView1.Appearance.Empty.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.EvenRow.Options.UseTextOptions = true;
            this.gridView1.Appearance.EvenRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.FilterCloseButton.Options.UseTextOptions = true;
            this.gridView1.Appearance.FilterCloseButton.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.FilterPanel.Options.UseTextOptions = true;
            this.gridView1.Appearance.FilterPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.FixedLine.Options.UseTextOptions = true;
            this.gridView1.Appearance.FixedLine.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.FocusedCell.Options.UseTextOptions = true;
            this.gridView1.Appearance.FocusedCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.FocusedRow.Options.UseTextOptions = true;
            this.gridView1.Appearance.FocusedRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.FooterPanel.Options.UseTextOptions = true;
            this.gridView1.Appearance.FooterPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.GroupButton.Options.UseTextOptions = true;
            this.gridView1.Appearance.GroupButton.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.GroupFooter.Options.UseTextOptions = true;
            this.gridView1.Appearance.GroupFooter.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.GroupPanel.Options.UseTextOptions = true;
            this.gridView1.Appearance.GroupPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.GroupRow.Options.UseTextOptions = true;
            this.gridView1.Appearance.GroupRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gridView1.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.HideSelectionRow.Options.UseTextOptions = true;
            this.gridView1.Appearance.HideSelectionRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.HorzLine.Options.UseTextOptions = true;
            this.gridView1.Appearance.HorzLine.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.OddRow.Options.UseTextOptions = true;
            this.gridView1.Appearance.OddRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.Preview.Options.UseTextOptions = true;
            this.gridView1.Appearance.Preview.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.Row.Options.UseTextOptions = true;
            this.gridView1.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.RowSeparator.Options.UseTextOptions = true;
            this.gridView1.Appearance.RowSeparator.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.SelectedRow.Options.UseTextOptions = true;
            this.gridView1.Appearance.SelectedRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.TopNewRow.Options.UseTextOptions = true;
            this.gridView1.Appearance.TopNewRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.VertLine.Options.UseTextOptions = true;
            this.gridView1.Appearance.VertLine.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.ViewCaption.Options.UseTextOptions = true;
            this.gridView1.Appearance.ViewCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ID,
            this.FullName,
            this.Mobile1,
            this.SendSMS});
            this.gridView1.GridControl = this.PersonGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsFind.AlwaysVisible = true;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // ID
            // 
            this.ID.Caption = "ردیف";
            this.ID.FieldName = "ID";
            this.ID.Name = "ID";
            this.ID.Visible = true;
            this.ID.VisibleIndex = 0;
            this.ID.Width = 54;
            // 
            // FullName
            // 
            this.FullName.Caption = "گیرنده";
            this.FullName.FieldName = "FullName";
            this.FullName.Name = "FullName";
            this.FullName.Visible = true;
            this.FullName.VisibleIndex = 1;
            this.FullName.Width = 154;
            // 
            // Mobile1
            // 
            this.Mobile1.Caption = "موبایل";
            this.Mobile1.FieldName = "Mobile1";
            this.Mobile1.Name = "Mobile1";
            this.Mobile1.Visible = true;
            this.Mobile1.VisibleIndex = 2;
            this.Mobile1.Width = 167;
            // 
            // SendSMS
            // 
            this.SendSMS.Caption = "ارسال";
            this.SendSMS.FieldName = "SendSMS";
            this.SendSMS.Name = "SendSMS";
            this.SendSMS.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "SendSMS", "{0}")});
            this.SendSMS.Visible = true;
            this.SendSMS.VisibleIndex = 3;
            // 
            // CloseButton
            // 
            this.CloseButton.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("CloseButton.ImageOptions.Image")));
            this.CloseButton.Location = new System.Drawing.Point(499, 375);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(85, 45);
            this.CloseButton.TabIndex = 16;
            this.CloseButton.Text = "بستن";
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // ReciverNumberTextbox
            // 
            this.ReciverNumberTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ReciverNumberTextbox.Location = new System.Drawing.Point(499, 128);
            this.ReciverNumberTextbox.Name = "ReciverNumberTextbox";
            this.ReciverNumberTextbox.Parmida_ActivePlusMultiKeys = false;
            this.ReciverNumberTextbox.Size = new System.Drawing.Size(229, 26);
            this.ReciverNumberTextbox.TabIndex = 12;
            // 
            // labelControl6
            // 
            this.labelControl6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl6.Location = new System.Drawing.Point(734, 131);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(72, 20);
            this.labelControl6.TabIndex = 8;
            this.labelControl6.Text = "تعداد گیرندگان";
            // 
            // CalcuterTextbx
            // 
            this.CalcuterTextbx.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CalcuterTextbx.Location = new System.Drawing.Point(499, 192);
            this.CalcuterTextbx.Name = "CalcuterTextbx";
            this.CalcuterTextbx.Parmida_ActivePlusMultiKeys = false;
            this.CalcuterTextbx.Size = new System.Drawing.Size(229, 26);
            this.CalcuterTextbx.TabIndex = 12;
            // 
            // labelControl5
            // 
            this.labelControl5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl5.Location = new System.Drawing.Point(734, 195);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(66, 20);
            this.labelControl5.TabIndex = 8;
            this.labelControl5.Text = "محاسبه هزینه";
            // 
            // CreditTextbox
            // 
            this.CreditTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CreditTextbox.Location = new System.Drawing.Point(499, 96);
            this.CreditTextbox.Name = "CreditTextbox";
            this.CreditTextbox.Parmida_ActivePlusMultiKeys = false;
            this.CreditTextbox.Size = new System.Drawing.Size(229, 26);
            this.CreditTextbox.TabIndex = 12;
            // 
            // labelControl4
            // 
            this.labelControl4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl4.Location = new System.Drawing.Point(734, 99);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(24, 20);
            this.labelControl4.TabIndex = 8;
            this.labelControl4.Text = "شارژ";
            // 
            // SmsNumberTextbox
            // 
            this.SmsNumberTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SmsNumberTextbox.Location = new System.Drawing.Point(499, 64);
            this.SmsNumberTextbox.Name = "SmsNumberTextbox";
            this.SmsNumberTextbox.Parmida_ActivePlusMultiKeys = false;
            this.SmsNumberTextbox.Size = new System.Drawing.Size(229, 26);
            this.SmsNumberTextbox.TabIndex = 13;
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl1.Location = new System.Drawing.Point(734, 67);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(46, 20);
            this.labelControl1.TabIndex = 9;
            this.labelControl1.Text = "شماره خط";
            // 
            // labelControl3
            // 
            this.labelControl3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl3.Location = new System.Drawing.Point(734, 226);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(50, 20);
            this.labelControl3.TabIndex = 11;
            this.labelControl3.Text = "متن پیامک";
            // 
            // labelControl2
            // 
            this.labelControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl2.Location = new System.Drawing.Point(420, 67);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(60, 20);
            this.labelControl2.TabIndex = 10;
            this.labelControl2.Text = "شماره همراه";
            // 
            // SendButton
            // 
            this.SendButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SendButton.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("SendButton.ImageOptions.Image")));
            this.SendButton.Location = new System.Drawing.Point(590, 375);
            this.SendButton.Name = "SendButton";
            this.SendButton.Size = new System.Drawing.Size(85, 45);
            this.SendButton.TabIndex = 7;
            this.SendButton.Text = "ارسال";
            // 
            // MessageTextbox
            // 
            this.MessageTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MessageTextbox.Location = new System.Drawing.Point(499, 224);
            this.MessageTextbox.Name = "MessageTextbox";
            this.MessageTextbox.Parmida_ActivePlusMultiKeys = false;
            this.MessageTextbox.Properties.Appearance.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.No;
            this.MessageTextbox.Properties.AppearanceDisabled.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.No;
            this.MessageTextbox.Properties.AppearanceFocused.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.No;
            this.MessageTextbox.Properties.AppearanceReadOnly.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.No;
            this.MessageTextbox.Properties.MaxLength = 500;
            this.MessageTextbox.Size = new System.Drawing.Size(229, 145);
            this.MessageTextbox.TabIndex = 15;
            this.MessageTextbox.EditValueChanged += new System.EventHandler(this.MessageTextbox_EditValueChanged);
            // 
            // labelControl7
            // 
            this.labelControl7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl7.Location = new System.Drawing.Point(734, 163);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(57, 20);
            this.labelControl7.TabIndex = 8;
            this.labelControl7.Text = "تعداد پیامک";
            // 
            // SMSPageTextbox
            // 
            this.SMSPageTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SMSPageTextbox.Location = new System.Drawing.Point(499, 160);
            this.SMSPageTextbox.Name = "SMSPageTextbox";
            this.SMSPageTextbox.Parmida_ActivePlusMultiKeys = false;
            this.SMSPageTextbox.Size = new System.Drawing.Size(229, 26);
            this.SMSPageTextbox.TabIndex = 12;
            // 
            // SendSmsGroupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 504);
            this.Controls.Add(this.groupControl1);
            this.Name = "SendSmsGroupForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "ارسال گروهی پیامک";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PersonGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReciverNumberTextbox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CalcuterTextbx.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CreditTextbox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SmsNumberTextbox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MessageTextbox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SMSPageTextbox.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.GridControl PersonGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton CloseButton;
        private DevExpress.XtraEditors.TextEdit ReciverNumberTextbox;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit CalcuterTextbx;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit CreditTextbox;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit SmsNumberTextbox;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton SendButton;
        private DevExpress.XtraEditors.MemoEdit MessageTextbox;
        private DevExpress.XtraGrid.Columns.GridColumn ID;
        private DevExpress.XtraGrid.Columns.GridColumn FullName;
        private DevExpress.XtraGrid.Columns.GridColumn Mobile1;
        private DevExpress.XtraGrid.Columns.GridColumn SendSMS;
        private DevExpress.XtraEditors.TextEdit SMSPageTextbox;
        private DevExpress.XtraEditors.LabelControl labelControl7;
    }
}