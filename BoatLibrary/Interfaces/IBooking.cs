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
        public IMember Booker { get; set; }
        public List<IBoat> Boats{get;}

        public void AddBoat(IBoat boat);
        public IBoat GetBoat(string sailNumber);
        public void DeleteBoat(IBoat boat);
        public List<IBoat> GetBoats();


    }
}
