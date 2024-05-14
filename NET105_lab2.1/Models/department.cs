using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace NET105_lab2._1.Models
{
    public class department
    {
        [Key]
        public int departmentMa {  get; set; }
        [Required]
        [Column("departmentName")]
        public string Name { get; set;}
        public virtual ICollection<employee> Employees { get; set; }

    }
}
