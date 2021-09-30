namespace WebApi
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ContactContext : DbContext
    {
        public ContactContext()
            : base("name=ContactModel")
        {
        }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
        public DbSet<Contact> Contacts { get; set; }

    }
}
