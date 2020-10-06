using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Trips.Backservice.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Trips.Backservice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TripsController : ControllerBase
    {

        public TripsController(Repository repos)
        {
            _repository = repos;
        }

        private Models.Repository _repository;
            


        // GET: api/<TripsController>
        [HttpGet]
        public IEnumerable<Trip> Get()
        {
            return _repository.GetTrips();
        }

        // GET api/<TripsController>/5
        [HttpGet("{id}")]
        public Trip Get(int id)
        {
            return _repository.GetTripById(id);
        }

        // POST api/<TripsController>
        [HttpPost]
        public void Post([FromBody] Trip value)
        {

            _repository.AddTrip(value);
        }

        // PUT api/<TripsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Trip value)
        {
            _repository.UpdateTrip(value);
        }

        // DELETE api/<TripsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _repository.RemoveTrip(id);
        }
    }
}
