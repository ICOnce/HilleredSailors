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
        #region Instances
        public List<Member> _participants;
        #endregion

        #region Properties
        public Member Organizer { get; set; }
        public int ParticipantCount { get { return _participants.Count; } }
        public DateTime Date { get; set ; }
        public string header { get; set; }
        public string Description { get; set; }
        public int MaxParticipants { get; set; }
        #endregion 

        #region Constructor
        public Event() 
        { 
            _participants = new List<Member>();
        }
        #endregion

        #region Methods
        public void AddParticipant(Member Par)
        {
            _participants.Add(Par);
        }
        public void RemoveParticipant(Member Par)
        {
            _participants.Remove(Par);
        }
        #endregion
    }
}
