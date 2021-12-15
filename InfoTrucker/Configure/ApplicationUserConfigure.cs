using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using InfoTrucker.Entities;

namespace InfoTrucker.Configure
{
    public class ApplicationUserConfigure : EntityTypeConfiguration<ApplicationUser>
    {


        public ApplicationUserConfigure()
        {
            HasKey(x => x.UserId);
            Property(x => x.UserId).IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.UserName).IsRequired().HasMaxLength(20);
            Property(x => x.UserPassword).IsRequired().HasMaxLength(100);
            Property(x => x.FullName).IsRequired().HasMaxLength(200);
            Property(x => x.LimetedCompany).IsRequired();
            Property(x => x.Editor).IsRequired().HasMaxLength(10);
            HasMany(x => x.Cleams)
                .WithRequired(x => x.ApplicationUser)
                .HasForeignKey(x => x.UserID_FK)
                .WillCascadeOnDelete(false);
            HasMany(x => x.Persons)
                .WithRequired(x => x.ApplicationUser)
                .HasForeignKey(x => x.UserID_FK)
                .WillCascadeOnDelete(false);
        }
    }
}
