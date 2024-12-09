using BoatLibrary.Interfaces;
using BoatLibrary.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoatLibrary.Repos
{
    public class BookkingRepository : IBookingRepository
    {
        private List<IBooking> Bookings;
        public int Count { get { return Bookings.Count; } }
        public BookkingRepository() { 
            Bookings = new List<IBooking>();
        }
        public void ABooking(IBooking booking)
        {
            Bookings.Add(booking);
        }

        public bool BookingPossible(IBooking book)
        {
            foreach (IBooking booking in Bookings) {
                if (booking.GetBoats().Contains(book.Boat) ) {

                    if (booking.StartTime <= book.StartTime && booking.EndTime >= book.StartTime) return false;
                    if (booking.StartTime <= book.EndTime && booking.EndTime >= book.EndTime) return false;
                }
            }
            return true;
        }

        public List<IBooking> GetAll()
        {
            return Bookings;
        }

        public IBooking GetBookingByMember(IMember m)
        {
            foreach (Booking b in Bookings) { 
                if (b.Booker == m)
                    return b;
            }
            return null;
        }
        public void DeleteBooking(IBooking booking)
        {
            Bookings.Remove(booking);
        }

        public string Tostring()
        {
            throw new NotImplementedException();
        }

       
    }
}
