using System.Data.Entity;
using System.Threading;
using System.Threading.Tasks;
using InfoTrucker.Configure;
using InfoTrucker.Entities;
using InfoTrucker.Infrastructure;

namespace InfoTrucker.Models
{
    public class AppDbContext : DbContext, IUnitofWork
    {

        public AppDbContext() : base("cn")
        {

            //Database.SetInitializer(new InitialDatabase());        

        }

        #region IUnitOfWork Members
        public new IDbSet<TEntity> Set<TEntity>() where TEntity : class
        {
            return base.Set<TEntity>();
        }
        #endregion


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
            builder.Configurations.Add(new MessageGroupSubjectConfigure());
            builder.Configurations.Add(new SmsPanelConfigure());
            builder.Configurations.Add(new CachConfigure());
            builder.Configurations.Add(new CenterConfigure());
            builder.Configurations.Add(new CommissionConfigure());
            builder.Configurations.Add(new DriverConfigure());
            builder.Configurations.Add(new LoadTypeConfigure());
            builder.Configurations.Add(new PhoneBookConfigure());
            builder.Configurations.Add(new QueueConfigure());
            builder.Configurations.Add(new UserConfigure());
            builder.Configurations.Add(new SeriesPriceConfigure());
            builder.Configurations.Add(new BankAccNumConfigure());

        }



        public virtual DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public virtual DbSet<Person> People { get; set; }
        public virtual DbSet<MenuGroup> MenuGroups { get; set; }
        public virtual DbSet<MenuItem> MenuItems { get; set; }
        public virtual DbSet<Cleam> Cleams { get; set; }
        public virtual DbSet<PublicType> PublicTypes { get; set; }
        public virtual DbSet<SendMessages> SendMessages { get; set; }
        public virtual DbSet<ResultCodeMessage> ResultCodeMessages { get; set; }
        public virtual DbSet<MessageGroupSubject> MessageGroupSubjects { get; set; }
        public virtual DbSet<SmsConfigure> SmsConfigures { get; set; }
        public virtual DbSet<Cash> Cash { get; set; }
        public virtual DbSet<Center> Centers { get; set; }
        public virtual DbSet<Commission> Commissions { get; set; }
        public virtual DbSet<Driver> Drivers { get; set; }
        public virtual DbSet<LoadType> LoadTypes { get; set; }
        public virtual DbSet<PhoneBook> PhoneBooks { get; set; }
        public virtual DbSet<Queue> Queues { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<SeriesPrice> SeriesPrices { get; set; }
        public virtual DbSet<BankAccNum> BankAccNums { get; set; }




    }
}
