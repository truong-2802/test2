using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace test2.Entities
{
    [Table("Department_Tbl")]
    public class Department_Tbl
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Department_name { get; set; }
        [Required]
        public string Department_code { get; set; }
        [Required]
        public string Location { get; set; }
        [Required]
        public double Number_of { get; set; }

        [Required]
        public string Personals { get; set; }

        public string Employee_TblId { get; set; }

        [ForeignKey("Employee_TblId")]
        public Employee_Tbl Employee_Tbl { get; set; }

    }
}
