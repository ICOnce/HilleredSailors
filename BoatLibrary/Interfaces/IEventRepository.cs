using BoatLibrary.Interfaces;
using BoatLibrary.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public interface IEventRepository
{
    int EventCount { get; }
    Event GetEvent(DateTime date);
    public void AddEvent(Event e);
    public void UpdateEvent();
    public void DeleteEvent(DateTime date);
    public List<Event> GetAll();
    string ToString();
}

