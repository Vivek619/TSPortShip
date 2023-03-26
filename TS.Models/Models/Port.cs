using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TS.Models.Models
{
    public class Port
    {
        public int ID { get; set; }
        public int Latitude { get; set; }
        public int Longitude { get; set; }
        public string Name { get; set; } = "";
        
    }
}
