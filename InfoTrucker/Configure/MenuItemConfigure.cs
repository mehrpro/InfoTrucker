using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using InfoTrucker.Entities;

namespace InfoTrucker.Configure
{
    public class MenuItemConfigure : EntityTypeConfiguration<MenuItem>
    {
        public MenuItemConfigure()
        {
            HasKey(x => x.ItemID);
            Property(x => x.ItemID).IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.GroupID_FK).IsRequired();
            Property(x => x.ItemTitel).HasMaxLength(150).IsRequired();
            Property(x => x.Description).IsRequired().HasMaxLength(250);
            HasMany(x => x.Cleams)
                .WithRequired(x => x.MenuItem)
                .HasForeignKey(x => x.MenuItemID_FK)
                .WillCascadeOnDelete(false);
        }
    }
}
