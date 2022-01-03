using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using DevExpress.XtraEditors;
using InfoTrucker.DTO;
using InfoTrucker.Entities;
using InfoTrucker.Infrastructure;

namespace InfoTrucker.Services
{
    public interface IMessageGroupSubjectRepository
    {
        void Insert(MessageGroupSubject messageGroupSubject);
    }

    public class MessageGroupSubjectRepository : IMessageGroupSubjectRepository
    {
        private readonly IUnitofWork _unitofWork;
        private readonly IDbSet<MessageGroupSubject> _subjects;

        public MessageGroupSubjectRepository(IUnitofWork unitofWork)
        {
            _unitofWork = unitofWork;
            _subjects = _unitofWork.Set<MessageGroupSubject>();
        }


        public void Insert(MessageGroupSubject messageGroupSubject)
        {
            _subjects.Add(messageGroupSubject);
        }
    }
}