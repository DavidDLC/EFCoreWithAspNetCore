using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WizLib.Model.Models
{
    public class Author
    {
        [Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)] // this is by default
        //[DatabaseGenerated(DatabaseGeneratedOption.None)] // the DB does not generate value 
        //[DatabaseGenerated(DatabaseGeneratedOption.Computed)] // this row is genrated when data is inserted on DB

        public int Author_Id { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        public DateTime BirthDate { get; set; }

        public string Location { get; set; }

        [NotMapped]
        public string FullName
        {
            get
            {
                return $"{FirstName} {LastName}";
            }

        }
    }
}
