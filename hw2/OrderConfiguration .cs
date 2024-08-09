using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw2
{
    
        internal class OrderConfiguration : IEntityTypeConfiguration<Order>
        {
            public void Configure(EntityTypeBuilder<Order> builder)
            {
                builder.HasKey(e => e.Id);

                builder.Property(e => e.Adress)
                       .IsRequired()
                       .HasMaxLength(200);

                builder.Property(e => e.createdAt)
                       .IsRequired();
            }
        }
    

}
