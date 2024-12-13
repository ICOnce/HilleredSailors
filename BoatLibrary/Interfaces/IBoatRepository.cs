using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public interface IBoatRepository
{
    public int Count { get; }
    public Boat GetBoat(string sailNumber);
    public List<Boat> GetAll();
    public void AddBoat(Boat boat);
    public void DeleteBoat(string sailNumber);
    public void UpdateBoat(Boat boat, string sailNumber);
}

