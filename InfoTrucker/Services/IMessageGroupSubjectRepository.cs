﻿using System.Data.Entity;
using InfoTrucker.Entities;
using InfoTrucker.Infrastructure;

namespace InfoTrucker.Services
{
    public interface IMessageGroupSubjectRepository : IRepositoryBase<MessageGroupSubject>
    {

    }

    public class MessageGroupSubjectRepository : RepositoryBase<MessageGroupSubject>, IMessageGroupSubjectRepository
    {
        public MessageGroupSubjectRepository(DbContext context) : base(context)
        {

        }
    }
}