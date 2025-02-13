using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Data.Entities
{
    internal class Department
    {
        public int Id { get; set; }
        [StringLength(50, MinimumLength = 5)]
        public string Name { get; set; }

        [DataType(DataType.Date)]
        public int HiringDate { get; set; }

        public int Ins_Id { get; set; }
    }
}
