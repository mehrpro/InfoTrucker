using System.Data.Entity;
using InfoTrucker.Entities;
using InfoTrucker.Infrastructure;

namespace InfoTrucker.Services
{
    public interface ISendMessageRepository : IRepositoryBase<SendMessages>
    {

    }


    public class SendMessageRepository : RepositoryBase<SendMessages>, ISendMessageRepository
    {
        public SendMessageRepository(DbContext context) : base(context)
        {

        }
    }
}