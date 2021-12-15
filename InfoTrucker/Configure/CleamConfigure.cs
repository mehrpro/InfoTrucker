using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using InfoTrucker.Entities;

namespace InfoTrucker.Configure
{
    public class CleamConfigure : EntityTypeConfiguration<Cleam>
    {
        public CleamConfigure()
        {
            HasKey(x => x.ID);
            Property(x => x.ID).IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.UserID_FK).IsRequired();
            Property(x => x.MenuItemID_FK).IsRequired();
            Property(x => x.GroupID_FK).IsRequired();
            Property(x => x.IsDelete).IsRequired();
        }
    }
}
