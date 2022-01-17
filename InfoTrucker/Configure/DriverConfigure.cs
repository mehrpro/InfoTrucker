using System.Data.Entity.ModelConfiguration;
using InfoTrucker.Entities;

namespace InfoTrucker.Configure
{
    public class DriverConfigure : EntityTypeConfiguration<Driver>
    {
        public DriverConfigure()
        {
            HasKey(x => x.DriverID);
            Property(x => x.DriverID).IsRequired();
            Property(x => x.FirstName).HasMaxLength(50).IsRequired();
            Property(x => x.LastName).IsRequired().HasMaxLength(50);
            Property(x => x.PhoneNumber).HasMaxLength(10);
            Property(x => x.SmartCart).IsRequired();
            Property(x => x.Tag).IsRequired().HasMaxLength(15);
            Property(x => x.TagNumber).IsRequired().HasMaxLength(15);
            Property(x => x.GroupID).IsRequired();
            Property(x => x.userID_FK).IsRequired();
            Property(x => x.CenterID_FK).IsRequired();
            HasMany(x => x.Queues)
                .WithRequired(x => x.Driver)
                .HasForeignKey(x => x.DriverID_FK)
                .WillCascadeOnDelete(false);


        }
    }
}