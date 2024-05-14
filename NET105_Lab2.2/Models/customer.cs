using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace NET105_Lab2._2.Models
{
    public class customer
    {
        public int customerId { get; set; }
        [Required]
        [Column("customerName")]
        public string Name { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
