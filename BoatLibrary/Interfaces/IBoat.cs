using BoatLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public interface IBoat
{
    public string Model { get; }
    public string Name { get; set; }
    public string SailNumber { get; } 
    public string MotorInfo { get; set; }
    public int Length { get; }
    public int Width { get;  }

    public Dictionary<DateTime, Boolean> Calender { get; set; }

    public ILog Log { get; set; }

}

