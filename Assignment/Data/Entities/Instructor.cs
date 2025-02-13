using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Data.Entities
{
    internal class Instructor
    {
        public int Id { get; set; }

        [StringLength(50, MinimumLength = 5)]
        public string Name { get; set; }
        public int Bouns { get; set; }

        [DataType(DataType.Currency)]
        public int Salary { get; set; }
        public string Address { get; set; }
        public int HourRate { get; set; }
        public int Dept_Id { get; set; }
    }
}
