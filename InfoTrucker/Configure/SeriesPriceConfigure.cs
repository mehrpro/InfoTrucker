using System.Data.Entity.ModelConfiguration;
using InfoTrucker.Entities;

namespace InfoTrucker.Configure
{
    public class SeriesPriceConfigure : EntityTypeConfiguration<SeriesPrice>
    {
        public SeriesPriceConfigure()
        {
            HasKey(x => x.SereisID);
            Property(x => x.SereisID).IsRequired();
            Property(x => x.SeriesName).IsRequired();
            Property(x => x.SeriesDateStart).IsRequired().HasColumnType("datetime");
            HasMany(x => x.Queues)
                .WithRequired(x => x.SeriesPrice)
                .HasForeignKey(x => x.SeriesID_FK)
                .WillCascadeOnDelete(false);
            HasMany(x => x.Cashes)
                .WithRequired(x => x.SeriesPrice)
                .HasForeignKey(x => x.seriesID_FK)
                .WillCascadeOnDelete(false);
        }
    }
}