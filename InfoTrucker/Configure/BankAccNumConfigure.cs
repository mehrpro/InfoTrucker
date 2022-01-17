using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using InfoTrucker.Entities;

namespace InfoTrucker.Configure
{
    public class BankAccNumConfigure : EntityTypeConfiguration<BankAccNum>
    {
        public BankAccNumConfigure()
        {
            HasKey(x => x.ID);
            Property(x => x.ID).IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.FullName).HasMaxLength(150).IsRequired();
            Property(x => x.BankName).IsRequired().HasMaxLength(100);
            Property(x => x.AccNumber).HasMaxLength(15);
            Property(x => x.AccCart).HasMaxLength(19);
            Property(x => x.AccISBN).HasMaxLength(26);
            Property(x => x.Editor).HasMaxLength(150);
            Property(x => x.CenterID_FK).IsRequired();
        }
    }
}