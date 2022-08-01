using Datasource.Ef.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Datasource.Ef.Seeds
{
    public class SeedPerson : IEntityTypeConfiguration<Person>
    {
        public void Configure(EntityTypeBuilder<Person> builder)
        {
            builder.HasData(new Person
            {
                Id = 1,
                LastName = "Романов",
                FirstName = "Михаил",
                MiddleName = "Федорович",
                Birth = new DateTime(1596, 12, 07),
                Death = new DateTime(1645, 07, 13),
                GenderId = 1
            });

            builder.HasData(new Person
            {
                Id = 2,
                LastName = "Романов",
                FirstName = "Алексей",
                MiddleName = "Михайлович",
                Birth = new DateTime(1629, 03, 19),
                Death = new DateTime(1676, 02, 08),
                GenderId = 1
            });

        }
    }
}