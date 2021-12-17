using DevExpress.XtraEditors;
using InfoTrucker.DTO;
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
using InfoTrucker.Entities;

namespace InfoTrucker.UI.PersonForms
{
    public partial class NewPersonForm : XtraForm
    {

        private readonly UnitofWork<AppDbContext> _unitofWork;
        private readonly IMapper _mapper;

        public NewPersonForm(UnitofWork<AppDbContext> unitofWork, IMapper mapper)
        {
            _unitofWork = unitofWork;
            _mapper = mapper;
            InitializeComponent();
            Id1Textbox.ReadOnly = Id2Textbox.ReadOnly = Id3Textbox.ReadOnly = true;
            BirthDatePicker.DateTime  =DateTime.Today;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (Person_dxProvider.Validate())
            {
                var newPerson = new NewPersonDTO();
                newPerson.FName = FNameTextbox.Text.Trim();
                newPerson.LName = LNameTextbox.Text.Trim();
                newPerson.Address = AddressTextbox.Text.Trim();
                newPerson.CodeMelei = NationalCodeTextbox.Text.Trim();
                newPerson.CodePosti = CodePostiTextbox.Text.Trim();
                newPerson.FatherName = FatherTextbox.Text.Trim();
                newPerson.Hoshmand = HoshmandTextbox.Text.Trim();
                newPerson.HoshmandNavgan = HoshmandNavganTextbox.Text.Trim();
                newPerson.Kamion = KamionTextbox.Text.Trim();
                newPerson.MahelTavalod = MahalTavalodTextbox.Text.Trim();
                newPerson.Mobile1 = Mobile1Textbox.Text.Trim();
                newPerson.Mobile2 = Mobile2Textbox.Text.Trim();
                newPerson.Sh_Bimeh = Sh_BimehTextbox.Text.Trim();
                newPerson.SerialShenasnameh = ShSerialTextbox.Text.Trim();
                newPerson.Sh_Goyahinameh = Sh_GoyahinamehTextbox.Text.Trim();
                newPerson.Sh_Plak = Sh_PlakTextbox.Text.Trim();
                newPerson.Sh_Sokht = Sh_SokhtTextbox.Text.Trim();
                newPerson.Shenasnameh = ShenasnamehTextbox.Text.Trim();
                newPerson.Takalof = Convert.ToByte(TakalofSpanEdit.EditValue);
                newPerson.Tel = TelTextbox.Text.Trim();
                newPerson.UserID_FK = PublicValue.UserID;
                newPerson.Tavalod = BirthDatePicker.DateTime.Date;
                ///////////////////////////////
                var resultMap = _mapper.Map<Person>(newPerson);
                resultMap.IsActive = true;
                resultMap.IsDelete = false;
                resultMap.DateRegister = DateTime.Today;
                _unitofWork.Person.Insert(resultMap);
                _unitofWork.Commit();


            }
            else
            {
                PublicValue.ValidationProviderFaultMessage();
            }
        }
    }
}
