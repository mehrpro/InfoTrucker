using InfoTrucker.Infrastructure;
using InfoTrucker.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace InfoTrucker.Services
{
    public interface IExceptionSms : IRepositoryBase<ResultCodeMessage>
    {
        string ExceptionMessage(string exceptionCode);
    }

    public class ExcptionSms : RepositoryBase<ResultCodeMessage>, IExceptionSms
    {
        public ExcptionSms(DbContext context) : base(context)
        {

        }

        public string ExceptionMessage(string exceptionCode)
        {
            var errorNumber = Convert.ToInt32(exceptionCode);
            var resltcode = GetFirstOrDefault(x => x.ResultCode == errorNumber);
            return resltcode == null ? $"خطا نامشخص لطفا با مدیر سیستم تماس بگیرید" : resltcode.ResultMessage;
        }
    }
}
