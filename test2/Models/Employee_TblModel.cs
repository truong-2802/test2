using System;
using System.ComponentModel.DataAnnotations;
namespace test2.Models
{
    public class Employee_TblModel
    {
        public int Id { get; set; }
        public string Employee_name { get; set; }
        public string Employee_code { get; set; }
        public string Department { get; set; }
        public string Rank { get; set; }
    }
}
