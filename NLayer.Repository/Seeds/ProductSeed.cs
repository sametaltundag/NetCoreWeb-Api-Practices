﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NLayer.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Repository.Seeds
{
    internal class ProductSeed : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData(
                new Product {
                    Id = 1,
                    Name = "Kalem 1",
                    CategoryId = 1,
                    Price = 100,
                    Stock=20,
                    CreatedDate = DateTime.Now},
                new Product
                {
                    Id=2,
                    Name = "Kitap 2",
                    CategoryId = 2,
                    Price = 200,
                    Stock = 50,
                    CreatedDate = DateTime.Now
                },
                new Product
                {
                    Id = 3,
                    Name = "Defter 1",
                    CategoryId = 3,
                    Price = 500,
                    Stock = 10,
                    CreatedDate = DateTime.Now
                }
                );
        }
    }
}
