namespace SampleMvc.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Booking
    {
        [StringLength(10)]
        public string BookingId { get; set; }

        [Required]
        [StringLength(10)]
        public string CustomerName { get; set; }

        [Required]
        [StringLength(10)]
        public string VehicleNo { get; set; }

        [Required]
        [StringLength(20)]
        public string PickUpPlace { get; set; }

        [Required]
        [StringLength(20)]
        public string DropOffPlace { get; set; }

        [Column(TypeName = "date")]
        public DateTime PickUpDate { get; set; }

        [Column(TypeName = "date")]
        public DateTime DropOffDate { get; set; }

        [Column(TypeName = "money")]
        public decimal Amount { get; set; }
    }
}
