﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NLayer.Core.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Repository.Configurations.Seeds
{
    internal class ProductSeed : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData(new Product
            {
                Id = 1,
                CategoryId = 1,
                Name = "Kalem1",
                Price = 100,
                Stock = 20,
                CreatedDate = DateTime.Now
            }, 
            new Product
            {
                Id = 2,
                CategoryId = 1,
                Name = "Kalem2",
                Price = 200,
                Stock = 30,
                CreatedDate = DateTime.Now
            }, 
            new Product
            {
                Id = 3,
                CategoryId = 1,
                Name = "Kalem3",
                Price = 600,
                Stock = 60,
                CreatedDate = DateTime.Now
            },
            new Product
            {
                Id = 4,
                CategoryId = 2,
                Name = "Kitap1",
                Price = 600,
                Stock = 60,
                CreatedDate = DateTime.Now
            },
            new Product
            {
                Id = 5,
                CategoryId = 2,
                Name = "Kitap1",
                Price = 6040,
                Stock = 30,
                CreatedDate = DateTime.Now
            },
            new Product
            {
                Id = 6,
                CategoryId = 2,
                Name = "Kitap5",
                Price = 35000,
                Stock = 20,
                CreatedDate = DateTime.Now
            }

            );
        }
    }
}
