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
        //private Dictionary<Equipment, int> _equipmentRepository;
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
        /*
        public EquipmentRepository()
        {
            _equipmentRepository = new Dictionary<Equipment, int>;
        }
        */
        #endregion

        #region Methods
        public void AddEquipment(Equipment equipment, int id)
        {
            _equipmentRepository.Add(equipment);
        }
        /*
        public void AddEquipment(Equipment equipment, int id)
        {
            _equipmentRepository.Add(equipment, id);
        }
        */
        public void CheckStatus(Equipment equipment, int id)
        {
            foreach (var item in _equipmentRepository)
            {
                if (item.Id == id && item.Status == true)
                {
                    Console.WriteLine("Equipment is available.");
                }
                else if (item.Id == id && item.Status == false)
                {
                    Console.WriteLine("Equipment is unavailable.");
                }
            }
        }
        public void BorrowEquipment(Equipment equipment, int id)
        {
            foreach (var item in _equipmentRepository)
            {
                if (item.Id == id && item.Status == true)
                {
                    equipment.Status = false;
                }
            }
        }
        public void ReturnEquipment(Equipment equipment, int id)
        {
            foreach (var item in _equipmentRepository)
            {
                if (item.Id == id && item.Status == false)
                {
                    equipment.Status = true;
                }
            }
        }
        public void DeleteEquipment(int id)
        {
            foreach (var item in _equipmentRepository)
            {
                if (item.Id == id)
                {
                    _equipmentRepository.Remove(item);
                }
            }
        }
        public Equipment GetEquipment(int id)
        {
            foreach (Equipment equipment in _equipmentRepository)
            {
                if (equipment.Id == id)
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
