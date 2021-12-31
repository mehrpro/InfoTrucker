using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using InfoTrucker.Entities;

namespace InfoTrucker.Configure
{
    public class SendMessageConfigure : EntityTypeConfiguration<SendMessages>
    {
        public SendMessageConfigure()
        {
            HasKey(x => x.ID);
            Property(x => x.ID).IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.PersonID_FK).IsRequired();
            Property(x => x.ResultSend).IsRequired();
            Property(x => x.CheckedStatusFromWenService).IsRequired();
            Property(x => x.MessageSubjectID_FK).IsRequired();

        }
    }
}
