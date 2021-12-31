using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraWaitForm;

namespace InfoTrucker.UI.SmsForms
{
    public partial class WaitSaveSMSForm : WaitForm
    {
        public WaitSaveSMSForm()
        {
            InitializeComponent();
            this.SaveProgressPanel.AutoSize = true;
        }

        #region Overrides

        public override void SetCaption(string caption) {
            base.SetCaption(caption);
            this.SaveProgressPanel.Caption = caption;
        }
        public override void SetDescription(string description) {
            base.SetDescription(description);
            this.SaveProgressPanel.Description = description;
        }
        public override void ProcessCommand(Enum cmd, object arg) {
            base.ProcessCommand(cmd, arg);
        
        }

        #endregion

        public enum WaitFormCommand {
        }
    }
}
