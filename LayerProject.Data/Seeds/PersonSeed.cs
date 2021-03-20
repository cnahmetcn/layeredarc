using LayerProject.Core.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LayerProject.Data.Seeds
{
    public class PersonSeed : IEntityTypeConfiguration<Person>
    {
        public void Configure(EntityTypeBuilder<Person> builder)
        {
            builder.HasData(
                new Person { Id = 1, Name="Ahmet", Surname="Can" },
                new Person { Id = 2, Name="Adem", Surname="Can" },
                new Person { Id = 3, Name="İbrahim", Surname="Can" },
                new Person { Id = 4, Name="Nazife", Surname="Can" },
                new Person { Id = 5, Name="Melike", Surname="Can" },
                new Person { Id = 6, Name="Kübra", Surname="Şimşek" }
                );
        }
    }
}
