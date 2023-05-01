using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_1.Entities
{
    class Reservation
    {
        
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string BirthDay { get; set; } = "1-1-1999";
        public string? Gender { get; set; }
        public string PhoneNumber { get; set; }
        public string? EmailAddress { get; set; }
        public int NumberGuest { get; set; }
        public string StreetAddress { get; set; }
        public string AptSuite { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public string RoomType { get; set; }
        public string RoomFloor { get; set; }
        public string RoomNumber { get; set; }
        public float TotalBill { get; set; }
        public string PaymentType { get; set; }
        public string CardType { get; set; }
        public string CardNumber { get; set; }
        public string CardExpiry { get; set; }
        public string CardCvc { get; set; }
        public DateTime ArrivalTime { get; set; } = DateTime.Now.AddMonths(-5);
        public DateTime LeavingTime { get; set; } = DateTime.Now.AddMonths(5);
        public bool CheckIn { get; set; }
        public int BreakFast { get; set; }
        public int Lunch { get; set; }
        public int Dinner { get; set; }
        public bool Cleaning { get; set; }
        public bool Towel { get; set; }
        public bool SSurprise { get; set; }
        public bool SupplyStatus { get; set; }
        public int FoodBill { get; set; }
    }
}
