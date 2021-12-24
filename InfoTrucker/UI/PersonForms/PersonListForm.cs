using AutoMapper;
using DevExpress.XtraEditors;
using InfoTrucker.DTO;
using InfoTrucker.Infrastructure;
using InfoTrucker.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InfoTrucker.UI.PersonForms
{
    public partial class PersonListForm : XtraForm
    {
        private readonly UnitofWork<AppDbContext> _unitofWork;
        private readonly IMapper _mapper;
        private StructureMap.Container _container;
        public StructureMap.Container Container { get => _container; set => _container = value; }


        public PersonListForm(UnitofWork<AppDbContext> unitofWork, IMapper mapper)
        {
            InitializeComponent();
            _unitofWork = unitofWork;
            _mapper = mapper;
            GetPersonList();
            
        }



        public async void GetPersonList()
        {
            var resultList = await _unitofWork.Person.GetAllAsync();
            var result = _mapper.Map<IEnumerable<PersonListForEditDTO>>(resultList);
            PersonListGridControl.DataSource = result;

        }

        private void EditRowBotton_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (gridView1.GetFocusedRowCellValue("ID") != null)
            {
                var row = gridView1.GetFocusedRow();
                var _selectedRow = (PersonListForEditDTO)row;
                var frm = _container.GetInstance<EditPersonForm>();
                frm.Id = _selectedRow.ID;

                frm.ShowDialog();
            }
        }
    }
}