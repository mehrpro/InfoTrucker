
namespace InfoTrucker.Infrastructure
{
    partial class SettingForm
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
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule1 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule2 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule3 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule4 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule5 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingForm));
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.progressBar = new DevExpress.XtraEditors.MarqueeProgressBarControl();
            this.cbxServer = new DevExpress.XtraEditors.ComboBoxEdit();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.cbxAuthentication = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnConnecting = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtPassword = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtUser = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.cbxDatabase = new DevExpress.XtraEditors.ComboBoxEdit();
            this.btnRefresh = new DevExpress.XtraEditors.SimpleButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.امکاناتToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnBackup = new System.Windows.Forms.ToolStripMenuItem();
            this.btnRestore = new System.Windows.Forms.ToolStripMenuItem();
            this.btnNewDatabase = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuConnectonNow = new System.Windows.Forms.ToolStripMenuItem();
            this.خروجToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.راهنماToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.btnHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.dx = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.progressBar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxServer.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxAuthentication.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUser.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxDatabase.Properties)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dx)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl6
            // 
            this.labelControl6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl6.Appearance.Font = new System.Drawing.Font("B Yekan", 14F);
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(126, 35);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(153, 29);
            this.labelControl6.TabIndex = 18;
            this.labelControl6.Text = "اتصال به بانک اطلاعاتی";
            // 
            // progressBar
            // 
            this.progressBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.progressBar.EditValue = 0;
            this.progressBar.Location = new System.Drawing.Point(0, 24);
            this.progressBar.Name = "progressBar";
            this.progressBar.Parmida_ActivePlusMultiKeys = false;
            this.progressBar.Properties.Appearance.BackColor = System.Drawing.Color.Black;
            this.progressBar.Properties.Appearance.ForeColor = System.Drawing.Color.Transparent;
            this.progressBar.Size = new System.Drawing.Size(406, 5);
            this.progressBar.TabIndex = 32;
            // 
            // cbxServer
            // 
            this.cbxServer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxServer.EditValue = "02MOHAMMADI-F\\TEW_SQLEXPRESS";
            this.cbxServer.Location = new System.Drawing.Point(62, 74);
            this.cbxServer.Name = "cbxServer";
            this.cbxServer.Parmida_ActivePlusMultiKeys = false;
            this.cbxServer.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.cbxServer.Properties.Appearance.Options.UseFont = true;
            this.cbxServer.Properties.Appearance.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.No;
            this.cbxServer.Properties.AppearanceDisabled.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.cbxServer.Properties.AppearanceDisabled.Options.UseFont = true;
            this.cbxServer.Properties.AppearanceDisabled.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.No;
            this.cbxServer.Properties.AppearanceDropDown.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.cbxServer.Properties.AppearanceDropDown.Options.UseFont = true;
            this.cbxServer.Properties.AppearanceFocused.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.cbxServer.Properties.AppearanceFocused.Options.UseFont = true;
            this.cbxServer.Properties.AppearanceFocused.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.No;
            this.cbxServer.Properties.AppearanceItemDisabled.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.cbxServer.Properties.AppearanceItemDisabled.Options.UseFont = true;
            this.cbxServer.Properties.AppearanceItemHighlight.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.cbxServer.Properties.AppearanceItemHighlight.Options.UseFont = true;
            this.cbxServer.Properties.AppearanceItemSelected.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.cbxServer.Properties.AppearanceItemSelected.Options.UseFont = true;
            this.cbxServer.Properties.AppearanceReadOnly.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.cbxServer.Properties.AppearanceReadOnly.Options.UseFont = true;
            this.cbxServer.Properties.AppearanceReadOnly.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.No;
            serializableAppearanceObject1.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.No;
            serializableAppearanceObject2.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.No;
            serializableAppearanceObject3.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.No;
            serializableAppearanceObject4.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.No;
            this.cbxServer.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.SpinDown, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.cbxServer.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cbxServer.Size = new System.Drawing.Size(243, 22);
            this.cbxServer.TabIndex = 21;
            conditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule1.ErrorText = "This value is not valid";
            this.dx.SetValidationRule(this.cbxServer, conditionValidationRule1);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(34, 263);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 31;
            this.btnSave.Text = "ذخیره";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cbxAuthentication
            // 
            this.cbxAuthentication.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxAuthentication.EditValue = "SQL Server Authentication";
            this.cbxAuthentication.Location = new System.Drawing.Point(34, 106);
            this.cbxAuthentication.Name = "cbxAuthentication";
            this.cbxAuthentication.Parmida_ActivePlusMultiKeys = false;
            this.cbxAuthentication.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.cbxAuthentication.Properties.Appearance.Options.UseFont = true;
            this.cbxAuthentication.Properties.Appearance.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.No;
            this.cbxAuthentication.Properties.AppearanceDisabled.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.cbxAuthentication.Properties.AppearanceDisabled.Options.UseFont = true;
            this.cbxAuthentication.Properties.AppearanceDisabled.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.No;
            this.cbxAuthentication.Properties.AppearanceDropDown.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.cbxAuthentication.Properties.AppearanceDropDown.Options.UseFont = true;
            this.cbxAuthentication.Properties.AppearanceFocused.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.cbxAuthentication.Properties.AppearanceFocused.Options.UseFont = true;
            this.cbxAuthentication.Properties.AppearanceFocused.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.No;
            this.cbxAuthentication.Properties.AppearanceItemDisabled.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.cbxAuthentication.Properties.AppearanceItemDisabled.Options.UseFont = true;
            this.cbxAuthentication.Properties.AppearanceItemHighlight.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.cbxAuthentication.Properties.AppearanceItemHighlight.Options.UseFont = true;
            this.cbxAuthentication.Properties.AppearanceItemSelected.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.cbxAuthentication.Properties.AppearanceItemSelected.Options.UseFont = true;
            this.cbxAuthentication.Properties.AppearanceReadOnly.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.cbxAuthentication.Properties.AppearanceReadOnly.Options.UseFont = true;
            this.cbxAuthentication.Properties.AppearanceReadOnly.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.No;
            this.cbxAuthentication.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbxAuthentication.Properties.DropDownRows = 3;
            this.cbxAuthentication.Properties.Items.AddRange(new object[] {
            "Windows Authentication",
            "SQL Server Authentication"});
            this.cbxAuthentication.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cbxAuthentication.Size = new System.Drawing.Size(271, 22);
            this.cbxAuthentication.TabIndex = 22;
            conditionValidationRule2.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule2.ErrorText = "This value is not valid";
            this.dx.SetValidationRule(this.cbxAuthentication, conditionValidationRule2);
            this.cbxAuthentication.SelectedIndexChanged += new System.EventHandler(this.cbxAuthentication_SelectedIndexChanged);
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl1.Location = new System.Drawing.Point(311, 77);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(27, 20);
            this.labelControl1.TabIndex = 19;
            this.labelControl1.Text = "سرور";
            // 
            // btnConnecting
            // 
            this.btnConnecting.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConnecting.Location = new System.Drawing.Point(35, 198);
            this.btnConnecting.Name = "btnConnecting";
            this.btnConnecting.Size = new System.Drawing.Size(74, 23);
            this.btnConnecting.TabIndex = 30;
            this.btnConnecting.Text = "اتصال";
            this.btnConnecting.Click += new System.EventHandler(this.btnConnecting_Click);
            // 
            // labelControl5
            // 
            this.labelControl5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl5.Location = new System.Drawing.Point(311, 109);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(56, 20);
            this.labelControl5.TabIndex = 20;
            this.labelControl5.Text = "اعتبارسنجی";
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPassword.Location = new System.Drawing.Point(34, 170);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Parmida_ActivePlusMultiKeys = false;
            this.txtPassword.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.txtPassword.Properties.Appearance.Options.UseFont = true;
            this.txtPassword.Properties.PasswordChar = '*';
            this.txtPassword.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtPassword.Size = new System.Drawing.Size(271, 22);
            this.txtPassword.TabIndex = 28;
            conditionValidationRule3.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule3.ErrorText = "This value is not valid";
            this.dx.SetValidationRule(this.txtPassword, conditionValidationRule3);
            // 
            // labelControl2
            // 
            this.labelControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl2.Location = new System.Drawing.Point(311, 234);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(63, 20);
            this.labelControl2.TabIndex = 23;
            this.labelControl2.Text = "بانک اطلاعاتی";
            // 
            // labelControl3
            // 
            this.labelControl3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl3.Location = new System.Drawing.Point(311, 141);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(49, 20);
            this.labelControl3.TabIndex = 25;
            this.labelControl3.Text = "نام کاربری";
            // 
            // txtUser
            // 
            this.txtUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUser.EditValue = "sa";
            this.txtUser.Location = new System.Drawing.Point(34, 138);
            this.txtUser.Name = "txtUser";
            this.txtUser.Parmida_ActivePlusMultiKeys = false;
            this.txtUser.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.txtUser.Properties.Appearance.Options.UseFont = true;
            this.txtUser.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtUser.Size = new System.Drawing.Size(271, 22);
            this.txtUser.TabIndex = 26;
            conditionValidationRule4.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule4.ErrorText = "This value is not valid";
            this.dx.SetValidationRule(this.txtUser, conditionValidationRule4);
            // 
            // labelControl4
            // 
            this.labelControl4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl4.Location = new System.Drawing.Point(311, 173);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(39, 20);
            this.labelControl4.TabIndex = 27;
            this.labelControl4.Text = "رمزعبور";
            // 
            // cbxDatabase
            // 
            this.cbxDatabase.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxDatabase.EditValue = "PMWORKDB";
            this.cbxDatabase.Enabled = false;
            this.cbxDatabase.Location = new System.Drawing.Point(34, 231);
            this.cbxDatabase.Name = "cbxDatabase";
            this.cbxDatabase.Parmida_ActivePlusMultiKeys = false;
            this.cbxDatabase.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.cbxDatabase.Properties.Appearance.Options.UseFont = true;
            this.cbxDatabase.Properties.Appearance.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.No;
            this.cbxDatabase.Properties.AppearanceDisabled.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.cbxDatabase.Properties.AppearanceDisabled.Options.UseFont = true;
            this.cbxDatabase.Properties.AppearanceDisabled.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.No;
            this.cbxDatabase.Properties.AppearanceDropDown.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.cbxDatabase.Properties.AppearanceDropDown.Options.UseFont = true;
            this.cbxDatabase.Properties.AppearanceFocused.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.cbxDatabase.Properties.AppearanceFocused.Options.UseFont = true;
            this.cbxDatabase.Properties.AppearanceFocused.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.No;
            this.cbxDatabase.Properties.AppearanceItemDisabled.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.cbxDatabase.Properties.AppearanceItemDisabled.Options.UseFont = true;
            this.cbxDatabase.Properties.AppearanceItemHighlight.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.cbxDatabase.Properties.AppearanceItemHighlight.Options.UseFont = true;
            this.cbxDatabase.Properties.AppearanceItemSelected.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.cbxDatabase.Properties.AppearanceItemSelected.Options.UseFont = true;
            this.cbxDatabase.Properties.AppearanceReadOnly.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.cbxDatabase.Properties.AppearanceReadOnly.Options.UseFont = true;
            this.cbxDatabase.Properties.AppearanceReadOnly.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.No;
            this.cbxDatabase.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbxDatabase.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbxDatabase.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cbxDatabase.Size = new System.Drawing.Size(271, 22);
            this.cbxDatabase.TabIndex = 24;
            conditionValidationRule5.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule5.ErrorText = "This value is not valid";
            this.dx.SetValidationRule(this.cbxDatabase, conditionValidationRule5);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.ImageOptions.Image")));
            this.btnRefresh.Location = new System.Drawing.Point(34, 74);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(25, 23);
            this.btnRefresh.TabIndex = 29;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.امکاناتToolStripMenuItem,
            this.راهنماToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(406, 24);
            this.menuStrip1.TabIndex = 33;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // امکاناتToolStripMenuItem
            // 
            this.امکاناتToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnBackup,
            this.btnRestore,
            this.btnNewDatabase,
            this.mnuConnectonNow,
            this.خروجToolStripMenuItem});
            this.امکاناتToolStripMenuItem.Name = "امکاناتToolStripMenuItem";
            this.امکاناتToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.امکاناتToolStripMenuItem.Text = "امکانات";
            // 
            // btnBackup
            // 
            this.btnBackup.Name = "btnBackup";
            this.btnBackup.Size = new System.Drawing.Size(209, 22);
            this.btnBackup.Text = "پشتیبان گیری بانک اطلاعاتی";
            this.btnBackup.Click += new System.EventHandler(this.btnBackup_Click);
            // 
            // btnRestore
            // 
            this.btnRestore.Enabled = false;
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Size = new System.Drawing.Size(209, 22);
            this.btnRestore.Text = "بازگردانی بانک اطلاعاتی";
            // 
            // btnNewDatabase
            // 
            this.btnNewDatabase.Name = "btnNewDatabase";
            this.btnNewDatabase.Size = new System.Drawing.Size(209, 22);
            this.btnNewDatabase.Text = "بانک اطلاعاتی جدید";
            this.btnNewDatabase.Click += new System.EventHandler(this.btnNewDatabase_Click);
            // 
            // mnuConnectonNow
            // 
            this.mnuConnectonNow.Name = "mnuConnectonNow";
            this.mnuConnectonNow.Size = new System.Drawing.Size(209, 22);
            this.mnuConnectonNow.Text = "ارتباط فعلی";
            this.mnuConnectonNow.Click += new System.EventHandler(this.mnuConnectonNow_Click);
            // 
            // خروجToolStripMenuItem
            // 
            this.خروجToolStripMenuItem.Name = "خروجToolStripMenuItem";
            this.خروجToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.خروجToolStripMenuItem.Text = "خروج";
            // 
            // راهنماToolStripMenuItem
            // 
            this.راهنماToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAbout,
            this.btnHelp});
            this.راهنماToolStripMenuItem.Name = "راهنماToolStripMenuItem";
            this.راهنماToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.راهنماToolStripMenuItem.Text = "راهنما";
            // 
            // btnAbout
            // 
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(144, 22);
            this.btnAbout.Text = "درباره نرم افزار";
            // 
            // btnHelp
            // 
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(144, 22);
            this.btnHelp.Text = "راهنما";
            // 
            // SettingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 300);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.cbxServer);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cbxAuthentication);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.btnConnecting);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.cbxDatabase);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "SettingForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تنظیمات اتصال با بانک اطلاعاتی";
            this.Load += new System.EventHandler(this.SettingForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.progressBar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxServer.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxAuthentication.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUser.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxDatabase.Properties)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dx)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.MarqueeProgressBarControl progressBar;
        private DevExpress.XtraEditors.ComboBoxEdit cbxServer;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.ComboBoxEdit cbxAuthentication;
        private DevExpress.XtraEditors.SimpleButton btnRefresh;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnConnecting;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit txtPassword;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtUser;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.ComboBoxEdit cbxDatabase;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem امکاناتToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnBackup;
        private System.Windows.Forms.ToolStripMenuItem btnRestore;
        private System.Windows.Forms.ToolStripMenuItem btnNewDatabase;
        private System.Windows.Forms.ToolStripMenuItem mnuConnectonNow;
        private System.Windows.Forms.ToolStripMenuItem خروجToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem راهنماToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnAbout;
        private System.Windows.Forms.ToolStripMenuItem btnHelp;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider dx;
    }
}