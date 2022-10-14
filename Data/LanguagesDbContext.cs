using lecturesapi.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace lecturesapi.Data
{
    public class LanguagesDbContext : DbContext 


    {

        public LanguagesDbContext(DbContextOptions<LanguagesDbContext> options) : base(options)

        {

        }


            public DbSet <Language> languages { get; set; }
            public DbSet <Framework> frameworks { get; set; }

            public DbSet <Area> areas { get; set; } 







    }
    }

