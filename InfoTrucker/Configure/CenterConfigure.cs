using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using InfoTrucker.Entities;

namespace InfoTrucker.Configure
{
    public class CenterConfigure : EntityTypeConfiguration<Center>
    {
        public CenterConfigure()
        {
            HasKey(x => x.ID);
            Property(x => x.ID).IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.CenterTitle).HasMaxLength(300).IsRequired();
            Property(x => x.Description).HasMaxLength(300);
            Property(x => x.TokenKey).HasMaxLength(450).IsRequired();
            HasMany(x => x.Cashes)
                .WithRequired(x => x.Center)
                .HasForeignKey(x => x.CenterID_FK)
                .WillCascadeOnDelete(false);
            HasMany(x => x.Commissions)
                .WithRequired(x => x.Center)
                .HasForeignKey(x => x.CenterID_FK)
                .WillCascadeOnDelete(false);
            HasMany(x => x.Drivers)
                .WithRequired(x => x.Center)
                .HasForeignKey(x => x.CenterID_FK)
                .WillCascadeOnDelete(false);
            HasMany(x => x.PhoneBooks)
                .WithRequired(x => x.Center)
                .HasForeignKey(x => x.CenterID_FK)
                .WillCascadeOnDelete(false);
            HasMany(x => x.Queues)
                .WithRequired(x => x.Center)
                .HasForeignKey(x => x.CenterID_FK)
                .WillCascadeOnDelete(false);
            HasMany(x => x.SeriesPrices)
                .WithRequired(x => x.Center)
                .HasForeignKey(x => x.CenterID_FK)
                .WillCascadeOnDelete(false);
            HasMany(x => x.Users)
                .WithRequired(x => x.Center)
                .HasForeignKey(x => x.CenterID_FK)
                .WillCascadeOnDelete(false);
            HasMany(x => x.BankAccNums)
                .WithRequired(x => x.Center)
                .HasForeignKey(x => x.CenterID_FK)
                .WillCascadeOnDelete(false);
        }
    }
}
