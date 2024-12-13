using BoatLibrary.Interfaces;
using BoatLibrary.Objects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoatLibrary.Repos
{
    public class EventRepo : IEventRepository
    {
        #region Instances
        List<IEvent> events;
        #endregion

        #region Properties
        public int EventCount { get { return events.Count; } }
        #endregion

        #region Constructor
        public EventRepo() { 
            events = new List<IEvent>();
            IEvent e = new Event();
            e.header = "Træning på søen";
            e.Organizer = new Member();
            e.Date = DateTime.Now;
            e.Description = "Description";
            e.MaxParticipants = 20;
            events.Add(e);
            e=new Event();
            e.header = "kill the nazis";
            e.Organizer=new Member();
            e.Date = DateTime.Now.AddDays(2);
            e.Description = "i dag skal hitler væk";
            e.MaxParticipants = 200;
            events.Add(e);
        }
        #endregion

        #region Methods
        public void AddEvent(IEvent e) 
        { 
            events.Add(e);
        }
        public void DeleteEvent(DateTime date)
        {
            foreach (IEvent e in events) {
                if (e.Date == date) { 
                    events.Remove(e);
                    return;
                }
            }
        }
        public List<IEvent> GetAll()
        {
            return events;
        }
        public IEvent GetEvent(DateTime date)
        {
            foreach (IEvent e in events)
            {
                if (date.Date.Equals(e.Date.Date))
                {
                    return e;
                }
            }
            return null;
        }
        public void UpdateEvent()
        {
            foreach (IEvent e in events) 
            {
                if (e.Date<DateTime.Now) events.Remove(e);
            }
        }
        #endregion
    }
}
