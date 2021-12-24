using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfoTrucker.DTO
{
    public class PersonListForSms
    {
        [Display(AutoGenerateField =false)]
        public int ID { get; set; }

        [Display(Name = "کد عضویت")]
        public int PersonID { get; set; }
        [Display(Name = "نام نام خانوادگی")]
        public string FullName { get; set; }
        [Display(Name = "تلفن همراه")]
        public string Mobile1 { get; set; }


    }
}
