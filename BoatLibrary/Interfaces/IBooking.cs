using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoatLibrary.Interfaces
{
    public interface IBooking
    {
        public int Id { get; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public Boat Boat { get; set; }
        public void AddBoat(Boat boat);
        public Boat GetBoat(string sailNumber);
        public void DeleteBoat(Boat boat);
        public List<Boat> GetBoats();
    }
}
