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

        #endregion

        #region Properties

        #endregion

        #region Constructor

        #endregion

        #region Methods

        #endregion
        List<Event> events;
        public int EventCount { get { return events.Count; } }
        public EventRepo() { 
            events = new List<Event>();
            Event e = new Event();
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

        public void AddEvent(Event e) { 
            events.Add(e);
        }

        public void DeleteEvent(DateTime date)
        {
            foreach (Event e in events) {
                if (e.Date == date) { 
                    events.Remove(e);
                    return;
                }
            }
        }

        public List<Event> GetAll()
        {
            return events;
        }

        public Event GetEvent(DateTime date)
        {
            foreach (Event e in events)
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
            foreach (Event e in events) {
                if (e.Date<DateTime.Now) events.Remove(e);
            }
        }

       
    }
}
