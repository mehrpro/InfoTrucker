using System.Data.Entity.ModelConfiguration;
using InfoTrucker.Entities;
using System.ComponentModel.DataAnnotations.Schema;

namespace InfoTrucker.Configure
{
    public class MessageGroupSubjectConfigure : EntityTypeConfiguration<MessageGroupSubject>
    {
        public MessageGroupSubjectConfigure()
        {
            HasKey(x => x.ID);
            Property(x => x.ID).IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.Subject).HasMaxLength(250).IsRequired();
            Property(x => x.CreateTime).IsRequired();
            Property(x => x.SendGroup).IsRequired();
            Property(x => x.Message).HasMaxLength(700);
            Property(x => x.WsdlString).IsRequired().HasMaxLength(10);
            HasMany(x => x.SendMessageses)
                .WithRequired(x => x.MessageGroupSubject)
                .HasForeignKey(x => x.MessageSubjectID_FK)
                .WillCascadeOnDelete(false);



        }
    }
}
