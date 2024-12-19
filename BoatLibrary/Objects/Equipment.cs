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
        private int _id;
        static private int _counter = 0;
        private bool _isAvailable;
        #endregion

        #region Properties
        public int Id
        {
            get { return _id; }
        }
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

        }
        
        // parameterised constructor
        public Equipment(string? name, string? description)
        {
            _counter++;
            _id = _counter;
            _isAvailable = true;
            if (null != name) { Name = name; }
            if (null != description) { Description = description; }
        }
        #endregion
    }
}
