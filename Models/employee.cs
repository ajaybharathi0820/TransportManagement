namespace SampleMvc.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("employee")]
    public partial class employee
    {
        [StringLength(10)]
        public string EmployeeId { get; set; }

        [Required]
        [StringLength(50)]
        public string EmployeeName { get; set; }

        [Required]
        [MinLength(8),MaxLength(12)]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Column(TypeName = "date")]
        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }

        [Column(TypeName = "date")]
        [DataType(DataType.Date)]
        public DateTime DateOfJoining { get; set; }

        [Required]
        [StringLength(10)]
        public string Gender { get; set; }

        [Required]
        [StringLength(10)]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression("^[6-9][0-9]{9}$", ErrorMessage = "The valid Mobile number should starts with between 6 and 9 and followed by 9 digit numbers")]
        public string PhoneNo { get; set; }

    }
}
