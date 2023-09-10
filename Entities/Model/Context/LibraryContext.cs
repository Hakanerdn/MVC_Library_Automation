using Entities.Mapping;
using Entities.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Model.Context
{
    public class LibraryContext : DbContext
    {
        public LibraryContext():base("Library")
        {
            
        }
        public DbSet<About> About { get; set; }
        public DbSet<Book> Book { get; set; }
        public DbSet<BookMovement> BookMovement { get; set; }
        public DbSet<BookRecordMovement> BookRecordMovement { get; set; }
        public DbSet<BookType> BookType { get; set; }
        public DbSet<Communication> Communication { get; set; }
        public DbSet<Member> Member { get; set; }
        public DbSet<Notice> Notice { get; set; }
        public DbSet<RoleGuide> RoleGuide { get; set; }
        public DbSet<SafetyBook> SafetyBook { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<UserMovement> UserMovement { get; set; }
        public DbSet<UserRole> UserRole { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new NoticeMap());
            modelBuilder.Configurations.Add(new SafetyBookMap());
            modelBuilder.Configurations.Add(new AboutMap());
            modelBuilder.Configurations.Add(new CommunicationMap());
            modelBuilder.Configurations.Add(new BookMovementMap());
            modelBuilder.Configurations.Add(new BookRecordMovementMap());
            modelBuilder.Configurations.Add(new BookMap());
            modelBuilder.Configurations.Add(new BookTypeMap());
            modelBuilder.Configurations.Add(new UserMovementMap());
            modelBuilder.Configurations.Add(new UserMap());
            modelBuilder.Configurations.Add(new UserRoleMap());
            modelBuilder.Configurations.Add(new RoleGuideMap());
            modelBuilder.Configurations.Add(new MemberMap());
            base.OnModelCreating(modelBuilder);
        }
    }
}
