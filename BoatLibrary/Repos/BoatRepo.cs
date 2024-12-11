using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class BoatRepo : IBoatRepository
{
    #region Instances
    private List<IBoat> _boats;
    #endregion

    #region Properties
    public int Count { get { return _boats.Count; } }
    #endregion

    #region Constructor
    public BoatRepo() { 
        _boats = new List<IBoat>();
    }
    #endregion

    #region Methods
    public void AddBoat(IBoat boat)
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
    public List<IBoat> GetAll()
    {
        IBoat[] temp = new IBoat[_boats.Count];
        _boats.CopyTo(temp,0);
        return temp.ToList();
    }
    public IBoat GetBoat(string sailNumber)
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

    public void UpdateBoat(IBoat boat, string sailNumber)
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
