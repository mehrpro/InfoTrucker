﻿using System.Collections.Generic;
using InfoTrucker.Entities;

namespace InfoTrucker.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<InfoTrucker.Models.AppDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(InfoTrucker.Models.AppDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
            IList<ApplicationUser> defaultUsers = new List<ApplicationUser>();
            defaultUsers.Add(new ApplicationUser()
            {
                UserId = 1,
                Enabled = true,
                UserName = "admin",
                UserPassword = "admin",
                FullName = "مدیرسیستم",
                Editor = "Admin",
                LimetedCompany = false
            });
            context.ApplicationUsers.AddRange(defaultUsers);

            IList<MenuGroup> menuGroup = new List<MenuGroup>();
            menuGroup.Add(new MenuGroup() { GroupID = 1, MenuGroupTitle = "ribPageInfrasturcture", Description = "دارایی فیزیکی" });
            menuGroup.Add(new MenuGroup() { GroupID = 2, MenuGroupTitle = "ribPageMaintanace", Description = "نگهداری تعمیرات" });
            menuGroup.Add(new MenuGroup() { GroupID = 3, MenuGroupTitle = "ribPageReports", Description = "گزارشات" });
            menuGroup.Add(new MenuGroup() { GroupID = 4, MenuGroupTitle = "ribPageManage", Description = "مدیریت نرم افزار" });
            menuGroup.Add(new MenuGroup() { GroupID = 5, MenuGroupTitle = "ribSensor", Description = "شمارنده " });
            context.MenuGroups.AddRange(menuGroup);

            IList<MenuItem> menuItems = new List<MenuItem>();
            menuItems.Add(new MenuItem() { ItemID = 1, GroupID_FK = 1, ItemTitel = "PGMachinery", Description = "ماشین آلات" });
            menuItems.Add(new MenuItem() { ItemID = 2, GroupID_FK = 1, ItemTitel = "PGCoding", Description = "کدینگ موجودیت" });
            menuItems.Add(new MenuItem() { ItemID = 3, GroupID_FK = 2, ItemTitel = "PGRequestReapir", Description = "تعمیرگاه" });
            menuItems.Add(new MenuItem() { ItemID = 4, GroupID_FK = 3, ItemTitel = "PGReportRepair", Description = "گزارش تعمیر" });
            menuItems.Add(new MenuItem() { ItemID = 5, GroupID_FK = 4, ItemTitel = "PGUsers", Description = "مدیریت کاربران" });
            menuItems.Add(new MenuItem() { ItemID = 6, GroupID_FK = 5, ItemTitel = "PGSensor", Description = "مدیریت شمارنده" });
            context.MenuItems.AddRange(menuItems);

            IList<Cleam> cleams = new List<Cleam>();
            cleams.Add(new Cleam() { ID = 1, GroupID_FK = 1, IsDelete = false, UserID_FK = 1, MenuItemID_FK = 1 });
            cleams.Add(new Cleam() { ID = 2, GroupID_FK = 1, IsDelete = false, UserID_FK = 1, MenuItemID_FK = 2 });
            cleams.Add(new Cleam() { ID = 3, GroupID_FK = 2, IsDelete = false, UserID_FK = 1, MenuItemID_FK = 3 });
            cleams.Add(new Cleam() { ID = 4, GroupID_FK = 3, IsDelete = false, UserID_FK = 1, MenuItemID_FK = 4 });
            cleams.Add(new Cleam() { ID = 5, GroupID_FK = 4, IsDelete = false, UserID_FK = 1, MenuItemID_FK = 5 });
            cleams.Add(new Cleam() { ID = 6, GroupID_FK = 5, IsDelete = false, UserID_FK = 1, MenuItemID_FK = 6 });
            context.Cleams.AddRange(cleams);
        }
    }
}