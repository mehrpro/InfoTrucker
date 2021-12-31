using System.Data.Entity;
using InfoTrucker.Entities;
using InfoTrucker.Infrastructure;


namespace InfoTrucker.Services
{

    public interface ISmsConfigureRepository : IRepositoryBase<SmsConfigure>
    {
        void UpdateValue();
    }


    public class SmsConfigureRepository : RepositoryBase<SmsConfigure>, ISmsConfigureRepository

    {
        public SmsConfigureRepository(DbContext context) : base(context)
        {

        }

        public void UpdateValue()
        {
            //encrypted string = yU6k4ImZAln1bwoUMOmwIA==
            //decrypted string = bijar_sms

            //encrypted string = bSkuzdmotZ/mpsw9SG0PXA ==
            //decrypted string = Ss987654@

            //encrypted string = 6q/oN0NY6evOItSS30aZBw==
            //decrypted string = 3000151590

            var result = GetFirstOrDefault(x => x.ID == "aec60a14-946c-4428-9151-7e7dfca6b31e");
            if (result != null)
            {
                PublicValue.SmsNumber = ASE.DecryptString(result.Sender);
                PublicValue.SmsUsername = ASE.DecryptString(result.Username);
                PublicValue.SmsPassword = ASE.DecryptString(result.Password);
                PublicValue.SmsPrice = result.Price;

            }
        }
    }
}
