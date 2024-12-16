using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BoatLibrary.Objects;

namespace BoatLibrary.Interfaces
{
    public interface IEquipment
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
        public string CheckStatus { get; set; }
        public void AddEquipment(Equipment item);
        public Equipment GetEquipment(int Id);
        public void Borrow(Boat boat);
        public List<Equipment> GetItems();
    }
}
