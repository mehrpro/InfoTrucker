using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using InfoTrucker.Entities;

namespace InfoTrucker.Configure
{
    public class PhoneBookConfigure : EntityTypeConfiguration<PhoneBook>
    {
        public PhoneBookConfigure()
        {
            HasKey(x => x.ID);
            Property(x => x.ID).IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.Fname).HasMaxLength(50).IsRequired();
            Property(x => x.LName).HasMaxLength(50).IsRequired();
            Property(x => x.Mobile).IsRequired().HasMaxLength(10);
            Property(x => x.Mobile2).HasMaxLength(10);
            Property(x => x.Phone).HasMaxLength(10);
            Property(x => x.Addres).HasMaxLength(150);
            Property(x => x.postalCode).HasMaxLength(10);
            Property(x => x.Jobs).HasMaxLength(50).IsRequired();
            Property(x => x.Description).HasMaxLength(150);

        }
    }
}