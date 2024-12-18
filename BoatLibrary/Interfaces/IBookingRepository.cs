using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BoatLibrary.Objects;

namespace BoatLibrary.Interfaces
{
    public interface IBookingRepository
    {
        public int Count { get; }
        public List<Booking> GetAll();
        public void ABooking(Booking booking);
        public void DeleteBooking(int ID);
        public Booking GetBookingByMember(Member member);
        public Booking GetBookingByID(int ID);
        public bool BookingPossible(Booking book);
    }
}
