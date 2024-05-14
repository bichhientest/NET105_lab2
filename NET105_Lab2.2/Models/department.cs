using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace NET105_Lab2._2.Models
{
    public class department
    {
        [Key]
        public int departmentMa { get; set; }
        [Required]
        [Column("departmentName")]
        public string Name { get; set; }
        public  employee employee { get; set; }
    }
}
