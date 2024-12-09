using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoatLibrary.Interfaces
{
    public interface IBookingRepository
    {
        public int Count { get; }
        public List<IBooking> GetAll();
        public void ABooking(IBooking booking);

        public IBooking GetBookingByMember(IMember m);
        public bool BookingPossible(IBooking book);
        public string Tostring();

    }
}
