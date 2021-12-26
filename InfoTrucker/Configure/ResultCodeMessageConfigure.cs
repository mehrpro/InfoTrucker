using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using InfoTrucker.Entities;

namespace InfoTrucker.Configure
{
    public class ResultCodeMessageConfigure : EntityTypeConfiguration<ResultCodeMessage>
    {
        public ResultCodeMessageConfigure()
        {
            HasKey(x => x.ID);
            Property(x => x.ID).IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.ResultMessage).HasMaxLength(250);
            //HasMany(x => x.SendMessages)
            //    .WithRequired(x => x.ResultCodeMessage)
            //    .HasForeignKey(x => x.ResultMessageCode_FK)
            //    .WillCascadeOnDelete(false);
        }
    }
}
