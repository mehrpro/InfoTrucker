
namespace InfoTrucker.Infrastructure
{
    partial class UserForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserForm));
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.cbxEditor = new DevExpress.XtraEditors.ComboBoxEdit();
            this.chkLimetedCompany = new DevExpress.XtraEditors.CheckEdit();
            this.chkEnabled = new DevExpress.XtraEditors.CheckEdit();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtFullname = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtPassword = new DevExpress.XtraEditors.TextEdit();
            this.txtUsername = new DevExpress.XtraEditors.TextEdit();
            this.cbxCompany = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.dgvUsersList = new DevExpress.XtraGrid.GridControl();
            this.gvUsersList = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.SelectedColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnSelectedRow = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.IDColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.UserNameColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.EnableColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.FullNameColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CompanyColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LimetedCompanyColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.EditorColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbxEditor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkLimetedCompany.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkEnabled.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFullname.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUsername.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxCompany.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsersList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvUsersList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSelectedRow)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.cbxEditor);
            this.panelControl1.Controls.Add(this.chkLimetedCompany);
            this.panelControl1.Controls.Add(this.chkEnabled);
            this.panelControl1.Controls.Add(this.btnClose);
            this.panelControl1.Controls.Add(this.btnSave);
            this.panelControl1.Controls.Add(this.labelControl5);
            this.panelControl1.Controls.Add(this.labelControl4);
            this.panelControl1.Controls.Add(this.labelControl3);
            this.panelControl1.Controls.Add(this.txtFullname);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.txtPassword);
            this.panelControl1.Controls.Add(this.txtUsername);
            this.panelControl1.Controls.Add(this.cbxCompany);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(841, 131);
            this.panelControl1.TabIndex = 1;
            // 
            // cbxEditor
            // 
            this.cbxEditor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxEditor.Location = new System.Drawing.Point(596, 87);
            this.cbxEditor.Name = "cbxEditor";
            this.cbxEditor.Parmida_ActivePlusMultiKeys = false;
            this.cbxEditor.Properties.AllowDropDownWhenReadOnly = DevExpress.Utils.DefaultBoolean.True;
            this.cbxEditor.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbxEditor.Properties.Items.AddRange(new object[] {
            "Admin",
            "Creator",
            "Editor",
            "Reader"});
            this.cbxEditor.Properties.Sorted = true;
            this.cbxEditor.Size = new System.Drawing.Size(152, 26);
            this.cbxEditor.TabIndex = 11;
            // 
            // chkLimetedCompany
            // 
            this.chkLimetedCompany.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkLimetedCompany.EditValue = true;
            this.chkLimetedCompany.Location = new System.Drawing.Point(465, 57);
            this.chkLimetedCompany.Name = "chkLimetedCompany";
            this.chkLimetedCompany.Parmida_ActivePlusMultiKeys = false;
            this.chkLimetedCompany.Properties.Caption = "محدود به شرکت";
            this.chkLimetedCompany.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.chkLimetedCompany.Size = new System.Drawing.Size(106, 24);
            this.chkLimetedCompany.TabIndex = 4;
            // 
            // chkEnabled
            // 
            this.chkEnabled.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkEnabled.EditValue = true;
            this.chkEnabled.Location = new System.Drawing.Point(465, 86);
            this.chkEnabled.Name = "chkEnabled";
            this.chkEnabled.Parmida_ActivePlusMultiKeys = false;
            this.chkEnabled.Properties.Caption = "فعال";
            this.chkEnabled.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.chkEnabled.Size = new System.Drawing.Size(55, 24);
            this.chkEnabled.TabIndex = 4;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.ImageOptions.Image")));
            this.btnClose.Location = new System.Drawing.Point(98, 81);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(80, 30);
            this.btnClose.TabIndex = 10;
            this.btnClose.Text = "بستن";
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.ImageOptions.Image")));
            this.btnSave.Location = new System.Drawing.Point(184, 81);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(80, 30);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "ذخیره";
            // 
            // labelControl5
            // 
            this.labelControl5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl5.Location = new System.Drawing.Point(754, 91);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(52, 20);
            this.labelControl5.TabIndex = 7;
            this.labelControl5.Text = "نوع کاربری";
            // 
            // labelControl4
            // 
            this.labelControl4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl4.Location = new System.Drawing.Point(237, 26);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(31, 20);
            this.labelControl4.TabIndex = 7;
            this.labelControl4.Text = "شرکت";
            this.labelControl4.Visible = false;
            // 
            // labelControl3
            // 
            this.labelControl3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl3.Location = new System.Drawing.Point(487, 26);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(86, 20);
            this.labelControl3.TabIndex = 5;
            this.labelControl3.Text = "نام و نام خانوادگی";
            // 
            // txtFullname
            // 
            this.txtFullname.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFullname.Location = new System.Drawing.Point(291, 23);
            this.txtFullname.Name = "txtFullname";
            this.txtFullname.Parmida_ActivePlusMultiKeys = false;
            this.txtFullname.Size = new System.Drawing.Size(190, 26);
            this.txtFullname.TabIndex = 6;
            // 
            // labelControl2
            // 
            this.labelControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl2.Location = new System.Drawing.Point(754, 58);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(39, 20);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "گذرواژه";
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl1.Location = new System.Drawing.Point(754, 26);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(49, 20);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "نام کاربری";
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPassword.Location = new System.Drawing.Point(596, 55);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Parmida_ActivePlusMultiKeys = false;
            this.txtPassword.Size = new System.Drawing.Size(152, 26);
            this.txtPassword.TabIndex = 3;
            // 
            // txtUsername
            // 
            this.txtUsername.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUsername.Location = new System.Drawing.Point(596, 23);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Parmida_ActivePlusMultiKeys = false;
            this.txtUsername.Size = new System.Drawing.Size(152, 26);
            this.txtUsername.TabIndex = 1;
            // 
            // cbxCompany
            // 
            this.cbxCompany.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxCompany.Location = new System.Drawing.Point(41, 23);
            this.cbxCompany.Name = "cbxCompany";
            this.cbxCompany.Parmida_ActivePlusMultiKeys = false;
            this.cbxCompany.Properties.Appearance.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.No;
            this.cbxCompany.Properties.AppearanceDisabled.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.No;
            this.cbxCompany.Properties.AppearanceFocused.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.No;
            this.cbxCompany.Properties.AppearanceReadOnly.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.No;
            this.cbxCompany.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbxCompany.Properties.NullText = "";
            this.cbxCompany.Properties.PopupView = this.searchLookUpEdit1View;
            this.cbxCompany.Size = new System.Drawing.Size(190, 26);
            this.cbxCompany.TabIndex = 8;
            this.cbxCompany.Visible = false;
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.dgvUsersList);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(0, 131);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(841, 319);
            this.panelControl2.TabIndex = 2;
            // 
            // dgvUsersList
            // 
            this.dgvUsersList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvUsersList.Location = new System.Drawing.Point(2, 2);
            this.dgvUsersList.MainView = this.gvUsersList;
            this.dgvUsersList.Name = "dgvUsersList";
            this.dgvUsersList.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btnSelectedRow});
            this.dgvUsersList.Size = new System.Drawing.Size(837, 315);
            this.dgvUsersList.TabIndex = 0;
            this.dgvUsersList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvUsersList});
            // 
            // gvUsersList
            // 
            this.gvUsersList.Appearance.ColumnFilterButton.Options.UseTextOptions = true;
            this.gvUsersList.Appearance.ColumnFilterButton.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvUsersList.Appearance.ColumnFilterButtonActive.Options.UseTextOptions = true;
            this.gvUsersList.Appearance.ColumnFilterButtonActive.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvUsersList.Appearance.CustomizationFormHint.Options.UseTextOptions = true;
            this.gvUsersList.Appearance.CustomizationFormHint.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvUsersList.Appearance.DetailTip.Options.UseTextOptions = true;
            this.gvUsersList.Appearance.DetailTip.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvUsersList.Appearance.Empty.Options.UseTextOptions = true;
            this.gvUsersList.Appearance.Empty.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvUsersList.Appearance.EvenRow.Options.UseTextOptions = true;
            this.gvUsersList.Appearance.EvenRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvUsersList.Appearance.FilterCloseButton.Options.UseTextOptions = true;
            this.gvUsersList.Appearance.FilterCloseButton.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvUsersList.Appearance.FilterPanel.Options.UseTextOptions = true;
            this.gvUsersList.Appearance.FilterPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvUsersList.Appearance.FixedLine.Options.UseTextOptions = true;
            this.gvUsersList.Appearance.FixedLine.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvUsersList.Appearance.FocusedCell.Options.UseTextOptions = true;
            this.gvUsersList.Appearance.FocusedCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvUsersList.Appearance.FocusedRow.Options.UseTextOptions = true;
            this.gvUsersList.Appearance.FocusedRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvUsersList.Appearance.FooterPanel.Options.UseTextOptions = true;
            this.gvUsersList.Appearance.FooterPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvUsersList.Appearance.GroupButton.Options.UseTextOptions = true;
            this.gvUsersList.Appearance.GroupButton.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvUsersList.Appearance.GroupFooter.Options.UseTextOptions = true;
            this.gvUsersList.Appearance.GroupFooter.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvUsersList.Appearance.GroupPanel.Options.UseTextOptions = true;
            this.gvUsersList.Appearance.GroupPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvUsersList.Appearance.GroupRow.Options.UseTextOptions = true;
            this.gvUsersList.Appearance.GroupRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvUsersList.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gvUsersList.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvUsersList.Appearance.HideSelectionRow.Options.UseTextOptions = true;
            this.gvUsersList.Appearance.HideSelectionRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvUsersList.Appearance.HorzLine.Options.UseTextOptions = true;
            this.gvUsersList.Appearance.HorzLine.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvUsersList.Appearance.OddRow.Options.UseTextOptions = true;
            this.gvUsersList.Appearance.OddRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvUsersList.Appearance.Preview.Options.UseTextOptions = true;
            this.gvUsersList.Appearance.Preview.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvUsersList.Appearance.Row.Options.UseTextOptions = true;
            this.gvUsersList.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvUsersList.Appearance.RowSeparator.Options.UseTextOptions = true;
            this.gvUsersList.Appearance.RowSeparator.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvUsersList.Appearance.SelectedRow.Options.UseTextOptions = true;
            this.gvUsersList.Appearance.SelectedRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvUsersList.Appearance.TopNewRow.Options.UseTextOptions = true;
            this.gvUsersList.Appearance.TopNewRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvUsersList.Appearance.VertLine.Options.UseTextOptions = true;
            this.gvUsersList.Appearance.VertLine.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvUsersList.Appearance.ViewCaption.Options.UseTextOptions = true;
            this.gvUsersList.Appearance.ViewCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvUsersList.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.SelectedColumn,
            this.IDColumn,
            this.UserNameColumn,
            this.EnableColumn,
            this.FullNameColumn,
            this.CompanyColumn,
            this.LimetedCompanyColumn,
            this.EditorColumn});
            this.gvUsersList.GridControl = this.dgvUsersList;
            this.gvUsersList.Name = "gvUsersList";
            this.gvUsersList.OptionsBehavior.ReadOnly = true;
            this.gvUsersList.OptionsView.ShowGroupPanel = false;
            // 
            // SelectedColumn
            // 
            this.SelectedColumn.ColumnEdit = this.btnSelectedRow;
            this.SelectedColumn.MaxWidth = 30;
            this.SelectedColumn.MinWidth = 30;
            this.SelectedColumn.Name = "SelectedColumn";
            this.SelectedColumn.Visible = true;
            this.SelectedColumn.VisibleIndex = 0;
            this.SelectedColumn.Width = 30;
            // 
            // btnSelectedRow
            // 
            this.btnSelectedRow.AutoHeight = false;
            editorButtonImageOptions1.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions1.Image")));
            serializableAppearanceObject1.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.No;
            serializableAppearanceObject2.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.No;
            serializableAppearanceObject3.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.No;
            serializableAppearanceObject4.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.No;
            this.btnSelectedRow.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.btnSelectedRow.Name = "btnSelectedRow";
            this.btnSelectedRow.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // IDColumn
            // 
            this.IDColumn.Caption = "شناسه";
            this.IDColumn.FieldName = "UserId";
            this.IDColumn.MaxWidth = 80;
            this.IDColumn.MinWidth = 80;
            this.IDColumn.Name = "IDColumn";
            this.IDColumn.Visible = true;
            this.IDColumn.VisibleIndex = 1;
            this.IDColumn.Width = 80;
            // 
            // UserNameColumn
            // 
            this.UserNameColumn.Caption = "نام کاربری";
            this.UserNameColumn.FieldName = "UserName";
            this.UserNameColumn.Name = "UserNameColumn";
            this.UserNameColumn.Visible = true;
            this.UserNameColumn.VisibleIndex = 2;
            this.UserNameColumn.Width = 148;
            // 
            // EnableColumn
            // 
            this.EnableColumn.Caption = "وضعیت فعالیت";
            this.EnableColumn.FieldName = "Enabled";
            this.EnableColumn.MaxWidth = 90;
            this.EnableColumn.MinWidth = 90;
            this.EnableColumn.Name = "EnableColumn";
            this.EnableColumn.Visible = true;
            this.EnableColumn.VisibleIndex = 5;
            this.EnableColumn.Width = 90;
            // 
            // FullNameColumn
            // 
            this.FullNameColumn.Caption = "نام و نام خانوادگی";
            this.FullNameColumn.FieldName = "FullName";
            this.FullNameColumn.Name = "FullNameColumn";
            this.FullNameColumn.Visible = true;
            this.FullNameColumn.VisibleIndex = 3;
            this.FullNameColumn.Width = 178;
            // 
            // CompanyColumn
            // 
            this.CompanyColumn.Caption = "شرکت";
            this.CompanyColumn.FieldName = "Company.CompanyTitle";
            this.CompanyColumn.Name = "CompanyColumn";
            this.CompanyColumn.Visible = true;
            this.CompanyColumn.VisibleIndex = 4;
            this.CompanyColumn.Width = 182;
            // 
            // LimetedCompanyColumn
            // 
            this.LimetedCompanyColumn.Caption = "محدود";
            this.LimetedCompanyColumn.FieldName = "LimetedCompany";
            this.LimetedCompanyColumn.MaxWidth = 40;
            this.LimetedCompanyColumn.MinWidth = 40;
            this.LimetedCompanyColumn.Name = "LimetedCompanyColumn";
            this.LimetedCompanyColumn.Visible = true;
            this.LimetedCompanyColumn.VisibleIndex = 6;
            this.LimetedCompanyColumn.Width = 40;
            // 
            // EditorColumn
            // 
            this.EditorColumn.Caption = "نوع کاربری";
            this.EditorColumn.FieldName = "Editor";
            this.EditorColumn.MaxWidth = 60;
            this.EditorColumn.MinWidth = 60;
            this.EditorColumn.Name = "EditorColumn";
            this.EditorColumn.Visible = true;
            this.EditorColumn.VisibleIndex = 7;
            this.EditorColumn.Width = 60;
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 450);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "UserForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "مدیریت کاربران";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbxEditor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkLimetedCompany.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkEnabled.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFullname.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUsername.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxCompany.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsersList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvUsersList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSelectedRow)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.ComboBoxEdit cbxEditor;
        private DevExpress.XtraEditors.CheckEdit chkLimetedCompany;
        private DevExpress.XtraEditors.CheckEdit chkEnabled;
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtFullname;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtPassword;
        private DevExpress.XtraEditors.TextEdit txtUsername;
        private DevExpress.XtraEditors.SearchLookUpEdit cbxCompany;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraGrid.GridControl dgvUsersList;
        private DevExpress.XtraGrid.Views.Grid.GridView gvUsersList;
        private DevExpress.XtraGrid.Columns.GridColumn SelectedColumn;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnSelectedRow;
        private DevExpress.XtraGrid.Columns.GridColumn IDColumn;
        private DevExpress.XtraGrid.Columns.GridColumn UserNameColumn;
        private DevExpress.XtraGrid.Columns.GridColumn EnableColumn;
        private DevExpress.XtraGrid.Columns.GridColumn FullNameColumn;
        private DevExpress.XtraGrid.Columns.GridColumn CompanyColumn;
        private DevExpress.XtraGrid.Columns.GridColumn LimetedCompanyColumn;
        private DevExpress.XtraGrid.Columns.GridColumn EditorColumn;
    }
}