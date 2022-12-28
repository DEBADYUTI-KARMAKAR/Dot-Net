using ContactsAPI.Model;
using Microsoft.EntityFrameworkCore;

namespace ContactsAPI.Data
{
    public class ContactsAPIDBContext : DbContext
    {
        public ContactsAPIDBContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Contact> Contacts { get; set; }
        
    }
}
