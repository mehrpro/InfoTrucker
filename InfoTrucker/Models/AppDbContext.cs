﻿using System.Data.Entity;
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
        }



        public virtual DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public virtual DbSet<Person> People { get; set; }
        public virtual DbSet<MenuGroup> MenuGroups { get; set; }
        public virtual DbSet<MenuItem> MenuItems { get; set; }
        public virtual DbSet<Cleam> Cleams { get; set; }
        public virtual DbSet<PublicType> PublicTypes { get; set; }
    }
}
