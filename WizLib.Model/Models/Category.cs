using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WizLib.Model.Models
{
    public class Category
    {
        //when you use Id name propery by default will be a key primary  and identity
        [Key]
        public int Category_Id { get; set; }

        public string Name { get; set; }

    }
}
