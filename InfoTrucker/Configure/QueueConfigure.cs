using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using InfoTrucker.Entities;

namespace InfoTrucker.Configure
{
    public class QueueConfigure : EntityTypeConfiguration<Queue>
    {
        public QueueConfigure()
        {
            HasKey(x => x.ID);
            Property(x => x.ID).IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.Number).IsRequired();
            Property(x => x.GroupCommission).IsRequired();
            Property(x => x.Type_FK).IsRequired();
            Property(x => x.DateTimeRegister).IsRequired().HasColumnType("datetime");
            Property(x => x.DriverID_FK).IsRequired();
            Property(x => x.Status_FK).IsRequired();
            Property(x => x.ComosiunID_FK).IsRequired();
            Property(x => x.SeriesID_FK).IsRequired();
            Property(x => x.CenterID_FK).IsRequired();
            HasMany(x => x.Cashes)
                .WithRequired(x => x.Queue)
                .HasForeignKey(x => x.QueueID_FK)
                .WillCascadeOnDelete(false);

        }
    }
}