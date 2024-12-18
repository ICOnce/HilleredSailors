using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BoatLibrary.Interfaces;

namespace BoatLibrary.Objects
{
    public class Equipment : IEquipment
    {
        #region Instances
        private int _id = 0;
        private bool _isAvailable = true;
        #endregion

        #region Properties
        public int Id { get { return _id; } }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool Status 
        { 
            get {  return _isAvailable; }
            set { _isAvailable = value; }
        }
        #endregion

        #region Constructor
        // default constructor
        public Equipment()
        {
            _id++;
            _isAvailable = true;
        }

        // optional parameter
        public Equipment(string name, string description)
        {
            _id++;
            Name = name;
            Description = description;
            _isAvailable = true;
        }
        #endregion
    }
}
