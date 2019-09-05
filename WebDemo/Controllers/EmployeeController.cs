using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebDemo.Model;

namespace WebDemo.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        public static List<Employee> listEmployees = new List<Employee>();
        static int newId = 1;

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<Employee>> Get()
        {
            return listEmployees;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<Employee> Get(int id)
        {
            return listEmployees[id - 1];
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] Employee value)
        {
            value.id = newId++;
            listEmployees.Add(value);
        } 

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Employee value)
        {
            listEmployees[id] = value;
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            listEmployees.RemoveAt(id);
        }
    }
}
