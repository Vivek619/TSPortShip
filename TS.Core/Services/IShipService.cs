using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TS.Models.DTO;
using TS.Models.Models;

namespace TS.Core.Services
{
    public interface IShipService
    {
        ArrivalPortDTO GetClosestPortToShipAndEstimatedArrival(int id);
    }
}
