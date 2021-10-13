using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TruckManager.Application.Dtos;
using TruckManager.Application.Interfaces;

namespace TruckManager.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TruckController : Controller
    {
        private readonly IApplicationServiceTruck applicationServiceTruck;

        public TruckController(IApplicationServiceTruck applicationServiceTruck)
        {
            this.applicationServiceTruck = applicationServiceTruck;
        }

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return Ok(applicationServiceTruck.GetAll());
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(Guid id)
        {
            return Ok(applicationServiceTruck.GetById(id));
        }

        // POST api/values
        [HttpPost]
        public ActionResult Post([FromBody] TruckDto truckDTO)
        {
            try
            {
                if (truckDTO == null)
                    return NotFound();
                applicationServiceTruck.Add(truckDTO);
                return Ok();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // PUT api/values/5
        [HttpPut]
        public ActionResult Put([FromBody] TruckDto truckDTO)
        {
            try
            {
                if (truckDTO == null)
                    return NotFound();
                applicationServiceTruck.Update(truckDTO);
                return Ok();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // DELETE api/values/5
        [HttpDelete()]
        public ActionResult Delete([FromBody] TruckDto truckDTO)
        {
            try
            {
                if (truckDTO == null)
                    return NotFound();
                applicationServiceTruck.Remove(truckDTO);
                return Ok();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
