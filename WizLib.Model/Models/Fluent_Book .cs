using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WizLib.Model.Models
{
    public class Fluent_Book
    {
        
        public int Book_Id { get; set; }

        
        public string Title { get; set; }

        public string ISBN { get; set; }

        public double Price { get; set; }
        
        
        public string PrinceRange { get; set; }

        public int BookDetail_Id { get; set; }

        public Fluent_BookDetail Fluent_BookDetail { get; set; }//navigation propertys

        public int Publisher_Id { get; set; }

        public Fluent_Publisher Fluent_Publisher { get; set; }//navigation propertys
        

        public ICollection<Fluent_BookAuthor> Fluent_BookAuthors { get; set; }//navigation propertys


    }
}
