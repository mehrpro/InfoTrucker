using System;
using System.Data.Entity;
using InfoTrucker.Entities;
using InfoTrucker.Models;
using InfoTrucker.Services;

namespace InfoTrucker.Infrastructure
{
    public interface IUnitofWork<TContext> : IDisposable where TContext : DbContext
    {
        IPersonRepository Person { get; }
        IPublicTypeRepository PublicType { get; }
        IApplicationUserRepository ApplicationUser { get; }
        IMenuGroupRepository MenuGroup { get; }
        IMenuItemRepository MenuItem { get; }
        ICleamRepository Cleam { get; }
        ISendMessageRepository SMS { get; }
        IMessageGroupSubjectRepository SmsSubject { get; }
        IExceptionSms ExceptionSms { get; }
        ISmsConfigureRepository SmsConfigure { get; }
        Person personU { get; }
        AppDbContext contextdb { get; }
        void Commit();
    }

    public class UnitofWork<TContext> : IUnitofWork<TContext> where TContext : DbContext, new()
    {
        private readonly DbContext db;
        private IPersonRepository _person;
        private IPublicTypeRepository _public;
        private ICleamRepository _cleam;
        private IApplicationUserRepository _applicationUser;
        private IMenuGroupRepository _menuGroup;
        private IMenuItemRepository _menuItem;
        private ISendMessageRepository _sms;
        private IMessageGroupSubjectRepository _smsSubject;
        private IExceptionSms _exceptionSms;
        private ISmsConfigureRepository _smsConfigure;
        private Person _personU;
        private AppDbContext _contextdb;
        public UnitofWork()
        {
            db = new TContext();
        }
        public void Commit()
        {
            db.SaveChanges();
        }

        public IPersonRepository Person => _person ?? (_person = new PersonRepository(db));
        public IPublicTypeRepository PublicType => _public ?? (_public = new PublicTypeRepository(db));
        public ICleamRepository Cleam => _cleam ?? (_cleam = new CleamRepository(db));
        public IApplicationUserRepository ApplicationUser => _applicationUser ?? (_applicationUser = new ApplicationUserRepository(db));
        public IMenuGroupRepository MenuGroup => _menuGroup ?? (_menuGroup = new MenuGroupRepository(db));
        public IMenuItemRepository MenuItem => _menuItem ?? (_menuItem = new MenuItemRepository(db));
        public ISendMessageRepository SMS => _sms ?? (_sms = new SendMessageRepository(db));
        public IMessageGroupSubjectRepository SmsSubject =>
            _smsSubject ?? (_smsSubject = new MessageGroupSubjectRepository(db));
        public IExceptionSms ExceptionSms => _exceptionSms ?? (_exceptionSms = new ExcptionSms(db));
        public ISmsConfigureRepository SmsConfigure => _smsConfigure ?? (_smsConfigure = new SmsConfigureRepository(db));
        public Person personU => _personU ?? (_personU = new Person());
        public AppDbContext contextdb => _contextdb ?? (_contextdb = new AppDbContext());

        #region Disposed
        private bool disposed = false;
        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    db.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }


        #endregion
    }
}