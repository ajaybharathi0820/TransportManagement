namespace SampleMvc.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Driver")]
    public partial class Driver
    {
        [StringLength(10)]
        public string DriverId { get; set; }

        [Required]
        [StringLength(50)]
        [RegularExpression(@"^(?!.*([ ])\1)(?!.*([A-Za-z])\2{2})\w[a-zA-Z ]*$", ErrorMessage = "The valid Employee Name Should contains only alphabets and single character should not be repeated continuously for more than 2 time ")]
        public string DriverName { get; set; }

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
        [RegularExpression("^[6-9][0-9]{9}$",ErrorMessage = "The valid Mobile number should starts with between 6 and 9 and followed by 9 digit numbers")]
        public string DriverPhoneNo { get; set; }

        [Required]
        [StringLength(50)]
        public string DriverAddress { get; set; }
    }
}
