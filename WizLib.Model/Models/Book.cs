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
        [ForeignKey("Category")] //reference to Table
        public int Category_Id { get; set; }

        public Category Category { get; set; }//navigation propertys

        [NotMapped]
        public string PrinceRange { get; set; }

    }
}
