using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BoatLibrary.Objects;

namespace BoatLibrary.Interfaces
{
    public interface IEquipmentRepository
    {
        public int Count { get; }
        public bool Status { get; set; }
        public void AddEquipment(string name, string? description);
        public void CheckStatus(int id);
        public void BorrowEquipment(int id);
        public void ReturnEquipment(int id);
        public void DeleteEquipment(int id);
        public Equipment GetEquipment(int id);
        public List<Equipment> GetAll();
    }
}
