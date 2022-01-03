using InfoTrucker.Infrastructure;
using InfoTrucker.Entities;
using System;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace InfoTrucker.Services
{
    public interface IExceptionSms
    {
        string ExceptionMessage(string exceptionCode);
    }

    public class ExcptionSms : IExceptionSms
    {
        private readonly IUnitofWork _unitofWork;
        private readonly IDbSet<ResultCodeMessage> _excptionSms;

        public ExcptionSms(IUnitofWork unitofWork)
        {
            _unitofWork = unitofWork;
            _excptionSms = _unitofWork.Set<ResultCodeMessage>();
        }

        public string ExceptionMessage(string exceptionCode)
        {
            var errorNumber = Convert.ToInt32(exceptionCode);
            var resltcode = _excptionSms.FirstOrDefault(x => x.ResultCode == errorNumber);
            return resltcode == null ? $"خطا نامشخص لطفا با مدیر سیستم تماس بگیرید" : resltcode.ResultMessage;
        }
    }
}
