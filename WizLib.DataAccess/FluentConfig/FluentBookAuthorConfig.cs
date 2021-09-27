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
    public class FluentBookAuthorConfig : IEntityTypeConfiguration<Fluent_BookAuthor>
    {
        public void Configure(EntityTypeBuilder<Fluent_BookAuthor> modelBuilder)
        {

            //many to many 
            

            modelBuilder
                .HasOne(x => x.Fluent_Book)
                .WithMany(x => x.Fluent_BookAuthors)
                .HasForeignKey(b => b.Book_Id);

            modelBuilder
                .HasOne(x => x.Fluent_Author)
                .WithMany(x => x.Fluent_BookAuthors)
                .HasForeignKey(b => b.Author_Id);
        }
    }
}
