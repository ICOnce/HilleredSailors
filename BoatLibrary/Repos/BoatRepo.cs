using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class BoatRepo : IBoatRepository
{
    #region Instances
    private List<Boat> _boats;
    #endregion

    #region Properties
    public int Count { get { return _boats.Count; } }
    #endregion

    #region Constructor
    public BoatRepo() { 
        _boats = new List<Boat>();
    }
    #endregion

    #region Methods
    public void AddBoat(Boat boat)
    {
        _boats.Add(boat);
    }
    public void DeleteBoat(string sailNumber)
    {
        foreach (var b in _boats) {
            if (b.SailNumber == sailNumber) { 
                _boats.Remove(b);
                return;
            }
        }
    }
    public List<Boat> GetAll()
    {
        Boat[] temp = new Boat[_boats.Count];
        _boats.CopyTo(temp,0);
        return temp.ToList();
    }
    public Boat GetBoat(string sailNumber)
    {
        foreach (var b in _boats)
        {
            if (b.SailNumber == sailNumber)
            { 
                return b;
            }
        }
            return null;
    }

    public void UpdateBoat(Boat boat, string sailNumber)
    {
        foreach (var b in _boats)
        {
            if (b.SailNumber == sailNumber)
            {
                _boats.Remove(b);
                _boats.Add(boat);
                return;
            }
        }
    }
    #endregion
}
