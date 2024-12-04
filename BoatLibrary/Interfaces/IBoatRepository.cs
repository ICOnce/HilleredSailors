using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public interface IBoatRepository
{
    public int Count { get;}

    public IBoat GetBoat(string sailNumber);
    public List<IBoat> GetAll();
    public void AddBoat(IBoat boat);
    public void DeleteBoat(string sailNumber);
    public void UpdateBoat(IBoat boat, string sailNumber);



}

