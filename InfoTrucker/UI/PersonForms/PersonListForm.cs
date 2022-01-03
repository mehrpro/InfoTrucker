using AutoMapper;
using DevExpress.XtraEditors;
using InfoTrucker.DTO;
using InfoTrucker.Infrastructure;
using System.Collections.Generic;
using InfoTrucker.Services;

namespace InfoTrucker.UI.PersonForms
{
    public partial class PersonListForm : XtraForm
    {
        private readonly IUnitofWork _unitofWork;
        private readonly IMapper _mapper;
        private readonly IPersonRepository _personRepository;
        private StructureMap.Container _container;
        public StructureMap.Container Container { get => _container; set => _container = value; }


        public PersonListForm(IUnitofWork unitofWork, IMapper mapper, IPersonRepository personRepository)
        {
            InitializeComponent();
            _unitofWork = unitofWork;
            _mapper = mapper;
            _personRepository = personRepository;
            GetPersonList();

        }



        public void GetPersonList()
        {
            var resultList = _personRepository.GetAllEnumerable();
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