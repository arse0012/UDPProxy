using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ModelLib;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SensorREST.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SensorController : ControllerBase
    {
        private static List<SensorData> _sensor = new List<SensorData>()
        {
            new SensorData(1, "Room D3.04","1","900")
        };

        // GET: api/<SensorController>
        [HttpGet]
        public IEnumerable<SensorData> Get()
        {
            return _sensor;
        }

        // GET api/<SensorController>/5
        [HttpGet("{id}")]
        public SensorData Get(int id)
        {
            return _sensor.Find(i => i.Id == id);
        }

        // POST api/<SensorController>
        [HttpPost]
        public void Post([FromBody] SensorData value)
        {
            _sensor.Add(value);
        }

        // PUT api/<SensorController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<SensorController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
