﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace psDigitalVault.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class psDigitalVaultWithoutCrudHomeController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "value1", "value2" };
        }

        //GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "HarishGK";
        }

        //public IActionResult Index()
        //{
        //    return View();
        //}
    }
}
