using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebDemo.Controllers;
using WebDemo.Model;

namespace WebDemo.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ManagerController : ControllerBase
    {
        public List<Employee> listManager = new List<Employee>();
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<Employee>> Get()
        {
            foreach(var item in WebDemo.Controllers.EmployeeController.listEmployees)
            {
                if (item.Designation.Equals("Manager"))
                    listManager.Add(item);
            }
            return listManager;
        }

        [HttpGet("{id}")]
        public ActionResult<IEnumerable<Employee>> Get(int id)
        {
            foreach (var item in WebDemo.Controllers.EmployeeController.listEmployees)
            {
                if (item.DesignationId==id && !item.Designation.Equals("Manager"))
                    listManager.Add(item);
            }
            return listManager;
        }

    }
}