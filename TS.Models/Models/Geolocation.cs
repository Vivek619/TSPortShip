using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TS.Models.Models
{
    [NotMapped]
    public class Geolocation
    {
        public int Latitude { get; set; }
        public int Longitude { get; set; }
    }
}
