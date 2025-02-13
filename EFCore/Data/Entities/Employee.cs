using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore.Data.Entities
{
    //EF core supports 4 ways to mapping from classes [entities] to table/view
    //1] By Conviention [Default behaviour]
        // Public numeric property Id, EmployeeId ==> pk, Identity (1,1)
        //string
            //nvarchar(max)
            //.NET 6 ==> Reference type string : [Required]
            //       ==>                string? : [Optinal]
    //2] By Data annotation [Attributes]
    internal class Employee
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int EmpId {  get; set; }

        [StringLength(50, MinimumLength = 5)]
        public string EmpName { get; set; }

        //[Column(TypeName ="Money")]
        [Column(TypeName ="decimal(18.3)")]
        //[DataType(DataType.Currency)]
        public decimal Salary { get; set; }

        [Range(20,60)]
        public int? Age { get; set; }

        [Phone] 
        public string PhoneNumber { get; set; }

        //[DataType(DataType.EmailAddress)]
        [EmailAddress]
        public string Email { get; set; }

        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        public string Address { get; set; }
    }
}
