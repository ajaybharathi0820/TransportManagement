using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace SampleMvc.Models
{
    public partial class TmsDbModel : DbContext
    {
        public TmsDbModel()
            : base("name=TmsDbModel")
        {
        }

        public virtual DbSet<Booking> Bookings { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Driver> Drivers { get; set; }
        public virtual DbSet<employee> employees { get; set; }
        public virtual DbSet<Vehicle> Vehicles { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Booking>()
                .Property(e => e.BookingId)
                .IsFixedLength();

            modelBuilder.Entity<Booking>()
                .Property(e => e.CustomerName)
                .IsFixedLength();

            modelBuilder.Entity<Booking>()
                .Property(e => e.VehicleNo)
                .IsUnicode(false);

            modelBuilder.Entity<Booking>()
                .Property(e => e.PickUpPlace)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Booking>()
                .Property(e => e.DropOffPlace)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Booking>()
                .Property(e => e.Amount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Customer>()
                .Property(e => e.CustomerId)
                .IsFixedLength();

            modelBuilder.Entity<Customer>()
                .Property(e => e.CustomerName)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.CustomerPhoneNo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.CustomerAddress)
                .IsUnicode(false);

            modelBuilder.Entity<Driver>()
                .Property(e => e.DriverId)
                .IsFixedLength();

            modelBuilder.Entity<Driver>()
                .Property(e => e.DriverName)
                .IsUnicode(false);

            modelBuilder.Entity<Driver>()
                .Property(e => e.Gender)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Driver>()
                .Property(e => e.DriverPhoneNo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Driver>()
                .Property(e => e.DriverAddress)
                .IsUnicode(false);

            modelBuilder.Entity<employee>()
                .Property(e => e.EmployeeId)
                .IsFixedLength();

            modelBuilder.Entity<employee>()
                .Property(e => e.EmployeeName)
                .IsUnicode(false);

            modelBuilder.Entity<employee>()
                .Property(e => e.Password)
                .IsUnicode(false);

            modelBuilder.Entity<employee>()
               .Property(e => e.Gender)
               .IsFixedLength()
               .IsUnicode(false);

            modelBuilder.Entity<employee>()
                .Property(e => e.PhoneNo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<employee>()
                .Property(e => e.DateOfJoining);

            modelBuilder.Entity<employee>()
                .Property(e => e.DateOfBirth);
               
            modelBuilder.Entity<Vehicle>()
                .Property(e => e.VehicleId)
                .IsFixedLength();

            modelBuilder.Entity<Vehicle>()
                .Property(e => e.VehicleNo)
                .IsUnicode(false);

            modelBuilder.Entity<Vehicle>()
                .Property(e => e.VehicleBrand)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Vehicle>()
                .Property(e => e.VehicleModel)
                .IsFixedLength();

            modelBuilder.Entity<Vehicle>()
                .Property(e => e.BodyType)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Vehicle>()
                .Property(e => e.Mileage)
                .IsFixedLength();

            modelBuilder.Entity<Vehicle>()
                .Property(e => e.EngineType)
                .IsFixedLength()
                .IsUnicode(false);
        }
    }
}
