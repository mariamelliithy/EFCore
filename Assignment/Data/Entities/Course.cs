using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Data.Entities
{
    internal class Course
    {
        public int Id { get; set; }
        public int Duration { get; set; }

        [StringLength(20, MinimumLength =5)]
        public string Name { get; set; }

        [StringLength(60)]
        public string Description { get; set; }

        public int Top_Id { get; set; }
    }
}
