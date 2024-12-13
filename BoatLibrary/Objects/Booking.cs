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
        private int _id = 0;
        private List<Boat> _boats = new List<Boat>();
        #endregion

        #region Properties
        public int Id { get { return _id; } }
        public DateTime StartTime { get; set ; }
        public DateTime EndTime { get ; set ; }
        public Boat Boat { get; set ; }
        public Member Booker { get; set; }

        public Booking() 
        {
            _id++;
        }
        #endregion

        #region Methods
        public void AddBoat(Boat boat)
        {
            _boats.Add(boat);
        }
        public void DeleteBoat(Boat boat)
        {
            _boats.Remove(boat);
        }
        public Boat GetBoat(string sailNumber)
        {
            foreach (Boat boat in _boats) 
            {
                if (boat.SailNumber == sailNumber) {
                    return boat;
                }
            }
            return null;
        }
        public List<Boat> GetBoats()
        {
            return _boats;
        }
        #endregion
    }
}
