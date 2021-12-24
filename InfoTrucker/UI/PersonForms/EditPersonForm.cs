using AutoMapper;
using DevExpress.XtraEditors;
using InfoTrucker.DTO;
using InfoTrucker.Entities;
using InfoTrucker.Infrastructure;
using InfoTrucker.Models;
using System;
using System.Drawing;
using System.Drawing.Imaging;
using WIA;

namespace InfoTrucker.UI.PersonForms
{
    public partial class EditPersonForm : XtraForm
    {

        private readonly UnitofWork<AppDbContext> _unitofWork;
        private readonly IMapper _mapper;
        private bool _mobileValidate;
        private bool _codeMelieiValidate;
        private bool _hoshmandValidate;
        private bool _plackValidate;
        private Person person;
        public int Id { get; set; }

        public EditPersonForm(UnitofWork<AppDbContext> unitofWork, IMapper mapper)
        {
            _unitofWork = unitofWork;
            _mapper = mapper;
            InitializeComponent();
            Id1Textbox.ReadOnly = Id2Textbox.ReadOnly = Id3Textbox.ReadOnly = true;

            NationalCodeTextbox.LostFocus += NationalCodeTextbox_LostFocus;
            HoshmandTextbox.TextChanged += HoshmandTextbox_TextChanged;
            Mobile1Textbox.TextChanged += Mobile1Textbox_TextChanged;
            Mobile1Textbox.LostFocus += Mobile1Textbox_LostFocus;
            PlackTextbox.TextChanged += PlackTextbox_TextChanged;


        }

        private void PlackTextbox_TextChanged(object sender, EventArgs e)
        {
            var obj = (TextEdit)sender;
            if (obj.Text.Length < 19)
            {
                PlackErrorTextbox.Text = null;
                _plackValidate = false;
                return;
            }
            var result = _unitofWork.Person.Get(x => x.Sh_Plak == obj.Text.Trim());
            if (result != null)
            {
                if (result.ID == Id)
                {
                    _plackValidate = true;
                    return;
                }
                PlackErrorTextbox.Text = $@"این پلاک برای راننده {result.FName} {result.LName} ثبت شده است";
                PlackErrorTextbox.ForeColor = Color.Red;
                _plackValidate = false;
            }
            else
            {
                PlackErrorTextbox.Text = null;
                _plackValidate = true;

            }

        }

        private void Mobile1Textbox_LostFocus(object sender, EventArgs e)
        {
            var mobile = (TextEdit)sender;
            if (mobile.Text.Length < 11)
            {
                MobileErrorTextbox.Text = @"شماره تلفن را صحیح وارد کنید 09126620474";
                MobileErrorTextbox.ForeColor = Color.Red;
                _mobileValidate = false;
            }
            else
            {
                _mobileValidate = true;
            }

        }

        private void Mobile1Textbox_TextChanged(object sender, EventArgs e)
        {
            var mobile = (TextEdit)sender;
            var result = _unitofWork.Person.Get(x => x.Mobile1 == mobile.Text.Trim());
            if (result != null)
            {
                if (result.ID == Id)
                {
                    _mobileValidate = true;
                    return;
                }
                MobileErrorTextbox.Text = $@"این شماره تلفن قبلاً برای {result.FName} {result.LName} ثبت شده است";
                MobileErrorTextbox.ForeColor = Color.Red;
                mobile.BackColor = Color.MistyRose;

            }
            else
            {
                MobileErrorTextbox.Text = null;
                MobileErrorTextbox.ForeColor = Color.White;
                mobile.BackColor = Color.White;

            }
        }

        private void HoshmandTextbox_TextChanged(object sender, EventArgs e)
        {
            var hosmandText = (TextEdit)sender;
            var result = _unitofWork.Person.Get(x => x.Hoshmand == hosmandText.Text);
            if (result == null)
            {
                HoshmandErrorTextbox.Text = null;
                _hoshmandValidate = true;
            }
            else
            {
                if (result.ID == Id)
                {
                    _hoshmandValidate = true;
                    return;
                }
                HoshmandErrorTextbox.Text = $@"این شماره هوشمند قبلاً برای {result.FName} {result.LName} ثبت شده است";
                _hoshmandValidate = false;

            }
        }

        private void NationalCodeTextbox_LostFocus(object sender, EventArgs e)
        {
            var obj = (TextEdit)sender;
            if (obj.Text.Length != 10)
            {
                NationalCodeErrorTextbox.Text = @"کارت ملی 10 رقمی است";
                _codeMelieiValidate = false;
            }
            else
            {
                _codeMelieiValidate = true;
            }

        }

