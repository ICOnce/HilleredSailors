using BoatLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public interface IBoat
{
    public string Model { get; set; }
    public string Name { get; set; }
    public string SailNumber { get; set; } 
    public string MotorInfo { get; set; }
    public int Length { get; set; }
    public int Width { get; set; }

    public Dictionary<DateTime, Boolean> Calender { get; set; }

    public ILog Log { get; set; }

}

