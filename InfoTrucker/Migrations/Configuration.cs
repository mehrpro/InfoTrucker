using System;
using System.Data.Entity.Migrations;
using System.Collections.Generic;
using InfoTrucker.Entities;

namespace InfoTrucker.Migrations
{


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
                UserName = "o2DUeeUN//chNK6u9APQdw==", //admin
                UserPassword = "r1iuHVzwh0BHzDa+rauWxg==", //Admin708801298
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

            IList<SmsConfigure> smsConfigures = new List<SmsConfigure>();
            smsConfigures.Add(new SmsConfigure()
            {
                ID = "aec60a14-946c-4428-9151-7e7dfca6b31e",
                Password = "bSkuzdmotZ/mpsw9SG0PXA==",
                Username = "yU6k4ImZAln1bwoUMOmwIA==",
                Sender = "6q/oN0NY6evOItSS30aZBw==",
                Price = 280,
            });
            context.SmsConfigures.AddRange(smsConfigures);

            IList<Person> person = new List<Person>();
            person.Add(new Person()
            {
                PersonID = 1220001,
                IsActive = true,
                IsDelete = false,
                DateRegister = DateTime.Now,
                Address = "کردستان بیجار سیمان کردستان اتحادیه صنفی رانندگان",
                CodeMelei = "3782428218",
                CodePosti = "6651848965",
                FatherName = "یدالله",
                FName = "فرشید",
                LName = "محمدی",
                Hoshmand = "123456789",
                Kamion = "اپل آسترا",
                MahelTavalod = "بیجار",
                Mobile1 = "09186620474",
                Mobile2 = "09186620474",
                SerialShenasnameh = "الف-12-123456",
                HoshmandNavgan = "123456789",
                Shenasnameh = "1354",
                Sh_Bimeh = "123456789",
                Sh_Plak = "ایران22ج33261",
                Sh_Goyahinameh = "123456789",
                Sh_Sokht = "123456789",
                Takalof = 2,
                Tavalod = DateTime.Now,
                Tel = "08738238022",
                UserID_FK = 1,
                ID = 1
            });
            context.People.AddRange(person);


