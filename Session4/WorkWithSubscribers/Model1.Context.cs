﻿//------------------------------------------------------------------------------
// <auto-generated>
//    Этот код был создан из шаблона.
//
//    Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//    Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WorkWithSubscribers
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class TeleconNevaEntities : DbContext
    {
        static public TeleconNevaEntities _context;

        public TeleconNevaEntities()
            : base("name=TeleconNevaEntities")
        {
        }

        static public TeleconNevaEntities GetContext()
        {
            if (_context == null)
                _context = new TeleconNevaEntities();
            return _context;
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<Highway> Highways { get; set; }
        public DbSet<Sub> Subs { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Access_Networks> Access_Networks { get; set; }
        public DbSet<Application> Applications { get; set; }
        public DbSet<Suds_Equipment> Suds_Equipment { get; set; }
    }
}
