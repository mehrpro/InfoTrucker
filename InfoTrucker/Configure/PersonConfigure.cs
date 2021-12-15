using System.Data.Entity.ModelConfiguration;
using InfoTrucker.Entities;

namespace InfoTrucker.Configure
{
    public class PersonConfigure : EntityTypeConfiguration<Person>
    {
        public PersonConfigure()
        {
            HasKey(x => x.PersonID);
            Property(x => x.Address).IsRequired().HasMaxLength(250);
            Property(x => x.CodeMelei).IsRequired().HasMaxLength(11).IsMaxLength();
            Property(x => x.CodePosti).HasMaxLength(10).IsFixedLength();
            Property(x => x.DateRegister).HasColumnType("datetime");
            Property(x => x.FName).IsRequired().HasMaxLength(150);
            Property(x => x.LName).IsRequired().HasMaxLength(250);
            Property(x => x.FatherName).HasMaxLength(100);
            Property(x => x.IsActive).IsRequired();
            Property(x => x.IsDelete).IsRequired();
            Property(x => x.Hoshmand).HasMaxLength(20);
            Property(x => x.HoshmandNavgan).HasMaxLength(20);
            Property(x => x.Kamion).HasMaxLength(10);
            Property(x => x.Mobile1).HasMaxLength(11);
            Property(x => x.Mobile2).HasMaxLength(11);
            Property(x => x.Tel).HasMaxLength(11);
            Property(x => x.Shenasnameh).HasMaxLength(11);
            Property(x => x.Sh_Bimeh).HasMaxLength(20);
            Property(x => x.Sh_Goyahinameh).HasMaxLength(20);
            Property(x => x.Sh_Plak).HasMaxLength(10);
            Property(x => x.Sh_Sokht).HasMaxLength(20);
            Property(x => x.SerialShenasnameh).HasMaxLength(15);
            Property(x => x.MahelTavalod).HasMaxLength(100);
            Property(x => x.Tavalod).HasColumnType("datetime").IsRequired();
            Property(x => x.UserID_FK).IsRequired();
        }

    }
}