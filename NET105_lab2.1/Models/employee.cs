using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace NET105_lab2._1.Models
{
    public class employee
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int employeeId { get; set; }
        [Required]
        [StringLength(100)]
        public string name { get; set; }
        [ForeignKey("department")]
        public int departmentId { get; set; }   
        public department department { get; set; }
    }
}
