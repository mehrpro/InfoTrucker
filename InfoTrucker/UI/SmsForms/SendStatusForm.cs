using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AutoMapper;
using DevExpress.XtraEditors;
using InfoTrucker.Infrastructure;
using InfoTrucker.Models;

namespace InfoTrucker.UI.SmsForms
{
    public partial class SendStatusForm : XtraForm
    {
        private readonly UnitofWork<AppDbContext> _unitofWork;
        private readonly IMapper _mapper;

        public SendStatusForm(UnitofWork<AppDbContext> unitofWork, IMapper mapper)
        {
            _unitofWork = unitofWork;
            _mapper = mapper;
            InitializeComponent();
        }




    }
}
