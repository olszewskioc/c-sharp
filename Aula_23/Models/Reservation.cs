using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_23.Models
{
    public class Reservation(DateTime checkin, DateTime checkout, int room)
    {
        private int _roomNumber = room > 0 ? room : throw new IndexOutOfRangeException("Room number must be greater than 0");
        private DateTime _checkin = checkin;
        private DateTime _checkout = checkout;

        public int RoomNumber
        {
            get => _roomNumber;
            set => _roomNumber = value > 0 ? value : throw new IndexOutOfRangeException("Room number must be greater than 0");
        }
        public DateTime CheckIn
        {
            get => _checkin;
            set => _checkin = value > _checkin && value >= DateTime.Now ? value : throw new DomainException("New check-in date must be after your actual check-in date and greater than or equal to the current date");
        }
        public DateTime CheckOut
        {
            get => _checkout;
            set => _checkout = value > CheckIn && value > DateTime.Now ? value : throw new DomainException("New check-out date must be after your actual check-in date");
        }

        public int Duration() => (int)(_checkout - _checkin).TotalDays;
        public  void UpdateDates(DateTime checkIn, DateTime checkOut)
        {
            CheckIn = checkIn;
            CheckOut = checkOut;
            Console.WriteLine($"{this}");
        }
        public override string ToString()
        {
            return $"Room {RoomNumber}  |  Check-in: {CheckIn:dd/MM/yyyy}  Check-out: {CheckOut:dd/MM/yyyy} -> {Duration()} nights.";
        }
    }
}