using Hotel_1.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_1.Context
{
    class LibraryContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseSqlServer(@"Data Source=.;Initial Catalog=HotelReservation;Integrated Security=true;Encrypt=false");

        public virtual DbSet<Reservation> Reservations { get; set; }

        public virtual DbSet<Entities.Kitchen> Kitchens { get; set; }

        public virtual DbSet<FrontDisk> FrontDisk { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Reservation>(entity =>
            {
                entity.HasIndex(e => e.Id, "ID");

                entity.Property(e => e.Id).HasColumnName("ID").HasMaxLength(5);

                entity.Property(e => e.FirstName)
                    .HasMaxLength(15);

                entity.Property(e => e.LastName)
                    .HasMaxLength(15);

                entity.Property(e => e.BirthDay);
                entity.Property(e => e.Gender);
                entity.Property(e => e.PhoneNumber);
                entity.Property(e => e.EmailAddress);
                entity.Property(e => e.NumberGuest);
                entity.Property(e => e.StreetAddress);
                entity.Property(e => e.AptSuite);
                entity.Property(e => e.City);
                entity.Property(e => e.State);
                entity.Property(e => e.ZipCode);
                entity.Property(e => e.RoomType);
                entity.Property(e => e.RoomFloor);
                entity.Property(e => e.RoomNumber);
                entity.Property(e => e.TotalBill);
                entity.Property(e => e.PaymentType);
                entity.Property(e => e.CardType);
                entity.Property(e => e.CardNumber);
                entity.Property(e => e.CardExpiry);
                entity.Property(e => e.CardCvc);
                entity.Property(e => e.ArrivalTime);
                entity.Property(e => e.LeavingTime);
                entity.Property(e => e.CheckIn);
                entity.Property(e => e.BreakFast);
                entity.Property(e => e.Lunch);
                entity.Property(e => e.Dinner);
                entity.Property(e => e.Cleaning);
                entity.Property(e => e.Towel);
                entity.Property(e => e.SSurprise);
                entity.Property(e => e.FoodBill);
            });
        }
    }
}
