using BoatLibrary.Interfaces;
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

        public bool BookingPossible(DateTime start, DateTime end, IBoat boat)
        {
            foreach (IBooking booking in Bookings) {
                if (booking.Boats.Contains(boat) ) {
                    if (booking.StartTime < start && booking.EndTime > start) return false;
                    if (booking.StartTime < end && booking.EndTime > end) return false;
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
            foreach (IBooking b in Bookings) { 
                if(b.Booker==m)return b;
            }
            return null;
        }

        public string Tostring()
        {
            throw new NotImplementedException();
        }
    }
}