            IList<ResultCodeMessage> resultCodeMessages = new List<ResultCodeMessage>();
            resultCodeMessages.Add(new ResultCodeMessage() { ID = 1, ResultCode = -1, ResultMessage = "خطاي ناشناخته دوباره تلاش نمایید" });
            resultCodeMessages.Add(new ResultCodeMessage() { ID = 2, ResultCode = -3, ResultMessage = "خطاي ناشناخته دوباره تلاش نمایید" });
            resultCodeMessages.Add(new ResultCodeMessage() { ID = 3, ResultCode = -5, ResultMessage = "متنی جهت ارسال وجود ندارد" });
            resultCodeMessages.Add(new ResultCodeMessage() { ID = 4, ResultCode = -6, ResultMessage = "تلفن همراه ناصحیح می باشد" });
            resultCodeMessages.Add(new ResultCodeMessage() { ID = 5, ResultCode = -8, ResultMessage = "نام کاربري و یا کلمه عبور نادرست می باشد" });
            resultCodeMessages.Add(new ResultCodeMessage() { ID = 6, ResultCode = -10, ResultMessage = "امکان ارسال از وب سرویس براي این کاربر وجود ندارد" });
            resultCodeMessages.Add(new ResultCodeMessage() { ID = 7, ResultCode = -11, ResultMessage = "عدم وجود شماره پیامک" });
            resultCodeMessages.Add(new ResultCodeMessage() { ID = 8, ResultCode = -12, ResultMessage = "تعداد درخواستی بیش از حد مجاز" });
            resultCodeMessages.Add(new ResultCodeMessage() { ID = 9, ResultCode = -13, ResultMessage = "ورودي نا معتبر" });
            resultCodeMessages.Add(new ResultCodeMessage() { ID = 10, ResultCode = -14, ResultMessage = "اعتبار کافی نمی باشد" });
            resultCodeMessages.Add(new ResultCodeMessage() { ID = 11, ResultCode = -15, ResultMessage = "ورودي نا معتبر" });
            resultCodeMessages.Add(new ResultCodeMessage() { ID = 12, ResultCode = -16, ResultMessage = "آرایه هاي ارسال پیام متناظر نمی باشد" });
            resultCodeMessages.Add(new ResultCodeMessage() { ID = 13, ResultCode = -17, ResultMessage = "تعداد ارسال پیامک بیشتر از حد مجاز می باشد" });
            resultCodeMessages.Add(new ResultCodeMessage() { ID = 14, ResultCode = -24, ResultMessage = "پیامی به سرور ارسال نشده است" });
            resultCodeMessages.Add(new ResultCodeMessage() { ID = 15, ResultCode = -30, ResultMessage = "کد صداي آرشیوي نادرست ارسال شده است" });
            resultCodeMessages.Add(new ResultCodeMessage() { ID = 16, ResultCode = -31, ResultMessage = "تلفن ورودي ناصحیح است" });
            resultCodeMessages.Add(new ResultCodeMessage() { ID = 17, ResultCode = -32, ResultMessage = "عنوان ارسال خالی است" });
            resultCodeMessages.Add(new ResultCodeMessage() { ID = 18, ResultCode = -33, ResultMessage = "چنین صوتی در آرشیو وجود ندارد" });
            resultCodeMessages.Add(new ResultCodeMessage() { ID = 19, ResultCode = -34, ResultMessage = "فرمت صداي آپلود شده ندرست می باشد" });
            resultCodeMessages.Add(new ResultCodeMessage() { ID = 20, ResultCode = -35, ResultMessage = "سایز فایل آپلود شده بیشتر از حد مجاز می باشد" });
            resultCodeMessages.Add(new ResultCodeMessage() { ID = 21, ResultCode = -36, ResultMessage = "خطاي ناشناخته در ورود اطلاعات" });
            resultCodeMessages.Add(new ResultCodeMessage() { ID = 22, ResultCode = -37, ResultMessage = "تعداد تلفنها بیشتر از حد مجاز ارسال گروهی می باشد" });
            resultCodeMessages.Add(new ResultCodeMessage() { ID = 23, ResultCode = -38, ResultMessage = "تعداد تلفنها براي دریافت دلیوري بیشتر از 100 عدد می باشد" });
            resultCodeMessages.Add(new ResultCodeMessage() { ID = 24, ResultCode = -39, ResultMessage = "چنین کدي وجود ندارد" });
            resultCodeMessages.Add(new ResultCodeMessage() { ID = 25, ResultCode = -40, ResultMessage = "پیام در صف ارسال می باشد" });
            resultCodeMessages.Add(new ResultCodeMessage() { ID = 26, ResultCode = -41, ResultMessage = "چنین شناسه اي وجود ندارد" });
            resultCodeMessages.Add(new ResultCodeMessage() { ID = 27, ResultCode = -42, ResultMessage = "موبایل وجود ندارد" });
            resultCodeMessages.Add(new ResultCodeMessage() { ID = 28, ResultCode = -43, ResultMessage = "پیامی براي دریافت وجود ندارد" });
            resultCodeMessages.Add(new ResultCodeMessage() { ID = 29, ResultCode = -44, ResultMessage = "خطا در کد الگوي صدا" });
            resultCodeMessages.Add(new ResultCodeMessage() { ID = 30, ResultCode = -45, ResultMessage = "خطا در الگوي سایت الگو دوبار ست شود" });
            resultCodeMessages.Add(new ResultCodeMessage() { ID = 31, ResultCode = -46, ResultMessage = "خطا در ارسال متغیر شماره" });
            resultCodeMessages.Add(new ResultCodeMessage() { ID = 32, ResultCode = -47, ResultMessage = "خطا در ارسال تعداد متغیر ها - کمتر از میزان لازم است" });
            resultCodeMessages.Add(new ResultCodeMessage() { ID = 33, ResultCode = -48, ResultMessage = "فرمت تاریخ صحیح نمی باشد" });
            resultCodeMessages.Add(new ResultCodeMessage() { ID = 34, ResultCode = -49, ResultMessage = "فرمت ساعت ارسالی اشتباه است" });
            resultCodeMessages.Add(new ResultCodeMessage() { ID = 35, ResultCode = 1, ResultMessage = "رسیده به گوشی" });
            resultCodeMessages.Add(new ResultCodeMessage() { ID = 36, ResultCode = 2, ResultMessage = "نرسیده به گوشی" });
            resultCodeMessages.Add(new ResultCodeMessage() { ID = 37, ResultCode = 5, ResultMessage = "هنوز دلیوري بر نگشته است" });
            resultCodeMessages.Add(new ResultCodeMessage() { ID = 38, ResultCode = 9, ResultMessage = "هنوز دلیوري بر نگشته است و یا کد اشتباه می باشد" });
            context.ResultCodeMessages.AddRange(resultCodeMessages);

        }
    }
}
