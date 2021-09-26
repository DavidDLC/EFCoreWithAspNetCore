using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WizLib.Model.Models
{
    public class BookDetail
    {
        //when you use Id name propery by default will be a key primary  and identity
        [Key]
        public int BookDetail_Id { get; set; }

        [Required]
        public int NumberOfChapters { get; set; }

        public int NumberOfPages { get; set; }

        public double weight { get; set; }

        public Book Book { get; set; }



    }
}
