namespace SampleMvc.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Vehicle")]
    public partial class Vehicle
    {
        [StringLength(10)]
        public string VehicleId { get; set; }

        [Required]
        [StringLength(10)]
        public string VehicleNo { get; set; }

        [Required]
        [StringLength(20)]
        public string VehicleBrand { get; set; }

        [Required]
        [StringLength(20)]
        public string VehicleModel { get; set; }

        [Required]
        [StringLength(20)]
        public string BodyType { get; set; }

        [Required]
        [StringLength(10)]
        public string Mileage { get; set; }

        [Required]
        [StringLength(20)]
        public string EngineType { get; set; }
    }
}
