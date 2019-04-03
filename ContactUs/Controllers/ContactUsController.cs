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
                if(message.senderName?.Length > 0 && message.emailAddress?.Length > 0 && message.message?.Length > 0)
                {
                    try
                    {
                        _dataRepository.Add(message);
                    }
                    catch (Exception e)
                    {
                        return StatusCode(StatusCodes.Status500InternalServerError);
                    }
                }
                else
                {
                    return BadRequest("1 or more required fields are empty.");
                }

                return Ok(new { success = "true"});
            }
        }

    }
}
