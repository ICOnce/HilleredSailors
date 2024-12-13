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
            if (book.StartTime > book.EndTime)return false;
            if (_bookings.Count == 0) return true;

            foreach (Booking b in _bookings) {
                if (b.Boat == book.Boat) {
                    List<DateTime> Dates = new List<DateTime>();
                    Dates.Add(book.StartTime);
                    Dates.Add(book.EndTime);
                    Dates.Add(b.StartTime);
                    Dates.Add(b.EndTime);
                    Dates.Sort();
                    Booking b1 = new Booking();
                    if (book.StartTime == Dates[0]) { b1 = book; } else { b1 = b; }
                    if (Dates[1] != b1.EndTime) return false;
                } 
            }
            return true;

        }
        public List<Booking> GetAll()
        {
            return _bookings;
        }
        public Booking GetBookingByMember(Member member)
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