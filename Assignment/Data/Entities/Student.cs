using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Data.Entities
{
    internal class Student
    {
        public int Id { get; set; }

        [StringLength(20, MinimumLength = 5)]
        public string FName { get; set; }  
        
        [StringLength(20, MinimumLength = 5)]
        public string LName { get; set; }    

        public string? Address { get; set; }

        [Range(20, 60)]
        public int Age { get; set; }

        public int Dep_Id { get; set; }
    }
}
