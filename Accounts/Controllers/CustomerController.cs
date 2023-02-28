using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Accounts.IRepository;
using Microsoft.AspNetCore.Cors;
using Microsoft.Extensions.Configuration;

namespace Accounts.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private IConfiguration _config;
        private ICustomerRepository _oCustomerRepository = null;

        public CustomerController(IConfiguration config, ICustomerRepository oCustomerRepository)
        {
            _config = config;
            _oCustomerRepository = oCustomerRepository;
        }

        [EnableCors("CorsPolicy")]
        [HttpGet]
        [Route("Gets1")]
        public async Task<IActionResult> Gets1()
        {
            var list = await _oCustomerRepository.Gets1();
            return Ok(list);
        }
        [EnableCors("CorsPolicy")]
        [HttpGet]
        [Route("Gets2")]
        public async Task<IActionResult> Gets2()
        {
            var list = await _oCustomerRepository.Gets1();
            return Ok(list);
        }


    }
}
