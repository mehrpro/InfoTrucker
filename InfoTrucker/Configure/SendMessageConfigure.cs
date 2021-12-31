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
            Property(x => x.Message).HasMaxLength(700);
            Property(x => x.Reciver).HasMaxLength(11);
            Property(x => x.WsdlCheckSendString).HasMaxLength(10);
            Property(x => x.WsdlCheckSendString).HasMaxLength(10);
            Property(x => x.SendGroup).IsRequired();
            Property(x => x.CheckedStatusFromWenService).IsRequired();
            Property(x => x.MessageSubjectID_FK).IsRequired();

        }
    }
}
