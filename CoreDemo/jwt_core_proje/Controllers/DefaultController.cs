﻿using jwt_core_proje.Dal;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace jwt_core_proje.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DefaultController : ControllerBase
    {
        public IActionResult Login()
        {
            return Created("", new BuildToken().CreateToken());
        }
        [Authorize]
        [HttpGet("action")]
        public IActionResult Page1()
        {
            return Ok("Sayfa 1 için girişiniz başarılı");
        }
    }
}
