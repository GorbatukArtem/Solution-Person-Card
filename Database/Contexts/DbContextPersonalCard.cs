using Database.Configurations;
using Database.Models;
using Database.Seeds;
using Microsoft.EntityFrameworkCore;

namespace Database.Contexts
{
    public class DbContextPersonalCard : DbContext
    {
        public DbContextPersonalCard() { }
        public DbContextPersonalCard(DbContextOptions<DbContextPersonalCard> options) : base(options) { }


        public virtual DbSet<Person> Persons { get; set; }
        public virtual DbSet<Gender> Genders { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseLazyLoadingProxies(false);

            // во время запуска тестов без этой проверки возникает ошибка 'Multiple database providers in service provider'  .
            // InMemory создает свою конфигурацию.
            if (!options.IsConfigured)
            {
                options.UseSqlServer(ConntectionStrings.GetDevelopmentConnectionString());
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //#region Configurations
            modelBuilder.ApplyConfiguration(new ConfigurationPerson());
            modelBuilder.ApplyConfiguration(new ConfigurationGender());
            //#endregion

            //#region Seeds
            modelBuilder.ApplyConfiguration(new SeedPerson());
            modelBuilder.ApplyConfiguration(new SeedGender());
            //#endregion
        }
    }
}