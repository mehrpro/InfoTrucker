
namespace InfoTrucker.UI.ReportForms
{
    partial class PersonListReportForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PersonListReportForm));
            this.BottonSidePanel = new DevExpress.XtraEditors.SidePanel();
            this.PdfButton = new DevExpress.XtraEditors.SimpleButton();
            this.PrintButton = new DevExpress.XtraEditors.SimpleButton();
            this.ExcelButton = new DevExpress.XtraEditors.SimpleButton();
            this.CloseButton = new DevExpress.XtraEditors.SimpleButton();
            this.TopSidePanel = new DevExpress.XtraEditors.SidePanel();
            this.ReportGridControl = new DevExpress.XtraGrid.GridControl();
            this.ReportGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.RowID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PersonID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.FName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Mobile1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CodeMelei = new DevExpress.XtraGrid.Columns.GridColumn();
            this.BottonSidePanel.SuspendLayout();
            this.TopSidePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ReportGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReportGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // BottonSidePanel
            // 
            this.BottonSidePanel.Controls.Add(this.PdfButton);
            this.BottonSidePanel.Controls.Add(this.PrintButton);
            this.BottonSidePanel.Controls.Add(this.ExcelButton);
            this.BottonSidePanel.Controls.Add(this.CloseButton);
            this.BottonSidePanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BottonSidePanel.Location = new System.Drawing.Point(0, 377);
            this.BottonSidePanel.Name = "BottonSidePanel";
            this.BottonSidePanel.Size = new System.Drawing.Size(800, 73);
            this.BottonSidePanel.TabIndex = 0;
            this.BottonSidePanel.Text = "BottonSidePanel";
            this.BottonSidePanel.Click += new System.EventHandler(this.sidePanel1_Click);
            // 
            // PdfButton
            // 
            this.PdfButton.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("PdfButton.ImageOptions.Image")));
            this.PdfButton.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.PdfButton.Location = new System.Drawing.Point(144, 6);
            this.PdfButton.Name = "PdfButton";
            this.PdfButton.Size = new System.Drawing.Size(60, 60);
            this.PdfButton.TabIndex = 3;
            this.PdfButton.Text = "PDF";
            this.PdfButton.Visible = false;
            // 
            // PrintButton
            // 
            this.PrintButton.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("PrintButton.ImageOptions.Image")));
            this.PrintButton.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.PrintButton.Location = new System.Drawing.Point(78, 6);
            this.PrintButton.Name = "PrintButton";
            this.PrintButton.Size = new System.Drawing.Size(60, 60);
            this.PrintButton.TabIndex = 2;
            this.PrintButton.Text = "چاپ";
            // 
            // ExcelButton
            // 
            this.ExcelButton.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ExcelButton.ImageOptions.Image")));
            this.ExcelButton.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.ExcelButton.Location = new System.Drawing.Point(210, 6);
            this.ExcelButton.Name = "ExcelButton";
            this.ExcelButton.Size = new System.Drawing.Size(60, 60);
            this.ExcelButton.TabIndex = 1;
            this.ExcelButton.Text = "Excel";
            this.ExcelButton.Visible = false;
            // 
            // CloseButton
            // 
            this.CloseButton.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("CloseButton.ImageOptions.Image")));
            this.CloseButton.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.CloseButton.Location = new System.Drawing.Point(12, 6);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(60, 60);
            this.CloseButton.TabIndex = 0;
            this.CloseButton.Text = "بستن";
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // TopSidePanel
            // 
            this.TopSidePanel.Controls.Add(this.ReportGridControl);
            this.TopSidePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TopSidePanel.Location = new System.Drawing.Point(0, 0);
            this.TopSidePanel.Name = "TopSidePanel";
            this.TopSidePanel.Size = new System.Drawing.Size(800, 377);
            this.TopSidePanel.TabIndex = 1;
            this.TopSidePanel.Text = "sidePanel2";
            // 
            // ReportGridControl
            // 
            this.ReportGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ReportGridControl.Location = new System.Drawing.Point(0, 0);
            this.ReportGridControl.MainView = this.ReportGridView;
            this.ReportGridControl.Name = "ReportGridControl";
            this.ReportGridControl.Size = new System.Drawing.Size(800, 377);
            this.ReportGridControl.TabIndex = 0;
            this.ReportGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.ReportGridView});
            // 
            // ReportGridView
            // 
            this.ReportGridView.Appearance.ColumnFilterButton.Options.UseTextOptions = true;
            this.ReportGridView.Appearance.ColumnFilterButton.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ReportGridView.Appearance.ColumnFilterButtonActive.Options.UseTextOptions = true;
            this.ReportGridView.Appearance.ColumnFilterButtonActive.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ReportGridView.Appearance.CustomizationFormHint.Options.UseTextOptions = true;
            this.ReportGridView.Appearance.CustomizationFormHint.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ReportGridView.Appearance.DetailTip.Options.UseTextOptions = true;
            this.ReportGridView.Appearance.DetailTip.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ReportGridView.Appearance.Empty.Options.UseTextOptions = true;
            this.ReportGridView.Appearance.Empty.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ReportGridView.Appearance.EvenRow.Options.UseTextOptions = true;
            this.ReportGridView.Appearance.EvenRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ReportGridView.Appearance.FilterCloseButton.Options.UseTextOptions = true;
            this.ReportGridView.Appearance.FilterCloseButton.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ReportGridView.Appearance.FilterPanel.Options.UseTextOptions = true;
            this.ReportGridView.Appearance.FilterPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ReportGridView.Appearance.FixedLine.Options.UseTextOptions = true;
            this.ReportGridView.Appearance.FixedLine.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ReportGridView.Appearance.FocusedCell.Options.UseTextOptions = true;
            this.ReportGridView.Appearance.FocusedCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ReportGridView.Appearance.FocusedRow.Options.UseTextOptions = true;
            this.ReportGridView.Appearance.FocusedRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ReportGridView.Appearance.FooterPanel.Options.UseTextOptions = true;
            this.ReportGridView.Appearance.FooterPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ReportGridView.Appearance.GroupButton.Options.UseTextOptions = true;
            this.ReportGridView.Appearance.GroupButton.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ReportGridView.Appearance.GroupFooter.Options.UseTextOptions = true;
            this.ReportGridView.Appearance.GroupFooter.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ReportGridView.Appearance.GroupPanel.Options.UseTextOptions = true;
            this.ReportGridView.Appearance.GroupPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ReportGridView.Appearance.GroupRow.Options.UseTextOptions = true;
            this.ReportGridView.Appearance.GroupRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ReportGridView.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.ReportGridView.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ReportGridView.Appearance.HideSelectionRow.Options.UseTextOptions = true;
            this.ReportGridView.Appearance.HideSelectionRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ReportGridView.Appearance.HorzLine.Options.UseTextOptions = true;
            this.ReportGridView.Appearance.HorzLine.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ReportGridView.Appearance.OddRow.Options.UseTextOptions = true;
            this.ReportGridView.Appearance.OddRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ReportGridView.Appearance.Preview.Options.UseTextOptions = true;
            this.ReportGridView.Appearance.Preview.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ReportGridView.Appearance.Row.Options.UseTextOptions = true;
            this.ReportGridView.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ReportGridView.Appearance.RowSeparator.Options.UseTextOptions = true;
            this.ReportGridView.Appearance.RowSeparator.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ReportGridView.Appearance.SelectedRow.Options.UseTextOptions = true;
            this.ReportGridView.Appearance.SelectedRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ReportGridView.Appearance.TopNewRow.Options.UseTextOptions = true;
            this.ReportGridView.Appearance.TopNewRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ReportGridView.Appearance.VertLine.Options.UseTextOptions = true;
            this.ReportGridView.Appearance.VertLine.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ReportGridView.Appearance.ViewCaption.Options.UseTextOptions = true;
            this.ReportGridView.Appearance.ViewCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ReportGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.RowID,
            this.PersonID,
            this.FName,
            this.LName,
            this.Mobile1,
            this.CodeMelei});
            this.ReportGridView.GridControl = this.ReportGridControl;
            this.ReportGridView.Name = "ReportGridView";
            this.ReportGridView.OptionsFind.AlwaysVisible = true;
            this.ReportGridView.OptionsView.ShowGroupPanel = false;
            // 
            // RowID
            // 
            this.RowID.FieldName = "RowID";
            this.RowID.MaxWidth = 60;
            this.RowID.MinWidth = 60;
            this.RowID.Name = "RowID";
            this.RowID.Visible = true;
            this.RowID.VisibleIndex = 0;
            this.RowID.Width = 60;
            // 
            // PersonID
            // 
            this.PersonID.FieldName = "PersonID";
            this.PersonID.MaxWidth = 100;
            this.PersonID.MinWidth = 75;
            this.PersonID.Name = "PersonID";
            this.PersonID.Visible = true;
            this.PersonID.VisibleIndex = 1;
            // 
            // FName
            // 
            this.FName.FieldName = "FName";
            this.FName.MinWidth = 100;
            this.FName.Name = "FName";
            this.FName.Visible = true;
            this.FName.VisibleIndex = 2;
            this.FName.Width = 100;
            // 
            // LName
            // 
            this.LName.FieldName = "LName";
            this.LName.MinWidth = 120;
            this.LName.Name = "LName";
            this.LName.Visible = true;
            this.LName.VisibleIndex = 3;
            this.LName.Width = 120;
            // 
            // Mobile1
            // 
            this.Mobile1.FieldName = "Mobile1";
            this.Mobile1.MinWidth = 120;
            this.Mobile1.Name = "Mobile1";
            this.Mobile1.Visible = true;
            this.Mobile1.VisibleIndex = 4;
            this.Mobile1.Width = 120;
            // 
            // CodeMelei
            // 
            this.CodeMelei.FieldName = "CodeMelei";
            this.CodeMelei.MinWidth = 120;
            this.CodeMelei.Name = "CodeMelei";
            this.CodeMelei.Visible = true;
            this.CodeMelei.VisibleIndex = 5;
            this.CodeMelei.Width = 120;
            // 
            // PersonListReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TopSidePanel);
            this.Controls.Add(this.BottonSidePanel);
            this.Name = "PersonListReportForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "گزارش اعضاء";
            this.BottonSidePanel.ResumeLayout(false);
            this.TopSidePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ReportGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReportGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SidePanel BottonSidePanel;
        private DevExpress.XtraEditors.SidePanel TopSidePanel;
        private DevExpress.XtraGrid.GridControl ReportGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView ReportGridView;
        private DevExpress.XtraGrid.Columns.GridColumn PersonID;
        private DevExpress.XtraGrid.Columns.GridColumn FName;
        private DevExpress.XtraGrid.Columns.GridColumn LName;
        private DevExpress.XtraGrid.Columns.GridColumn Mobile1;
        private DevExpress.XtraGrid.Columns.GridColumn CodeMelei;
        private DevExpress.XtraEditors.SimpleButton ExcelButton;
        private DevExpress.XtraEditors.SimpleButton CloseButton;
        private DevExpress.XtraEditors.SimpleButton PrintButton;
        private DevExpress.XtraGrid.Columns.GridColumn RowID;
        private DevExpress.XtraEditors.SimpleButton PdfButton;
    }
}