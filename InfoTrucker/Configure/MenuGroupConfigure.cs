using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using InfoTrucker.Entities;

namespace InfoTrucker.Configure
{
    public class MenuGroupConfigure : EntityTypeConfiguration<MenuGroup>
    {
        public MenuGroupConfigure()
        {
            HasKey(x => x.GroupID);
            Property(x => x.GroupID).IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.MenuGroupTitle).IsRequired().HasMaxLength(100);
            Property(x => x.Description).IsRequired().HasMaxLength(250);
            HasMany(x => x.MenuItems)
                .WithRequired(x => x.MenuGroup)
                .HasForeignKey(x => x.GroupID_FK)
                .WillCascadeOnDelete(false);
            HasMany(x => x.Cleams)
                .WithRequired(x => x.MenuGroup)
                .HasForeignKey(x => x.GroupID_FK)
                .WillCascadeOnDelete(false);
        }
    }
}
