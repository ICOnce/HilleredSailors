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
        public int Id { get; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
