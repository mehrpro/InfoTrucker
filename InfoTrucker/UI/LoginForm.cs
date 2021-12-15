using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InfoTrucker.Infrastructure;
using InfoTrucker.Models;

namespace InfoTrucker.UI
{
    public partial class LoginForm : DevExpress.XtraEditors.XtraForm
    {
        private readonly IUnitofWork<AppDbContext> _unitofWork;

        public LoginForm(IUnitofWork<AppDbContext> unitofWork)
        {
            _unitofWork = unitofWork;
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            //var app = new Entities.PublicType();
            //app.Group = 1;
            //app.Title = "das";
            //_unitofWork.PublicType.Insert(app);
            //_unitofWork.Commit();


            var result = _unitofWork.PublicType.GetAll();
        }
    }
}
