using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class BoatRepo : IBoatRepository
{
    private List<IBoat> Boats;

    
    public int Count { get { return Boats.Count; } }

    public BoatRepo() { 
        Boats = new List<IBoat>();
    }
    public void AddBoat(IBoat boat)
    {
        Boats.Add(boat);
    }

    public void DeleteBoat(string sailNumber)
    {
        foreach (var b in Boats) {
            if (b.SailNumber == sailNumber) { 
                Boats.Remove(b);
                return;
            }
        }
    }

    public List<IBoat> GetAll()
    {
        return Boats;
    }

    public IBoat GetBoat(string sailNumber)
    {
        foreach (var b in Boats)
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
        foreach (var b in Boats)
        {
            if (b.SailNumber == sailNumber)
            {
                Boats.Remove(b);
                Boats.Add(boat);
                return;
            }
        }
    }
}
