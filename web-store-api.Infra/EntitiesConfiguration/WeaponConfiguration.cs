using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using web_store_api.Domain.Entities;

namespace web_store_api.Infra.EntitiesConfiguration
{
    public class WeaponConfiguration : IEntityTypeConfiguration<Weapon>
    {
        public void Configure(EntityTypeBuilder<Weapon> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name).HasMaxLength(75).IsRequired();
            builder.Property(x => x.Caliber).IsRequired();
            builder.Property(x => x.Brand).IsRequired();
            builder.Property(x => x.Capacity).IsRequired();
            builder.Property(x => x.Type).IsRequired();
            builder.Property(x => x.Year).IsRequired();
            builder.Property(x => x.IsIlegal).HasDefaultValue(false);
        }
    }
}
