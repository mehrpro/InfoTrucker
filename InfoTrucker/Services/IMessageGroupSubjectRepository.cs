using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using DevExpress.XtraEditors;
using InfoTrucker.DTO;
using InfoTrucker.Entities;
using InfoTrucker.Infrastructure;

namespace InfoTrucker.Services
{
    public interface IMessageGroupSubjectRepository
    {
        void Insert(MessageGroupSubject messageGroupSubject);
        MessageGroupSubject GetById(int id);
        IEnumerable<MessageGroupSubject> GetAll();
        IEnumerable<MessageGroupSubject> GetAllByCondition(Expression<Func<MessageGroupSubject, bool>> expression);
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

        public MessageGroupSubject GetById(int id)
        {
            return _subjects.Find(id);
        }

        public IEnumerable<MessageGroupSubject> GetAll()
        {
            return _subjects.AsEnumerable();
        }

        public IEnumerable<MessageGroupSubject> GetAllByCondition(Expression<Func<MessageGroupSubject, bool>> expression)
        {
            return _subjects.Where(expression).AsEnumerable();
        }
    }
}