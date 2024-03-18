using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApi.Domain.Entities;

namespace WebApi.Persistence.Configurations
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            Category category01 = new()
            {
                Id = 1,
                Name = "Elektronik",
                Priorty = 1,
                ParentId = 0,
                CreatedDate = DateTime.Now,
                IsDeleted = false,
            };
            Category category02 = new()
            {
                Id = 2,
                Name = "Moda",
                Priorty = 2,
                ParentId = 0,
                CreatedDate = DateTime.Now,
                IsDeleted = false,
            };

            Category parent01 = new()
            {
                Id = 3,
                Name = "Bilgisayar",
                Priorty = 1,
                ParentId = 1,
                CreatedDate = DateTime.Now,
                IsDeleted = false,
            };
            Category parent02 = new()
            {
                Id = 4,
                Name = "Kadın",
                Priorty = 1,
                ParentId = 2,
                CreatedDate = DateTime.Now,
                IsDeleted = false,
            };

            builder.HasData(category01, category02, parent01, parent02);

        }
    }
}
