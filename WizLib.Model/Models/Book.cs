using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WizLib.Model.Models
{
    public class Book
    {
        [Key]
        public int Book_Id { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        [MaxLength(15)]
        public string ISBN { get; set; }

        [Required]
        public double Price { get; set; }


        //public Category category { get; set; } //this will create a foreingkey auto


        //this is another way
        [ForeignKey("BookDetail")] //reference to Table
        public int BookDetail_Id { get; set; }

        public BookDetail BookDetail { get; set; }//navigation propertys

        //one to many relatioship
        [ForeignKey("Publisher")]
        public int Publisher_Id { get; set; } // one to many
        public Publisher Publisher { get; set; } // one to many
        
        [NotMapped]
        public string PrinceRange { get; set; }

        public IList<BookAuthor> BookAuthors { get; set; } //many to many
    }
}
