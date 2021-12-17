using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfoTrucker.DTO
{
    public class PersonListForEditDTO
    {
        [Display(Name ="شناسه")]
        public int PersonID { get; set; }
        [Display(Name ="نام")]
        public string FullName { get; set; }
        [Display(Name ="شماره هوشمند")]
        public string Hoshmand { get; set; }

    }
}
