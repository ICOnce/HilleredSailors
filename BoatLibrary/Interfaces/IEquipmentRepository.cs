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
        public void AddEquipment(Equipment equipment, int id);
        public void CheckStatus(Equipment equipment, int id);
        public void BorrowEquipment(Equipment equipment, int id);
        public void ReturnEquipment(Equipment equipment, int id);
        public void DeleteEquipment(int íd);
        public Equipment GetEquipment(int id);
        public List<Equipment> GetAll();
    }
}
