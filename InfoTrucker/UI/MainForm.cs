using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using InfoTrucker.Infrastructure;
using InfoTrucker.Models;
using InfoTrucker.UI.AdminForms;
using InfoTrucker.UI.PersonForms;

namespace InfoTrucker.UI
{
    public partial class MainForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private readonly UnitofWork<AppDbContext> _unitofWork;
        private StructureMap.Container _container;
        public StructureMap.Container container { get => _container; set => _container = value; }

        public MainForm(UnitofWork<AppDbContext> unitofWork)
        {
            _unitofWork = unitofWork;
            //_container = container;
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            this.StartPosition = FormStartPosition.CenterScreen;


        }

        private void NewPersonButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            var frm = _container.GetInstance<UserManagmentForm>();
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
            var frm = _container.GetInstance<PersonForms.EditPersonForm>();
            frm.MdiParent = this;
            //frm.StartPosition = FormStartPosition.CenterParent;
            frm.WindowState = FormWindowState.Maximized;
            frm.Dock = DockStyle.Fill;
            frm.ControlBox = false;
            frm.FormBorderStyle = FormBorderStyle.None;


            frm.Show();
        }
    }
}
