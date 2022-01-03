using System.Windows.Forms;
using InfoTrucker.UI.PersonForms;
using InfoTrucker.UI.SmsForms;

namespace InfoTrucker.UI
{
    public partial class MainForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        //private readonly UnitofWork<AppDbContext> _unitofWork;
        private StructureMap.Container _container;
        public StructureMap.Container Container { get => _container; set => _container = value; }

        public MainForm()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            this.StartPosition = FormStartPosition.CenterScreen;
            PersonReportBottonItem.ItemClick += PersonReportBottonItem_ItemClick;
        }




        private void PersonReportBottonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var frm = _container.GetInstance<ReportForms.PersonListReportForm>();
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Dock = DockStyle.Fill;
            frm.ControlBox = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Show();
        }

        private void NewPersonButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            var frm = _container.GetInstance<NewPersonForm>();
            frm.MdiParent = this;
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
            frm.WindowState = FormWindowState.Maximized;
            frm.Dock = DockStyle.Fill;
            frm.ControlBox = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Container = _container;


            frm.Show();
        }

        private void SendSmsButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var frm = _container.GetInstance<SendSmsForm>();
            frm.ControlBox = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.ShowDialog();
        }

        private void SendGroupSmsButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var frm = _container.GetInstance<SendSmsGroupForm>();
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Dock = DockStyle.Fill;
            frm.ControlBox = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            //frm.Container = _container;
            frm.Show();
        }

        private void SendStatusButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var frm = _container.GetInstance<SendStatusForm>();
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Dock = DockStyle.Fill;
            frm.ControlBox = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            //frm.Container = _container;
            frm.Show();
        }
    }
}
