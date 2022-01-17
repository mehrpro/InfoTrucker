using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using InfoTrucker.Entities;


namespace InfoTrucker.Configure
{
    public class CommissionConfigure : EntityTypeConfiguration<Commission>
    {
        public CommissionConfigure()
        {
            HasKey(x => x.CommissionID);
            Property(x => x.CommissionID).IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.Groups_FK).IsRequired();
            Property(x => x.CenterID_FK).IsRequired();
            Property(x => x.CommissionPrice).IsRequired();
            Property(x => x.enabled).IsRequired();
            Property(x => x.DataRegister).IsRequired().HasColumnType("datetime");
            Property(x => x.GroupID).IsRequired();
            HasMany(x => x.Queues)
                .WithRequired(x => x.Commission)
                .HasForeignKey(x => x.ComosiunID_FK)
                .WillCascadeOnDelete(false);
        }
    }
}