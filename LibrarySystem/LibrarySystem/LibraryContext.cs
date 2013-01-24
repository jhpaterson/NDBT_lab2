using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;
using LibrarySystem.Domain;

namespace LibrarySystem
{
    public class LibraryContext : DbContext
    {
        public DbSet<Title> Titles { get; set; }
    }
}
