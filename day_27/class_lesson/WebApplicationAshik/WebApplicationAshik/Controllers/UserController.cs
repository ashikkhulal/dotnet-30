using infrastructure;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;

namespace WebApplicationAshik.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {

        [HttpGet]
        public List<User> Get()
        {
            return Database.GetUsers(); // new Database().GetUsers()
        }

        [HttpGet("query")]
        public List<User> GetSpecificName(string name, [FromQuery] string location)
        {
            List<User> allData = Database.GetUsers();
            List<User> filteredData = allData.Where(x=>x.FirstName.Equals(name) && x.Location.Equals(location)).ToList();

            return filteredData;
        }
    }
}
