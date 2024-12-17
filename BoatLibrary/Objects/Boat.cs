using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BoatLibrary.Interfaces;
using BoatLibrary.Objects;

public class Boat : IBoat
{
    #region Properties
    public string Model { get; set; }
    public string Name { get; set; }
    public string SailNumber { get; set; }
    public string MotorInfo { get; set; }
    public int Length { get; set; }
    public int Width { get; set; }
    public Dictionary<DateTime, bool> Calender { get; }
    public Log Log { get; set; }
    #endregion

    #region Constructor
    public Boat()
    {
        ILog log = new Log();
    }
    #endregion
}

