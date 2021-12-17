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
    public partial class EditPersonForm : XtraForm
    {
        private readonly UnitofWork<AppDbContext> _unitofWork;
        private readonly IMapper _mapper;

        public EditPersonForm(UnitofWork<AppDbContext> unitofWork, IMapper mapper)
        {
            InitializeComponent();
            _unitofWork = unitofWork;
            _mapper = mapper;
            Task TaskList = GetPersonList();
        }



        public async Task GetPersonList()
        {
            var resultList = await _unitofWork.Person.GetAllAsync();
            var result = _mapper.Map<IEnumerable<PersonListForEditDTO>>(resultList);
            PersonListGridControl.DataSource = result;

        }
    }
}
