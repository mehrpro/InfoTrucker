using System.Data.Entity;
using InfoTrucker.Entities;
using InfoTrucker.Infrastructure;

namespace InfoTrucker.Services
{
    public interface ISendMessageRepository
    {
        void Insert(SendMessages sendMessages);
    }


    public class SendMessageRepository : ISendMessageRepository
    {
        private readonly IUnitofWork _unitofWork;
        private readonly IDbSet<SendMessages> _sendMessageses;

        public SendMessageRepository(IUnitofWork unitofWork)
        {
            _unitofWork = unitofWork;
            _sendMessageses = _unitofWork.Set<SendMessages>();
        }

        public void Insert(SendMessages sendMessages)
        {
            _sendMessageses.Add(sendMessages);
        }
    }
}