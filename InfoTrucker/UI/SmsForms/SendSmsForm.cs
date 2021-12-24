using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InfoTrucker.UI.SmsForms
{
    public partial class SendSmsForm : XtraForm
    {
        private readonly Infrastructure.UnitofWork<Models.AppDbContext> _unitofWork;
        private readonly AutoMapper.IMapper _mapper;
        public SendSmsForm(Infrastructure.UnitofWork<Models.AppDbContext> unitofWork, AutoMapper.IMapper mapper)
        {
            _unitofWork = unitofWork;
            _mapper = mapper;


            InitializeComponent();
        }
    }
}
