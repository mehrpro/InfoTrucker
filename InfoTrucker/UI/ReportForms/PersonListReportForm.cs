using DevExpress.XtraEditors;
using InfoTrucker.Infrastructure;
using InfoTrucker.Models;
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
using InfoTrucker.DTO;
using DevExpress.XtraPrinting;
using System.Drawing.Printing;
using DevExpress.LookAndFeel;
using InfoTrucker.Services;

namespace InfoTrucker.UI.ReportForms
{
    public partial class PersonListReportForm : XtraForm
    {

        private readonly IUnitofWork _unitofwork;
        private readonly IMapper _mapper;
        private readonly IPersonRepository _personRepository;

        public PersonListReportForm(IUnitofWork unitofWork, IMapper mapper, IPersonRepository personRepository)
        {
            _unitofwork = unitofWork;
            _mapper = mapper;
            _personRepository = personRepository;
            InitializeComponent();
            ExcelButton.Click += ExcelButton_Click;
            PrintButton.Click += PrintButton_Click;
            PersonListReport();
        }

        private void PrintButton_Click(object sender, EventArgs e)
        {
            var ps = new PrintingSystem();
            var link = new PrintableComponentLink(ps);
            link.Component = ReportGridControl;
            link.Margins.Right = 10;
            link.Margins.Left = 10;
            link.Margins.Top = 10;
            link.Margins.Bottom = 10;
            link.PaperKind = PaperKind.A4;
            link.Landscape = false;
            link.CreateDocument();
            link.ShowRibbonPreviewDialog(UserLookAndFeel.Default);
        }

        private void ExcelButton_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        public void PersonListReport()
        {
            var result = _personRepository.GetAllEnumerable();
            var resultList = _mapper.Map<List<PersonListReportDTO>>(result);
            for (int i = 0; i < resultList.Count(); i++)
                resultList[i].RowID = i + 1;
            ReportGridControl.DataSource = resultList;

        }

        private void sidePanel1_Click(object sender, EventArgs e)
        {

        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
