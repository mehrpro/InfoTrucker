using DevExpress.XtraEditors;
using InfoTrucker.DTO;
using InfoTrucker.Infrastructure;
using InfoTrucker.Models;
using System;
using System.Drawing;
using AutoMapper;
using InfoTrucker.Entities;
using WIA;
using System.Drawing.Imaging;
using InfoTrucker.Services;
using System.Windows.Forms;

namespace InfoTrucker.UI.PersonForms
{
    public partial class NewPersonForm : XtraForm
    {

        private readonly IUnitofWork _unitofWork;
        private readonly IMapper _mapper;
        private readonly IPersonRepository _personRepository;
        private bool _mobileValidate;
        private bool _codeMelieiValidate;
        private bool _hoshmandValidate;
        private bool _plackValidate;
        //private OpenFileDialog ofd;
        //private byte[] img;

        public NewPersonForm(IUnitofWork unitofWork, IMapper mapper, IPersonRepository personRepository)
        {
            _unitofWork = unitofWork;
            _mapper = mapper;
            _personRepository = personRepository;
            InitializeComponent();
            Id1Textbox.ReadOnly = Id2Textbox.ReadOnly = Id3Textbox.ReadOnly = true;
            BirthDatePicker.DateTime = DateTime.Today;
            LastId();
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
            var result = _personRepository.Get(x => x.Sh_Plak == obj.Text.Trim());
            if (result != null)
            {
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
            var result = _personRepository.Get(x => x.Mobile1 == mobile.Text.Trim());
            if (result != null)
            {
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
            var result = _personRepository.Get(x => x.Hoshmand == hosmandText.Text);
            if (result == null)
            {
                HoshmandErrorTextbox.Text = null;
                _hoshmandValidate = true;
            }
            else
            {
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
            var result = await _personRepository.LastPersonID();
            Id1Textbox.Text = Id2Textbox.Text = Id3Textbox.Text = result.ToString();
        }


        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (Person_dxProvider.Validate() && _mobileValidate && _codeMelieiValidate && _plackValidate && _hoshmandValidate)
            {
                var newPerson = new NewPersonDTO();
                newPerson.PersonID = Convert.ToInt32(Id1Textbox.Text);
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
                newPerson.Sh_Plak = PlackTextbox.Text.Trim();
                newPerson.Sh_Sokht = Sh_SokhtTextbox.Text.Trim();
                newPerson.Shenasnameh = ShenasnamehTextbox.Text.Trim();
                newPerson.Takalof = Convert.ToByte(TakalofSpanEdit.EditValue);
                newPerson.Tel = TelTextbox.Text.Trim();
                newPerson.UserID_FK = PublicValue.UserID;
                newPerson.Tavalod = BirthDatePicker.DateTime.Date;
                if (picPerson.Image != null)
                    newPerson.PersonImg = picPerson.Image.ImageToByte();
                else
                    newPerson.PersonImg = null;
                ///////////////////////////////
                var resultMap = _mapper.Map<Person>(newPerson);
                resultMap.IsActive = true;
                resultMap.IsDelete = false;
                resultMap.DateRegister = DateTime.Today;
                try
                {
                    _personRepository.Insert(resultMap);
                    _unitofWork.SaveChanges();
                    PublicValue.SaveMessage();
                    this.Close();
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

            var ofd = new OpenFileDialog();
            ofd.Filter = "jpg Files |*.jpg|PNG FIles |*.png";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                picPerson.Image = Image.FromFile(ofd.FileName);
            }





            //return;
            //var dlg = new WIA.CommonDialog();
            //ImageFile image = dlg.ShowAcquireImage(
            //    DeviceType: WiaDeviceType.ScannerDeviceType,
            //    Intent: WiaImageIntent.ColorIntent,
            //    Bias: WiaImageBias.MinimizeSize,
            //    FormatID: ImageFormat.Jpeg.Guid.ToString("B"),
            //    AlwaysSelectDevice: true,
            //    UseCommonUI: true,
            //    CancelError: false);
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


            var result = _personRepository.Get(x => x.CodeMelei == obj.Text);
            if (result != null)
            {
                NationalCodeErrorTextbox.Text = $@"این کد ملی قبلاً برای {result.FName} {result.LName} ثبت شده است";
                NationalCodeErrorTextbox.ForeColor = Color.Red;
                obj.BackColor = Color.MistyRose;

            }
            else
            {
                NationalCodeErrorTextbox.Text = null;
                obj.BackColor = Color.White;

            }

        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
