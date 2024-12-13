using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoatLibrary.Interfaces
{
    public interface IEvent
    {
        public Member Organizer { get; set; }
        public int ParticipantCount { get; }
        public DateTime Date { get; set; }
        public void AddParticipant(Member Par);
        public string Description { get; set; }
        public string header { get; set; }
        public int MaxParticipants { get; set; }
        public void RemoveParticipant(Member Par);
    }
}
