using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ContactUs.Models;
using ContactUs.Models.Repository;
using Microsoft.AspNetCore.Http;

namespace ContactUs.Controllers
{
    [Route("api/[controller]")]
    public class ContactUsController : Controller
    {
        private readonly IDataRepository<ContactUsMessage> _dataRepository;

        public ContactUsController(IDataRepository<ContactUsMessage> dataRepository)
        {
            _dataRepository = dataRepository;
        }


        [HttpPost]
        public IActionResult Post([FromBody] ContactUsMessage message)
        {
            if (message == null)
            {
                return BadRequest("Message is null.");
            }
            else
            {
                try
                {
                    _dataRepository.Add(message);
                }
                catch (Exception e)
                {
                    return StatusCode(StatusCodes.Status500InternalServerError);
                }

                return Ok();
            }
        }

    }
}
