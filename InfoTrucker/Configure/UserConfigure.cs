using System.Data.Entity.ModelConfiguration;
using InfoTrucker.Entities;

namespace InfoTrucker.Configure
{
    public class UserConfigure : EntityTypeConfiguration<User>
    {
        public UserConfigure()
        {
            HasKey(x => x.userID);
            Property(x => x.FirstName).HasMaxLength(50);
            Property(x => x.LastName).HasMaxLength(50);
            Property(x => x.Phone).HasMaxLength(10);
            Property(x => x.Roul).HasMaxLength(10);
            Property(x => x.username).HasMaxLength(240).IsRequired();
            Property(x => x.password).HasMaxLength(240).IsRequired();
            Property(x => x.CenterID_FK).IsRequired();
            HasMany(x => x.Cashes)
                .WithRequired(x => x.User)
                .HasForeignKey(x => x.userID)
                .WillCascadeOnDelete(false);
            HasMany(x => x.Drivers)
                .WithRequired(x => x.User)
                .HasForeignKey(x => x.userID_FK)
                .WillCascadeOnDelete(false);
            HasMany(x => x.SeriesPrices)
                .WithRequired(x => x.User)
                .HasForeignKey(x => x.userCreator)
                .WillCascadeOnDelete(false);

        }
    }
}