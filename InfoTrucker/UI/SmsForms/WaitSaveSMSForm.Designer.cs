
namespace InfoTrucker.UI.SmsForms
{
    partial class WaitSaveSMSForm
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
            this.SaveProgressPanel = new DevExpress.XtraWaitForm.ProgressPanel();
            this.SuspendLayout();
            // 
            // SaveProgressPanel
            // 
            this.SaveProgressPanel.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.SaveProgressPanel.Appearance.Options.UseBackColor = true;
            this.SaveProgressPanel.AppearanceCaption.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.Yes;
            this.SaveProgressPanel.AppearanceDescription.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.Yes;
            this.SaveProgressPanel.BarAnimationElementThickness = 2;
            this.SaveProgressPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SaveProgressPanel.Location = new System.Drawing.Point(0, 0);
            this.SaveProgressPanel.Name = "SaveProgressPanel";
            this.SaveProgressPanel.RingAnimationDiameter = 10;
            this.SaveProgressPanel.Size = new System.Drawing.Size(322, 75);
            this.SaveProgressPanel.TabIndex = 0;
            this.SaveProgressPanel.Text = "progressPanel1";
            // 
            // WaitSaveSMSForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 75);
            this.Controls.Add(this.SaveProgressPanel);
            this.Name = "WaitSaveSMSForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "WaitSaveSMS";
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraWaitForm.ProgressPanel SaveProgressPanel;
    }
}