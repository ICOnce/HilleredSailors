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
        #region Instances
        private List<Booking> _bookings;
        #endregion

        #region Properties
        public int Count { get { return _bookings.Count; } }
        #endregion

        #region Constructor
        public BookkingRepository() 
        { 
            _bookings = new List<Booking>();
        }
        #endregion
        
        #region Methods
        public void ABooking(Booking booking)
        {
            _bookings.Add(booking);
        }

        public bool BookingPossible(Booking book)
        {
            foreach (IBooking booking in _bookings) {
                if (booking.GetBoats().Contains(book.Boat) ) {
                    if (booking.EndTime<=book.StartTime && book.StartTime<book.EndTime) return true;
                    if (book.EndTime<=booking.StartTime && booking.StartTime < booking.EndTime) return true;
                }
            }
            return false;
        }
        public List<IBooking> GetAll()
        {
            return _bookings;
        }
        public Booking GetBookingByMember(IMember member)
        {
            foreach (Booking booking in _bookings) 
            { 
                if (booking.Booker == member)
                {
                    return booking;
                }
            }
            return null;
        }
        public Booking GetBookingByID(int id)
        {
            foreach (Booking booking in _bookings)
            {
                if (booking.Id == id)
                {
                    return booking;
                }
            }
            return null;
        }
        public void DeleteBooking(int id)
        {
            foreach (var book in _bookings)
            {
                if (book.Id == id)
                {
                    _bookings.Remove(book);
                    return;
                }
            }
        }
        public string Tostring()
        {
            throw new NotImplementedException();
        }
    }
}
#endregion