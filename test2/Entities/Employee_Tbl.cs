using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace test2.Entities
{
    [Table("Employee_Tbl")]
    public class Employee_Tbl
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Employee_name { get; set; }
        [Required]
        public string Employee_code { get; set; }
        [Required]
        public string Department { get; set; }
        [Required]
        public string Rank { get; set; }

    }
}
