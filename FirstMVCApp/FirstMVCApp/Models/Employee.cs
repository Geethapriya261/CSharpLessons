using System.ComponentModel.DataAnnotations;

namespace FirstMVCApp.Models
{
    public class Employee
    {
        [Key]
        public int eno { get; set; }
        [Required]
        [StringLength(50)]
        [MinLength(3,ErrorMessage="Name should be between 3 and 20 chars")]
        public string name { get; set; }
        [Required]

        
        public Decimal salary { get; set; }
        
        public String city { get; set; }
    }
}
