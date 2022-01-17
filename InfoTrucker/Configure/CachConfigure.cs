using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using InfoTrucker.Entities;

namespace InfoTrucker.Configure
{
    public class CachConfigure : EntityTypeConfiguration<Cash>
    {
        public CachConfigure()
        {
            HasKey(x => x.CashID);
            Property(x => x.CashID).IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.CenterID_FK).IsRequired();
        }
    }
}
