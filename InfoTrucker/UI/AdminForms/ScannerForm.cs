using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using WIA;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;
using DevExpress.XtraEditors;
using InfoTrucker.Infrastructure;
using DevExpress.XtraEditors.Controls;

namespace InfoTrucker.UI.AdminForms
{
    public partial class ScannerForm : XtraForm
    {

        private int height = 0, width = 0;
        private Image imgTemp;
        private Bitmap OriginalImage;
        private Bitmap CroppedImage;
        private Bitmap DisplayImage;
        private Graphics DisplayGraphics;
        private bool Drawing = false;
        private Point StartPoint, EndPoint;
        private byte[] readImage;
        private bool Change = false;
        private bool Basic = false;
        private bool Op = false;
        private bool CropClick = false;
        private bool Undo = false;





        public ScannerForm()
        {
            InitializeComponent();
        }

        public void scannerList()
        {
            try
            {
                List<string> devices = WIAScanner.GetDevices();
                if (devices.Count() > 0)
                {
                    ScannerListComboBox.Text = "هیچ دستگاه اسکنری به کامپیوتر متصل نیست";
                    BackButton.Enabled = ForwardButton.Enabled = EditButton.Enabled = ScanButton.Enabled = SaveButton.Enabled = false;
                }
                else
                {
                    BackButton.Enabled = ForwardButton.Enabled = EditButton.Enabled = ScanButton.Enabled = SaveButton.Enabled = true;
                    foreach (string device in devices)
                    {
                        ScannerListComboBox.Properties.Items.Add(devices);
                    }
                    ScannerListComboBox.SelectedIndex = 0;
                }

            }
            catch (Exception ex)
            {

                PublicValue.ExseptionMessage(ex.Message);
            }
        }



        private Bitmap LoadBitmapUnlocked(Image file_name)
        {
            using (Bitmap bm = new Bitmap(file_name))
            {
                Bitmap new_bitmap = new Bitmap(bm.Width, bm.Height);
                using (Graphics gr = Graphics.FromImage(new_bitmap))
                {
                    gr.DrawImage(bm, 0, 0);
                }
                return new_bitmap;
            }
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            PreviewPicturebox.Cursor = Cursors.Cross;
            //  Select = true;
            Undo = false;
            Op = true;

            MemoryStream MS = new MemoryStream();

            PreviewPicturebox.Image.Save(MS, ImageFormat.Jpeg);
            readImage = MS.GetBuffer();
            PreviewPicturebox.Image = Image.FromStream(MS);
            // PreviewPicturebox.Image.Save(imgTemp, PreviewPicturebox.Image.RawFormat);

            //  OriginalImage = LoadBitmapUnlocked(@"c:\rotatecrop");
            CroppedImage = OriginalImage.Clone() as Bitmap;
            DisplayImage = CroppedImage.Clone() as Bitmap;
            DisplayGraphics = Graphics.FromImage(DisplayImage);

            PreviewPicturebox.Image = DisplayImage;
            PreviewPicturebox.Visible = true;
        }

        private void ScannerForm_Load(object sender, EventArgs e)
        {

        }

        private void ScanButton_Click(object sender, EventArgs e)
        {
            if (ScannerListComboBox.SelectedIndex >= 0)
            {
                IList<Image> images = WIAScanner.Scan((string)ScannerListComboBox.SelectedItem);
                foreach (Image image in images)
                {
                    PreviewPicturebox.Image = image;
                    PreviewPicturebox.Show();
                    PreviewPicturebox.Properties.SizeMode = PictureSizeMode.Stretch;

                }

                var img = PreviewPicturebox.Image;
                PictureSizeLabel.Text = $"{img.Width} * {img.Height}";

                OriginalImage = LoadBitmapUnlocked(PreviewPicturebox.Image);
                CroppedImage = OriginalImage.Clone() as Bitmap;
                DisplayImage = CroppedImage.Clone() as Bitmap;
                DisplayGraphics = Graphics.FromImage(DisplayImage);

                //PreviewPicturebox.Image = DisplayImage ;
                //PreviewPicturebox.Visible = true ;

                MemoryStream memoryStream = new MemoryStream();

                img.Save(memoryStream, ImageFormat.Jpeg);
                readImage = memoryStream.GetBuffer();

            }
        }
    }
}
