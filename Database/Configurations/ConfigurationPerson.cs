using Database.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Database.Configurations
{
    internal class ConfigurationPerson : IEntityTypeConfiguration<Person>
    {
        public void Configure(EntityTypeBuilder<Person> builder)
        {
            builder.ToTable("Persons", "dbo");

            builder.HasKey(p => p.Id);

            builder.Property(p => p.Id)
                .ValueGeneratedOnAdd();

            builder.Property(p => p.FirstName)
                .IsRequired()
                .HasMaxLength(200);

            builder.Property(p => p.LastName)
                .IsRequired(false)
                .HasMaxLength(200);

            builder.Property(p => p.MiddleName)
                .IsRequired(false)
                .HasMaxLength(200);

            builder.Property(p => p.Birth)
                .HasColumnType("date")
                .IsRequired(false);

            builder.Property(p => p.Death)
                .HasColumnType("date")
                .IsRequired(false);

            builder.HasOne(p => p.Gender)
                .WithMany(p => p.Persons)
                .HasForeignKey(p => p.GenderId)
                .IsRequired(false)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}