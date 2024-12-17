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
        public void AddEquipment(Equipment equipment)
        {
            _equipmentRepository.Add(equipment);
        }
        public void CheckStatus(Equipment equipment, int Id)
        {
            foreach (var item in _equipmentRepository)
            {
                if (item.Id == Id && item.Status == true)
                {
                    Console.WriteLine("Equipment is available.");
                }
                else if (item.Id == Id && item.Status == false)
                {
                    Console.WriteLine("Equipment is unavailable.");
                }
            }
        }
        public void BorrowEquipment(Equipment equipment, int Id)
        {
            foreach (var item in _equipmentRepository)
            {
                if (item.Id == Id && item.Status == true)
                {
                    equipment.Status = false;
                }
            }
        }
        public void ReturnEquipment(Equipment equipment, int Id)
        {
            foreach (var item in _equipmentRepository)
            {
                if (item.Id == Id && item.Status == false)
                {
                    equipment.Status = true;
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
                }
            }
        }
        public Equipment GetEquipment(int Id)
        {
            foreach (Equipment equipment in _equipmentRepository)
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
