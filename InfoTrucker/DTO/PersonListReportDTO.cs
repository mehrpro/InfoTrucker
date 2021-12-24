using System.ComponentModel.DataAnnotations;

namespace InfoTrucker.DTO
{
    public class PersonListReportDTO
    {
        [Display(Name = "ردیف")]
        public int RowID { get; set; }
        [Display(Name = "کد عضویت")]
        public int PersonID { get; set; }
        [Display(Name = "نام")]
        public string FName { get; set; }
        [Display(Name = "نام خانوادگی")]
        public string LName { get; set; }
        [Display(Name = "تلفن همراه")]
        public string Mobile1 { get; set; }
        [Display(Name = "کد ملی")]
        public string CodeMelei { get; set; }

    }
}
