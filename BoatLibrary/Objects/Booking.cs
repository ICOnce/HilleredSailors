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
        #region Instances
        private List<IBoat> _boats = new List<IBoat>();
        #endregion

        #region Properties
        public DateTime StartTime { get; set ; }
        public DateTime EndTime { get ; set ; }
        public IBoat Boat { get; set ; }
        public Member Booker { get; set ; }

        private List<IBoat> Boats=new List<IBoat>();

        public Booking() {
        }
        #endregion

        #region Methods
        public void AddBoat(IBoat boat)
        {
            _boats.Add(boat);
        }
        public void DeleteBoat(IBoat boat)
        {
            _boats.Remove(boat);
        }
        public IBoat GetBoat(string sailNumber)
        {
            foreach (var b in _boats) {
                if (b.SailNumber==sailNumber) {
                    return b;
                }
            }
            return null;
        }
        public List<IBoat> GetBoats()
        {
            return _boats;
        }
        #endregion
    }
}
