using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoatLibrary.Interfaces
{
    public interface IEvent
    {
        public IMember Organizer { get; set; }
        public int ParticipantCount { get; }
        public DateTime Date { get; set; }
        public void AddParticipant(IMember Par);
        public void RemoveParticipant(IMember Par);
        
    }
}
