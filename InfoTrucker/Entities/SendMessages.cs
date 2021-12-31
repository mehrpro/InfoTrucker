﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfoTrucker.Entities
{
    public class SendMessages
    {
        public long ID { get; set; }
        public int PersonID_FK { get; set; }
        public Person Person { get; set; }
        public bool CheckedStatusFromWenService { get; set; }
        public int ResultSend { get; set; }
        public int MessageSubjectID_FK { get; set; }
        public MessageGroupSubject MessageGroupSubject { get; set; }
    }
}
