using System.Data.Entity.ModelConfiguration;
using InfoTrucker.Entities;

namespace InfoTrucker.Configure
{
    public class LoadTypeConfigure : EntityTypeConfiguration<LoadType>
    {
        public LoadTypeConfigure()
        {
            HasKey(x => x.TypeID);
            Property(x => x.TypeID).IsRequired();
            Property(x => x.Type).HasMaxLength(50);
            HasMany(x => x.Commissions)
                .WithRequired(x => x.LoadType)
                .HasForeignKey(x => x.Groups_FK)
                .WillCascadeOnDelete(false);
            HasMany(x => x.Commissions1)
                .WithRequired(x => x.LoadType1)
                .HasForeignKey(x => x.GroupID)
                .WillCascadeOnDelete(false);
            HasMany(x => x.Drivers)
                .WithRequired(x => x.LoadType)
                .HasForeignKey(x => x.GroupID)
                .WillCascadeOnDelete(false);
            HasMany(x => x.Queues)
                .WithRequired(x => x.LoadType)
                .HasForeignKey(x => x.Type_FK)
                .WillCascadeOnDelete(false);
            HasMany(x => x.Queues1)
                .WithRequired(x => x.LoadType1)
                .HasForeignKey(x => x.Status_FK)
                .WillCascadeOnDelete(false);

        }
    }
}