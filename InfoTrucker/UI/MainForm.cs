using System.Windows.Forms;
using InfoTrucker.UI.PersonForms;

namespace InfoTrucker.UI
{
    public partial class MainForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        //private readonly UnitofWork<AppDbContext> _unitofWork;
        private StructureMap.Container _container;
        public StructureMap.Container Container { get => _container; set => _container = value; }

        public MainForm()
        {
            //_unitofWork = unitofWork;
            //_container = container;
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            this.StartPosition = FormStartPosition.CenterScreen;;

            PersonReportBottonItem.ItemClick += PersonReportBottonItem_ItemClick;


        }

        private void PersonReportBottonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var frm = _container.GetInstance<ReportForms.PersonListReportForm>();
            frm.MdiParent = this;
            frm.WindowState =FormWindowState.Maximized;
            frm.Dock = DockStyle.Fill;
            frm.ControlBox = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Show();
        }

        private void NewPersonButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            var frm = _container.GetInstance<NewPersonForm>();
            frm.MdiParent = this;
            //frm.StartPosition = FormStartPosition.CenterParent;
            frm.WindowState = FormWindowState.Maximized;
            frm.Dock = DockStyle.Fill;
            frm.ControlBox = false;
            frm.FormBorderStyle = FormBorderStyle.None;


            frm.Show();
        }

        private void EditButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var frm = _container.GetInstance<PersonListForm>();
            frm.MdiParent = this;
            //frm.StartPosition = FormStartPosition.CenterParent;
            frm.WindowState = FormWindowState.Maximized;
            frm.Dock = DockStyle.Fill;
            frm.ControlBox = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Container = _container;


            frm.Show();
        }

        private void SendSmsButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
                       var frm = _container.GetInstance<UI.SmsForms.SendSmsForm>();
            //frm.MdiParent = this;
            //frm.StartPosition = FormStartPosition.CenterParent;
            //frm.WindowState = FormWindowState.Maximized;
            //frm.Dock = DockStyle.Fill;
            frm.ControlBox = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.StartPosition = FormStartPosition.CenterScreen;
            //frm.Container = _container;


            frm.ShowDialog();
        }
    }
}
