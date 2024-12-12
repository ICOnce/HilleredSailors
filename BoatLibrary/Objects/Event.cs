using BoatLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoatLibrary.Objects
{
    public class Event : IEvent
    {
        public List<IMember> _participants;
        public IMember Organizer { get; set; }

        public int ParticipantCount { get { return _participants.Count; } }

        public DateTime Date { get; set ; }
        public string header { get; set; }

        public string Description { get; set; }

        public Event() { 
            _participants = new List<IMember>();
        }

        public void AddParticipant(IMember Par)
        {
            _participants.Add(Par);
        }

        public void RemoveParticipant(IMember Par)
        {
            _participants.Remove(Par);
        }
    }
}
