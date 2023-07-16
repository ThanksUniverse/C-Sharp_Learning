using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityFramework.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EntityFramework.Data.Mappings
{
    internal class TagMap : IEntityTypeConfiguration<Tag>
    {
        public void Configure(EntityTypeBuilder<Tag> builder)
        {
            builder.ToTable("Tag");

            //Primary Key
            builder.HasKey(x => x.Id);

            // Identity
            builder.Property(x => x.Id)
                .ValueGeneratedOnAdd()
                .UseIdentityColumn(); // Identity (1,1)

            // Property
            builder.Property(x => x.Name)
                .IsRequired() // Not null
                .HasColumnName("Name")
                .HasColumnType("nvarchar")
                .HasMaxLength(80);

            builder.Property(x => x.Slug)
                .IsRequired() // Not null
                .HasColumnName("Slug")
                .HasColumnType("varchar")
                .HasMaxLength(80);

            // Indices
            builder.HasIndex(x => x.Slug, "IX_Tag_Slug") // Create a new index for us to search
                .IsUnique(); // Set this index as unique
        }
    }
}
