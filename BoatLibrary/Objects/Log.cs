using BoatLibrary.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoatLibrary.Objects
{
    public class Log : ILog
    {
        #region Instances
        private List<string> _log = new List<string>();
        #endregion

        #region Properties
        public int EntryCount { get { return _log.Count; } }
        #endregion

        #region Constructor

        #endregion

        #region Methods
        public void AddEntry(string entry) 
        { 
            _log.Add(entry);
        }
        public string GetEntry(int id) 
        { 
            return _log[id];
        }
        public List<string> GetAll() 
        { 
            return _log;
        }
        public string ToString() 
        {
            return null;
        }
        #endregion
    }
}
