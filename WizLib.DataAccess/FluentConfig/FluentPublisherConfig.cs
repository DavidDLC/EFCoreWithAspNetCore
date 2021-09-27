using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WizLib.Model.Models;

namespace WizLib.DataAccess.FluentConfig
{
    public class FluentPublisherConfig : IEntityTypeConfiguration<Fluent_Publisher>
    {
        public void Configure(EntityTypeBuilder<Fluent_Publisher> modelBuilder)
        {
            //publisher
            modelBuilder.HasKey(x => x.Publisher_Id);
            modelBuilder.Property(x => x.Name).IsRequired();
            modelBuilder.Property(x => x.Location).IsRequired();
        }
    }
}
