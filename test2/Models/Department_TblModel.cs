using System;
using System.ComponentModel.DataAnnotations;
namespace test2.Models
{
    public class Department_TblModel
    {
        public int Id { get; set; }
        public string Department_name { get; set; }
        public string Department_code { get; set; }
        public string Location { get; set; }
        public double Number_of { get; set; }
        public string Personals { get; set; }
        public int Employee_TblId { get; set; }
    }
}
