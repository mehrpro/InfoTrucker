using DevExpress.XtraEditors;
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

namespace InfoTrucker.UI.PersonForms
{
    public partial class PersonEditPageForm : XtraForm
    {
        private readonly UnitofWork<AppDbContext> _unitOfWork;

        public PersonEditPageForm(UnitofWork<AppDbContext> unitOfWork)
        {
            InitializeComponent();
            _unitOfWork = unitOfWork;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
