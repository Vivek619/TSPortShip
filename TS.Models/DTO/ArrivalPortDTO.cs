using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TS.Models.Models;

namespace TS.Models.DTO
{
    public class ArrivalPortDTO
    {
        public Port Port { get; set; }
        public decimal TimeOfArrivalInHours { get; set; }
    }
}
