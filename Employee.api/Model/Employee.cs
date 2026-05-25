using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Employee.api.Model
{
    [Table("employeeTbl")]
    public class Employee
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int employeeId { get; set; }

        [Required, MaxLength(50)]
        public string? name { get; set; } = string.Empty;

        [Required, MaxLength(11), MinLength(11)]
        public string? contactNo { get; set; } =string.Empty;

        //[Required, RegularExpression("")]
        public string? email { get; set; } = string.Empty;

        [Required, MaxLength(50)]
        public string? city { get; set; } = string.Empty;

        [Required, MaxLength(50)]
        public string? state { get; set; } = string.Empty;

        [Required, MaxLength(4), MinLength(4)]
        public string? pincode { get; set; } = string.Empty;

        [Required, MaxLength(50)]
        public string? altContactNo { get; set; } = string.Empty;

        [Required, MaxLength(2000)]
        public string? address { get; set; } = string.Empty;


        public int designationId { get; set; } 
        

        public DateTime createdDate { get; set; } 
        public DateTime modifiedDate { get; set; }

    }
}
