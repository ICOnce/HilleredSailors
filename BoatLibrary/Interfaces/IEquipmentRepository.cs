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
        public void AddEquipment(Equipment equipment);
        public void CheckStatus(Equipment equipment, int Id);
        public void BorrowEquipment(Equipment equipment, int Id);
        public void ReturnEquipment(Equipment equipment, int Id);
        public void DeleteEquipment(int Id);
        public Equipment GetEquipment(int Id);
        public List<Equipment> GetAll();
    }
}
