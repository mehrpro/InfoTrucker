using System.Data.Entity;
using InfoTrucker.Configure;
using InfoTrucker.Entities;

namespace InfoTrucker.Models
{
    public class AppDbContext : DbContext
    {

        public AppDbContext() : base("cn")
        {

            //Database.SetInitializer(new InitialDatabase());        

        }

        protected override void OnModelCreating(DbModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Configurations.Add(new ApplicationUserConfigure());
            builder.Configurations.Add(new CleamConfigure());
            builder.Configurations.Add(new MenuGroupConfigure());
            builder.Configurations.Add(new MenuItemConfigure());
            builder.Configurations.Add(new PublicTypeConfigure());
            builder.Configurations.Add(new PersonConfigure());
            builder.Configurations.Add(new SendMessageConfigure());
            builder.Configurations.Add(new ResultCodeMessageConfigure());
        }



        public virtual IDbSet<ApplicationUser> ApplicationUsers { get; set; }
        public virtual IDbSet<Person> People { get; set; }
        public virtual IDbSet<MenuGroup> MenuGroups { get; set; }
        public virtual IDbSet<MenuItem> MenuItems { get; set; }
        public virtual IDbSet<Cleam> Cleams { get; set; }
        public virtual IDbSet<PublicType> PublicTypes { get; set; }
        public virtual IDbSet<SendMessages> SendMessages { get; set; }
        public virtual IDbSet<ResultCodeMessage> ResultCodeMessages { get; set; }
    }
}
