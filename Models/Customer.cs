namespace SampleMvc.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Customer")]
    public partial class Customer
    {
        [StringLength(10)]
        public string CustomerId { get; set; }

        [Required]
        [StringLength(50)]
        [RegularExpression(@"^(?!.*([ ])\1)(?!.*([A-Za-z])\2{2})\w[a-zA-Z ]*$", ErrorMessage = "The valid Employee Name Should contains only alphabets and single character should not be repeated continuously for more than 2 time ")]
        public string CustomerName { get; set; }

        [Required]
        [StringLength(10)]
        public string CustomerPhoneNo { get; set; }

        [Required]
        [StringLength(50)]
        public string CustomerAddress { get; set; }
    }
}
