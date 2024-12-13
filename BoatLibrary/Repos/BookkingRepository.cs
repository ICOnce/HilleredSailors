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
        private List<IBooking> _bookings;
        #endregion

        #region Properties
        public int Count { get { return _bookings.Count; } }
        #endregion

        #region Constructor
        public BookkingRepository() 
        { 
            _bookings = new List<IBooking>();
        }
        #endregion
        
        #region Methods
        public void ABooking(IBooking booking)
        {
            _bookings.Add(booking);
        }

        public bool BookingPossible(IBooking book)
        {
            foreach (IBooking booking in _bookings) 
            {
                if (booking.GetBoats().Contains(book.Boat) ) 
                {
                    if (booking.StartTime <= book.StartTime && booking.EndTime >= book.StartTime) return false;
                    if (booking.StartTime <= book.EndTime && booking.EndTime >= book.EndTime) return false;
                }
            }
            return true;
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