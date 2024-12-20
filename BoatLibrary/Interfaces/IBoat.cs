﻿using BoatLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BoatLibrary.Objects;

public interface IBoat
{
    public string Model { get; }
    public string Name { get; set; }
    public string SailNumber { get; } 
    public string MotorInfo { get; set; }
    public int Length { get; }
    public int Width { get; }
    public Dictionary<DateTime, Boolean> Calender { get; }
    public Log Log { get; set; }
}