        private async void LastId()
        {
            person = _unitofWork.Person.GetById(Id);
            Id1Textbox.Text = Id2Textbox.Text = Id3Textbox.Text = person.PersonID.ToString();
            FNameTextbox.Text = person.FName;
            LNameTextbox.Text = person.LName;
            AddressTextbox.Text = person.Address;
            CodePostiTextbox.Text = person.CodePosti;
            NationalCodeTextbox.Text = person.CodeMelei;
            FatherTextbox.Text = person.FatherName;
            HoshmandNavganTextbox.Text = person.HoshmandNavgan;
            HoshmandTextbox.Text = person.Hoshmand;
            KamionTextbox.Text = person.Kamion;
            MahalTavalodTextbox.Text = person.MahelTavalod;
            Mobile1Textbox.Text = person.Mobile1;
            Mobile2Textbox.Text = person.Mobile2;
            Sh_BimehTextbox.Text = person.Sh_Bimeh;
            ShSerialTextbox.Text = person.SerialShenasnameh;
            Sh_GoyahinamehTextbox.Text = person.Sh_Goyahinameh;
            PlackTextbox.Text = person.Sh_Plak;
            Sh_SokhtTextbox.Text = person.Sh_Sokht;
            ShenasnamehTextbox.Text = person.Shenasnameh;
            TakalofSpanEdit.EditValue = person.Takalof;
            TelTextbox.Text = person.Tel;
            BirthDatePicker.DateTime = person.Tavalod.Date;
        }


        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (Person_dxProvider.Validate() && _mobileValidate && _codeMelieiValidate && _plackValidate && _hoshmandValidate)
            {

                person.FName = FNameTextbox.Text.Trim();
                person.LName = LNameTextbox.Text.Trim();
                person.Address = AddressTextbox.Text.Trim();
                person.CodeMelei = NationalCodeTextbox.Text.Trim();
                person.CodePosti = CodePostiTextbox.Text.Trim();
                person.FatherName = FatherTextbox.Text.Trim();
                person.Hoshmand = HoshmandTextbox.Text.Trim();
                person.HoshmandNavgan = HoshmandNavganTextbox.Text.Trim();
                person.Kamion = KamionTextbox.Text.Trim();
                person.MahelTavalod = MahalTavalodTextbox.Text.Trim();
                person.Mobile1 = Mobile1Textbox.Text.Trim();
                person.Mobile2 = Mobile2Textbox.Text.Trim();
                person.Sh_Bimeh = Sh_BimehTextbox.Text.Trim();
                person.SerialShenasnameh = ShSerialTextbox.Text.Trim();
                person.Sh_Goyahinameh = Sh_GoyahinamehTextbox.Text.Trim();
                person.Sh_Plak = PlackTextbox.Text.Trim();
                person.Sh_Sokht = Sh_SokhtTextbox.Text.Trim();
                person.Shenasnameh = ShenasnamehTextbox.Text.Trim();
                person.Takalof = Convert.ToByte(TakalofSpanEdit.EditValue);
                person.Tel = TelTextbox.Text.Trim();
                person.UserID_FK = PublicValue.UserID;
                person.Tavalod = BirthDatePicker.DateTime.Date;
                ///////////////////////////////
                //var resultMap = _mapper.Map<Person>(person);

                try
                {
                    _unitofWork.Person.Update(person);
                    _unitofWork.Commit();
                    PublicValue.SaveMessage();
                    Close();
                }
                catch (Exception exception)
                {
                    if (PublicValue.UserID == 1)
                        PublicValue.ExseptionMessage(exception.Message);
                    else
                        PublicValue.ErrorSaveMessage();
                }
            }
            else
                PublicValue.ValidationProviderFaultMessage();
        }

        private void ScanButton_Click(object sender, EventArgs e)
        {

            return;
            var dlg = new WIA.CommonDialog();
            ImageFile image = dlg.ShowAcquireImage(
                DeviceType: WiaDeviceType.ScannerDeviceType,
                Intent: WiaImageIntent.ColorIntent,
                Bias: WiaImageBias.MinimizeSize,
                FormatID: ImageFormat.Jpeg.Guid.ToString("B"),
                AlwaysSelectDevice: true,
                UseCommonUI: true,
                CancelError: false);
        }

        private void NationalCodeTextbox_TextChanged(object sender, EventArgs e)
        {
            var obj = (TextEdit)sender;
            if (obj.Text.Length < 10)
            {
                NationalCodeErrorTextbox.Text = null;
                obj.BackColor = Color.White;
                return;
            }


            var result = _unitofWork.Person.Get(x => x.CodeMelei == obj.Text);
            if (result != null)
            {
                if (result.ID == Id)
                {
                    _codeMelieiValidate = true;
                    return;
                }
                NationalCodeErrorTextbox.Text = $@"این کد ملی قبلاً برای {result.FName} {result.LName} ثبت شده است";
                NationalCodeErrorTextbox.ForeColor = Color.Red;
                obj.BackColor = Color.MistyRose;
                _codeMelieiValidate = false;

            }
            else
            {
                NationalCodeErrorTextbox.Text = null;
                obj.BackColor = Color.White;
                _codeMelieiValidate = false;

            }

        }

        private void EditPersonForm_Load(object sender, EventArgs e)
        {
            LastId();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
