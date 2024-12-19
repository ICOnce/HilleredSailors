using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BoatLibrary.Interfaces;
using BoatLibrary.Objects;

namespace BoatLibrary.Repos
{
    public class EquipmentRepository : IEquipmentRepository
    {
        #region Instances
        private List<Equipment> _equipmentRepository;
        #endregion

        #region Properties
        public int Count { get { return _equipmentRepository.Count(); } }
        public bool Status { get; set; }
        #endregion

        #region Constructor
        public EquipmentRepository()
        {
            _equipmentRepository = new List<Equipment>();
        }
        #endregion

        #region Methods
        public void AddEquipment(string? name, string? description)
        {
            Equipment equipment = new Equipment(name, description);
            _equipmentRepository.Add(equipment);
        }
        public void CheckStatus(int id)
        {
            foreach (var item in _equipmentRepository)
            {
                if (item.Status == true)
                {
                    return;
                }
                else if (item.Status == false)
                {
                    Console.WriteLine("Equipment is unavailable.");
                    return;
                }
            }
        }
        public void BorrowEquipment(int Id)
        {
            foreach (var item in _equipmentRepository)
            {
                if (item.Id == Id)
                {
                    if (item.Status == true)
                    {
                        item.Status = false;
                        return;
                    }
                }
            }
        }
        public void ReturnEquipment(int Id)
        {
            foreach (var item in _equipmentRepository)
            {
                if (item.Id == Id)
                {
                    if (item.Status == false)
                    {
                        item.Status = true;
                        return;
                    }
                }
            }
        }
        public void DeleteEquipment(int Id)
        {
            foreach (var item in _equipmentRepository)
            {
                if (item.Id == Id)
                {
                    _equipmentRepository.Remove(item);
                    return;
                }
            }
        }
        public Equipment GetEquipment(int Id)
        {
            foreach (var equipment in _equipmentRepository)
            {
                if (equipment.Id == Id)
                {
                    return equipment;
                }
            }
            return null;
        }
        public List<Equipment> GetAll()
        {
            return _equipmentRepository;
        }
        #endregion
    }
}
