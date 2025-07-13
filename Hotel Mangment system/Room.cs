using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Mangment_system
{
    internal class Room
    {
        public int RoomNumber { get; set; }
        public string RoomType { get; set; }
        public double Price { get; set; }
        public bool IsBooked { get; set; }

        public void DisplayInfo()
        {
            //display Room
        }
        public void Vacate()
        {
            //exist form room 
        }
        public void Book()
        {

        }

    }
    internal class Customer
    {
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Name { get; set; }
        public string cardId { get; set; }

        public void Displaycustomer()
        {
            //display Room
        }
        public void updateInfo()
        {

        }

    }
    internal class Reservation
    {
        public DateTime CheckInDate { get; set; }
        public string Room { get; set; }
        public string customer { get; set; }
        public DateTime CheckOutDate { get; set; }

        public void CalculateStayDuration()
        {

        }
        public void GetReservationDetails()
        {

        }



    }
    public class ReportService
    {
        private List<Room> _rooms;
        private List<Customer> _customers;
        private List<Reservation> _reservations;
    }

}
