﻿using BoatLibrary.Interfaces;
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
        List<IEvent> events;
        public int EventCount { get { return events.Count; } }
        public EventRepo() { 
            events = new List<IEvent>();
            IEvent e = new Event();
            e.header = "Træning på søen";
            e.Organizer = new Member();
            e.Date = DateTime.Now;
            e.Description = "Description";
            events.Add(e);
        }

        public void AddEvent(IEvent e) { 
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
                if (e.Date == date)
                {
                    return e;
                }
            }
            return null;
        }

        public void UpdateEvent()
        {
            foreach (IEvent e in events) {
                if (e.Date<DateTime.Now) events.Remove(e);
            }
        }

       
    }
}
