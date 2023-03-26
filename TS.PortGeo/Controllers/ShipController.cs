using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TS.Core.Services;
using TS.Models.DTO;
using TS.Models.Models;
using TS.Persistence.DB;

namespace TS.PortGeo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShipController : ControllerBase
    {
        private readonly IShipService shipService;

        public ShipController(IShipService shipService)
        {
            this.shipService = shipService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            IEnumerable<Ship> ships;
            using (var unitofWork = new UnitOfWork(new TSDBContext()))
            {
                ships = unitofWork.ShipRepository.GetAll();
            }

            return Ok(ships);
        }

        [HttpGet]
        [Route("GetShipById")]
        public IActionResult GetById(int id)
        {
            Ship ship;
            using (var unitofWork = new UnitOfWork(new TSDBContext()))
            {
                ship = unitofWork.ShipRepository.GetById(id);
            }

            return Ok(ship);
        }

        [HttpPut]
        [Route("UpdateShip")]
        public IActionResult Update(int id, ShipDTO shipDTO)
        {
            Ship ship;
            using (var unitofWork = new UnitOfWork(new TSDBContext()))
            {
                ship = unitofWork.ShipRepository.GetById(id);
                ship.Name = shipDTO.Name;
                ship.Latitude = shipDTO.GeolocationDTO.Latitude;
                ship.Longitude = shipDTO.GeolocationDTO.Longitude;
                ship.Velocity = shipDTO.Velocity;

                unitofWork.Complete();
            }

            return Ok(ship);
        }

        [HttpPost]
        [Route("AddShip")]
        public IActionResult Create(ShipDTO shipDTO)
        {
            Ship ship = new Ship();
            using (var unitofWork = new UnitOfWork(new TSDBContext()))
            {
                ship.Name = shipDTO.Name;
                ship.Latitude = shipDTO.GeolocationDTO.Latitude;
                ship.Longitude = shipDTO.GeolocationDTO.Longitude;
                ship.Velocity = shipDTO.Velocity;

                unitofWork.ShipRepository.Add(ship);
                unitofWork.Complete();
            }

            return Created(new Uri("GetShipById/" + ship.ID), shipDTO);
        }

        [HttpDelete]
        [Route("DeleteShip")]
        public IActionResult Delete(int id) 
        {
            using (var unitofWork = new UnitOfWork(new TSDBContext()))
            {
                var ship = unitofWork.ShipRepository.GetById(id);
                unitofWork.ShipRepository.Remove(ship);
                unitofWork.Complete();
            }

            return Ok("Deleted");
        }

        [HttpGet]
        [Route("GetClosestPortToShip")]
        public IActionResult GetClosestPortToShipAndEstimatedArrival(int id)
        {
            return Ok(shipService.GetClosestPortToShipAndEstimatedArrival(id));
        }
    }
}
