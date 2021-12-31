
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
            this.RefreshButton = new DevExpress.XtraEditors.SimpleButton();
            this.PersonGridControl = new DevExpress.XtraGrid.GridControl();
            this.PersonGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.FullName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Mobile1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SendSMS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CloseButton = new DevExpress.XtraEditors.SimpleButton();
            this.SMSPageTextbox = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.ReciverNumberTextbox = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.CalcuterTextbx = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.CreditTextbox = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.SmsNumberTextbox = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.SendButton = new DevExpress.XtraEditors.SimpleButton();
            this.MessageTextbox = new DevExpress.XtraEditors.MemoEdit();
            this.memoEdit1 = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PersonGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PersonGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SMSPageTextbox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReciverNumberTextbox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CalcuterTextbx.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CreditTextbox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SmsNumberTextbox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MessageTextbox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.CaptionImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("groupControl1.CaptionImageOptions.Image")));
            this.groupControl1.Controls.Add(this.RefreshButton);
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
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.SendButton);
            this.groupControl1.Controls.Add(this.MessageTextbox);
            this.groupControl1.Controls.Add(this.memoEdit1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1110, 502);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "ارسال پیامک گروهی";
            // 
            // RefreshButton
            // 
            this.RefreshButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RefreshButton.Appearance.Options.UseTextOptions = true;
            this.RefreshButton.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.RefreshButton.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("RefreshButton.ImageOptions.Image")));
            this.RefreshButton.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.RefreshButton.Location = new System.Drawing.Point(790, 96);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(26, 26);
            this.RefreshButton.TabIndex = 4;
            this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // PersonGridControl
            // 
            this.PersonGridControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PersonGridControl.Location = new System.Drawing.Point(12, 214);
            this.PersonGridControl.MainView = this.PersonGridView;
            this.PersonGridControl.Name = "PersonGridControl";
            this.PersonGridControl.Size = new System.Drawing.Size(1086, 276);
            this.PersonGridControl.TabIndex = 17;
            this.PersonGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.PersonGridView});
            // 
            // PersonGridView
            // 
            this.PersonGridView.Appearance.ColumnFilterButton.Options.UseTextOptions = true;
            this.PersonGridView.Appearance.ColumnFilterButton.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.PersonGridView.Appearance.ColumnFilterButtonActive.Options.UseTextOptions = true;
            this.PersonGridView.Appearance.ColumnFilterButtonActive.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.PersonGridView.Appearance.CustomizationFormHint.Options.UseTextOptions = true;
            this.PersonGridView.Appearance.CustomizationFormHint.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.PersonGridView.Appearance.DetailTip.Options.UseTextOptions = true;
            this.PersonGridView.Appearance.DetailTip.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.PersonGridView.Appearance.Empty.Options.UseTextOptions = true;
            this.PersonGridView.Appearance.Empty.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.PersonGridView.Appearance.EvenRow.Options.UseTextOptions = true;
            this.PersonGridView.Appearance.EvenRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.PersonGridView.Appearance.FilterCloseButton.Options.UseTextOptions = true;
            this.PersonGridView.Appearance.FilterCloseButton.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.PersonGridView.Appearance.FilterPanel.Options.UseTextOptions = true;
            this.PersonGridView.Appearance.FilterPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.PersonGridView.Appearance.FixedLine.Options.UseTextOptions = true;
            this.PersonGridView.Appearance.FixedLine.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.PersonGridView.Appearance.FocusedCell.Options.UseTextOptions = true;
            this.PersonGridView.Appearance.FocusedCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.PersonGridView.Appearance.FocusedRow.Options.UseTextOptions = true;
            this.PersonGridView.Appearance.FocusedRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.PersonGridView.Appearance.FooterPanel.Options.UseTextOptions = true;
            this.PersonGridView.Appearance.FooterPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.PersonGridView.Appearance.GroupButton.Options.UseTextOptions = true;
            this.PersonGridView.Appearance.GroupButton.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.PersonGridView.Appearance.GroupFooter.Options.UseTextOptions = true;
            this.PersonGridView.Appearance.GroupFooter.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.PersonGridView.Appearance.GroupPanel.Options.UseTextOptions = true;
            this.PersonGridView.Appearance.GroupPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.PersonGridView.Appearance.GroupRow.Options.UseTextOptions = true;
            this.PersonGridView.Appearance.GroupRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.PersonGridView.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.PersonGridView.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.PersonGridView.Appearance.HideSelectionRow.Options.UseTextOptions = true;
            this.PersonGridView.Appearance.HideSelectionRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.PersonGridView.Appearance.HorzLine.Options.UseTextOptions = true;
            this.PersonGridView.Appearance.HorzLine.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.PersonGridView.Appearance.OddRow.Options.UseTextOptions = true;
            this.PersonGridView.Appearance.OddRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.PersonGridView.Appearance.Preview.Options.UseTextOptions = true;
            this.PersonGridView.Appearance.Preview.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.PersonGridView.Appearance.Row.Options.UseTextOptions = true;
            this.PersonGridView.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.PersonGridView.Appearance.RowSeparator.Options.UseTextOptions = true;
            this.PersonGridView.Appearance.RowSeparator.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.PersonGridView.Appearance.SelectedRow.Options.UseTextOptions = true;
            this.PersonGridView.Appearance.SelectedRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.PersonGridView.Appearance.TopNewRow.Options.UseTextOptions = true;
            this.PersonGridView.Appearance.TopNewRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.PersonGridView.Appearance.VertLine.Options.UseTextOptions = true;
            this.PersonGridView.Appearance.VertLine.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.PersonGridView.Appearance.ViewCaption.Options.UseTextOptions = true;
            this.PersonGridView.Appearance.ViewCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.PersonGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ID,
            this.FullName,
            this.Mobile1,
            this.SendSMS});
            this.PersonGridView.GridControl = this.PersonGridControl;
            this.PersonGridView.Name = "PersonGridView";
            this.PersonGridView.OptionsFind.AlwaysVisible = true;
            this.PersonGridView.OptionsView.ShowGroupPanel = false;
            // 
            // ID
            // 
            this.ID.Caption = "ردیف";
            this.ID.FieldName = "ID";
            this.ID.Name = "ID";
            this.ID.OptionsColumn.AllowEdit = false;
            this.ID.Visible = true;
            this.ID.VisibleIndex = 0;
            this.ID.Width = 73;
            // 
            // FullName
            // 
            this.FullName.Caption = "گیرنده";
            this.FullName.FieldName = "FullName";
            this.FullName.Name = "FullName";
            this.FullName.OptionsColumn.AllowEdit = false;
            this.FullName.Visible = true;
            this.FullName.VisibleIndex = 1;
            this.FullName.Width = 209;
            // 
            // Mobile1
            // 
            this.Mobile1.Caption = "موبایل";
            this.Mobile1.FieldName = "Mobile1";
            this.Mobile1.Name = "Mobile1";
            this.Mobile1.OptionsColumn.AllowEdit = false;
            this.Mobile1.Visible = true;
            this.Mobile1.VisibleIndex = 2;
            this.Mobile1.Width = 226;
            // 
            // SendSMS
            // 
            this.SendSMS.Caption = "ارسال";
            this.SendSMS.FieldName = "SendSMS";
            this.SendSMS.Name = "SendSMS";
            this.SendSMS.Visible = true;
            this.SendSMS.VisibleIndex = 3;
            this.SendSMS.Width = 89;
            // 
            // CloseButton
            // 
            this.CloseButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseButton.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("CloseButton.ImageOptions.Image")));
            this.CloseButton.Location = new System.Drawing.Point(160, 163);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(85, 45);
            this.CloseButton.TabIndex = 16;
            this.CloseButton.Text = "بستن";
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // SMSPageTextbox
            // 
            this.SMSPageTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SMSPageTextbox.Location = new System.Drawing.Point(790, 163);
            this.SMSPageTextbox.Name = "SMSPageTextbox";
            this.SMSPageTextbox.Parmida_ActivePlusMultiKeys = false;
            this.SMSPageTextbox.Properties.ReadOnly = true;
            this.SMSPageTextbox.Size = new System.Drawing.Size(229, 26);
            this.SMSPageTextbox.TabIndex = 8;
            // 
            // labelControl7
            // 
            this.labelControl7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl7.Location = new System.Drawing.Point(1025, 166);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(57, 20);
            this.labelControl7.TabIndex = 7;
            this.labelControl7.Text = "تعداد پیامک";
            // 
            // ReciverNumberTextbox
            // 
            this.ReciverNumberTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ReciverNumberTextbox.Location = new System.Drawing.Point(822, 96);
            this.ReciverNumberTextbox.Name = "ReciverNumberTextbox";
            this.ReciverNumberTextbox.Parmida_ActivePlusMultiKeys = false;
            this.ReciverNumberTextbox.Properties.ReadOnly = true;
            this.ReciverNumberTextbox.Size = new System.Drawing.Size(197, 26);
            this.ReciverNumberTextbox.TabIndex = 3;
            // 
            // labelControl6
            // 
            this.labelControl6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl6.Location = new System.Drawing.Point(1025, 99);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(72, 20);
            this.labelControl6.TabIndex = 2;
            this.labelControl6.Text = "تعداد گیرندگان";
            // 
            // CalcuterTextbx
            // 
            this.CalcuterTextbx.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CalcuterTextbx.Location = new System.Drawing.Point(477, 163);
            this.CalcuterTextbx.Name = "CalcuterTextbx";
            this.CalcuterTextbx.Parmida_ActivePlusMultiKeys = false;
            this.CalcuterTextbx.Properties.ReadOnly = true;
            this.CalcuterTextbx.Size = new System.Drawing.Size(229, 26);
            this.CalcuterTextbx.TabIndex = 14;
            // 
            // labelControl5
            // 
            this.labelControl5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl5.Location = new System.Drawing.Point(712, 166);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(66, 20);
            this.labelControl5.TabIndex = 13;
            this.labelControl5.Text = "محاسبه هزینه";
            // 
            // CreditTextbox
            // 
            this.CreditTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CreditTextbox.Location = new System.Drawing.Point(790, 129);
            this.CreditTextbox.Name = "CreditTextbox";
            this.CreditTextbox.Parmida_ActivePlusMultiKeys = false;
            this.CreditTextbox.Properties.ReadOnly = true;
            this.CreditTextbox.Size = new System.Drawing.Size(229, 26);
            this.CreditTextbox.TabIndex = 6;
            // 
            // labelControl4
            // 
            this.labelControl4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl4.Location = new System.Drawing.Point(1025, 132);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(24, 20);
            this.labelControl4.TabIndex = 5;
            this.labelControl4.Text = "شارژ";
            // 
            // SmsNumberTextbox
            // 
            this.SmsNumberTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SmsNumberTextbox.Location = new System.Drawing.Point(790, 64);
            this.SmsNumberTextbox.Name = "SmsNumberTextbox";
            this.SmsNumberTextbox.Parmida_ActivePlusMultiKeys = false;
            this.SmsNumberTextbox.Size = new System.Drawing.Size(229, 26);
            this.SmsNumberTextbox.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl1.Location = new System.Drawing.Point(1025, 67);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(46, 20);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "شماره خط";
            // 
            // labelControl2
            // 
            this.labelControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl2.Location = new System.Drawing.Point(712, 65);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(34, 20);
            this.labelControl2.TabIndex = 9;
            this.labelControl2.Text = "موضوع";
            // 
            // labelControl3
            // 
            this.labelControl3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl3.Location = new System.Drawing.Point(712, 100);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(50, 20);
            this.labelControl3.TabIndex = 11;
            this.labelControl3.Text = "متن پیامک";
            // 
            // SendButton
            // 
            this.SendButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SendButton.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("SendButton.ImageOptions.Image")));
            this.SendButton.Location = new System.Drawing.Point(251, 163);
            this.SendButton.Name = "SendButton";
            this.SendButton.Size = new System.Drawing.Size(85, 45);
            this.SendButton.TabIndex = 15;
            this.SendButton.Text = "ارسال";
            this.SendButton.Click += new System.EventHandler(this.SendButton_Click);
            // 
            // MessageTextbox
            // 
            this.MessageTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MessageTextbox.Location = new System.Drawing.Point(160, 98);
            this.MessageTextbox.Name = "MessageTextbox";
            this.MessageTextbox.Parmida_ActivePlusMultiKeys = false;
            this.MessageTextbox.Properties.Appearance.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.No;
            this.MessageTextbox.Properties.AppearanceDisabled.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.No;
            this.MessageTextbox.Properties.AppearanceFocused.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.No;
            this.MessageTextbox.Properties.AppearanceReadOnly.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.No;
            this.MessageTextbox.Properties.MaxLength = 500;
            this.MessageTextbox.Size = new System.Drawing.Size(546, 59);
            this.MessageTextbox.TabIndex = 12;
            this.MessageTextbox.EditValueChanged += new System.EventHandler(this.MessageTextbox_EditValueChanged);
            // 
            // memoEdit1
            // 
            this.memoEdit1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.memoEdit1.Location = new System.Drawing.Point(160, 63);
            this.memoEdit1.Name = "memoEdit1";
            this.memoEdit1.Parmida_ActivePlusMultiKeys = false;
            this.memoEdit1.Properties.Appearance.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.No;
            this.memoEdit1.Properties.AppearanceDisabled.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.No;
            this.memoEdit1.Properties.AppearanceFocused.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.No;
            this.memoEdit1.Properties.AppearanceReadOnly.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.No;
            this.memoEdit1.Properties.MaxLength = 500;
            this.memoEdit1.Properties.NullValuePrompt = "موضوع جهت آرشیو بندی پیامک های گروهی مورد استفاده قرار می گیرد";
            this.memoEdit1.Properties.NullValuePromptShowForEmptyValue = true;
            this.memoEdit1.Size = new System.Drawing.Size(546, 26);
            this.memoEdit1.TabIndex = 10;
            this.memoEdit1.EditValueChanged += new System.EventHandler(this.MessageTextbox_EditValueChanged);
            // 
            // SendSmsGroupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1110, 502);
            this.Controls.Add(this.groupControl1);
            this.Name = "SendSmsGroupForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "ارسال گروهی پیامک";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PersonGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PersonGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SMSPageTextbox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReciverNumberTextbox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CalcuterTextbx.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CreditTextbox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SmsNumberTextbox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MessageTextbox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoEdit1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.GridControl PersonGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView PersonGridView;
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
        private DevExpress.XtraEditors.SimpleButton SendButton;
        private DevExpress.XtraEditors.MemoEdit MessageTextbox;
        private DevExpress.XtraGrid.Columns.GridColumn ID;
        private DevExpress.XtraGrid.Columns.GridColumn FullName;
        private DevExpress.XtraGrid.Columns.GridColumn Mobile1;
        private DevExpress.XtraGrid.Columns.GridColumn SendSMS;
        private DevExpress.XtraEditors.TextEdit SMSPageTextbox;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.SimpleButton RefreshButton;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit memoEdit1;
    }
}