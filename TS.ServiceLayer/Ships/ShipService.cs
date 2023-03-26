using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TS.Core.Services;
using TS.Models.DTO;
using TS.Models.Models;
using TS.Persistence.DB;

namespace TS.ServiceLayer.Ships
{
    public class ShipService : IShipService
    {
        public ArrivalPortDTO GetClosestPortToShipAndEstimatedArrival(int id)
        {
            using (var unitOfWork = new UnitOfWork(new TSDBContext()))
            {
                var ship = unitOfWork.ShipRepository.GetById(id);
                var ports = unitOfWork.PortRepository.GetAll();

                Dictionary<decimal, Port> distance = new Dictionary<decimal, Port>();

                foreach (var port in ports)
                {
                    distance.Add(DistanceBetweenTwoPoints(port.Latitude,
                        port.Longitude,
                        ship.Latitude,
                        ship.Longitude), port);
                }

                var nearestPort = distance.SingleOrDefault(a => a.Key == distance.Keys.Min()).Value;
                var estimatedArrival = distance.SingleOrDefault(a => a.Key == distance.Keys.Min()).Key / ship.Velocity;
                return new ArrivalPortDTO { Port = nearestPort, TimeOfArrivalInHours = estimatedArrival };
            }
        }

        private decimal DistanceBetweenTwoPoints(int x1, int y1, int x2, int y2)
        {
            return Convert.ToDecimal(Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2)));
        }

    }
}
