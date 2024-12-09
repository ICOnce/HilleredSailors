using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public interface IEventRepository
{
    int EventCount { get; }
    IClubEvent GetEvent(DateTime dateTime);
    string ToString();
}

