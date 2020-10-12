using System;
using System.Collections.Generic;
using BeforeIDie.Models;
using Microsoft.AspNetCore.Mvc;

namespace BeforeIDie.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StatusController : Controller
    {
        [HttpGet]
        [Route("")]
        public ActionResult<IEnumerable<string>> GetAll()
        {
            return Enum.GetNames(typeof(Status));
        }
    }
}