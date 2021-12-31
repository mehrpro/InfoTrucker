using System.Data.Entity.ModelConfiguration;
using InfoTrucker.Entities;

namespace InfoTrucker.Configure
{
    public class SmsPanelConfigure : EntityTypeConfiguration<SmsConfigure>
    {
        public SmsPanelConfigure()
        {
            HasKey(x => x.ID);

        }
    }
}
