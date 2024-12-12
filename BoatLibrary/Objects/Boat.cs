using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BoatLibrary.Interfaces;

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
    public ILog Log { get; set; }
    #endregion
}

