using BoatLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public interface IEventRepository
{
    int EventCount { get; }
    IEvent GetEvent(DateTime date);
    public void UpdateEvent();
    public void DeleteEvent(DateTime date);
    public List<IEvent> GetAll();
    string ToString();
}

