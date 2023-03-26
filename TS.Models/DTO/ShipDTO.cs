using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TS.Models.Models;

namespace TS.Models.DTO
{
    public class ShipDTO
    {
        public string Name { get; set; }
        public GeoLocationDTO GeolocationDTO { get; set; } = new GeoLocationDTO();
        public decimal Velocity { get; set; }
    }
}
