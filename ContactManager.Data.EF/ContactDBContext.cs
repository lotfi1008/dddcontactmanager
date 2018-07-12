using ContactManager.Domain.Entites;
using Microsoft.EntityFrameworkCore;

namespace ContactManager.Data.EF
{
    public class ContactDBContext : DbContext
    {
        public ContactDBContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Person> Persons { get; set; }
        public DbSet<Contact> Contacts{ get; set; }
    }
}
