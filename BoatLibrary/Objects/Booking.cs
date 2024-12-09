using BoatLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoatLibrary.Objects
{
    public class Booking : IBooking
    {
        public DateTime StartTime { get; set ; }
        public DateTime EndTime { get ; set ; }
        public IMember Booker { get ; set ; }

        public List<IBoat> Boats { get; }

        public void AddBoat(IBoat boat)
        {
            Boats.Add(boat);
        }

        public void DeleteBoat(IBoat boat)
        {
            Boats.Remove(boat);
        }

        public IBoat GetBoat(string sailNumber)
        {
            foreach (var b in Boats) {
                if (b.SailNumber==sailNumber) {
                    return b;
                }
            }
            return null;
        }

        public List<IBoat> GetBoats()
        {
            return Boats;
        }
    }
}
