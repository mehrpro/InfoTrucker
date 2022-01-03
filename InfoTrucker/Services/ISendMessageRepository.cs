using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using DevExpress.Data.ODataLinq.Helpers;
using InfoTrucker.Entities;
using InfoTrucker.Infrastructure;

namespace InfoTrucker.Services
{
    public interface ISendMessageRepository
    {
        void Insert(SendMessages sendMessages);
        Task<IList<SendMessages>> GetMessagesByPersonIdAsync(int personId);

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

        public async Task<IList<SendMessages>> GetMessagesByPersonIdAsync(int personId)
        {
            return await _sendMessageses.Where(x => x.PersonID_FK == personId).Include(x=>x.MessageGroupSubject).ToListAsync();
        }
    }
}