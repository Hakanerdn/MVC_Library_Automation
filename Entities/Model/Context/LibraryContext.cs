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
        public LibraryContext():base()
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
    }
}
