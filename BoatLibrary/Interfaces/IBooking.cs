using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoatLibrary.Interfaces
{
    public interface IBooking
    {
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public IBoat Boat { get; set; }
        public void AddBoat(IBoat boat);
        public IBoat GetBoat(string sailNumber);
        public void DeleteBoat(IBoat boat);

        public List<IBoat> GetBoats();


    }
}
