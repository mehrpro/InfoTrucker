using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InfoTrucker.Infrastructure;

using DevExpress.XtraEditors;

namespace InfoTrucker.UI.SmsForms
{
    public partial class ReceiveMessageForm : XtraForm
    {
        private readonly IUnitofWork _unitofWork;
        private readonly IUnitOfWorkClass _unitOfWorkClass;

        public ReceiveMessageForm(IUnitofWork unitofWork, IUnitOfWorkClass unitOfWorkClass)
        {
            InitializeComponent();
            _unitofWork = unitofWork;
            _unitOfWorkClass = unitOfWorkClass;
            ReciveSMS();
        }


        private void ReciveSMS()
        {
            var resultReceiver = _unitOfWorkClass.SMSClient.GetSmsReceived(PublicValue.SmsUsername, PublicValue.SmsPassword);

        }
    }
}
