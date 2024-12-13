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
        public List<IBooking> GetAll();
        public void ABooking(IBooking booking);
        public void DeleteBooking(IBooking booking);
        public Booking GetBookingByMember(IMember member);
        public Booking GetBookingByID(IBooking ID);
        public bool BookingPossible(IBooking book);
        public string Tostring();
    }
}
