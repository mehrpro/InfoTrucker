using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfoTrucker.DTO
{
    public class NewSendMessageDTO
    {
        public int PersonID_FK { get; set; }
        public bool CheckedStatusFromWenService { get; set; }
        public int ResultSend { get; set; }
        public int MessageSubjectID_FK { get; set; }
    }
}
