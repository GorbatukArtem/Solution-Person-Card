﻿using Database.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Database.Seeds
{
    public class SeedGender : IEntityTypeConfiguration<Gender>
    {
        public void Configure(EntityTypeBuilder<Gender> builder)
        {
            builder.HasData(new Gender
            {
                Id = 1,
                Name = "Man"
            });
            builder.HasData(new Gender
            {
                Id = 2,
                Name = "Woman"
            });
        }
    }
}