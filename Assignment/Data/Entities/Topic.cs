using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Data.Entities
{
    internal class Topic
    {
        public int Id { get; set; }

        [StringLength(50, MinimumLength = 5)]
        public string Name { get; set; }
    }
}
