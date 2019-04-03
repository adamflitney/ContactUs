using ContactUs.Controllers;
using ContactUs.Models;
using ContactUs.Models.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using Xunit;

namespace ContactUsTest
{
    public class ContactUsControllerTest
    {
        ContactUsController _controller;
        IDataRepository<ContactUsMessage> _repository;

        public ContactUsControllerTest()
        {
            _repository = new ContactUsManagerFake();
            _controller = new ContactUsController(_repository);
        }

        [Fact]
        public void Post_NullObjectPassed_ReturnsBadRequest()
        {
            var badResponse = _controller.Post(null);

            Assert.IsType<BadRequestObjectResult>(badResponse);
        }

        [Fact]
        public void Post_InvalidObjectPassed_ReturnsBadRequest()
        {
            var invalidObject = new ContactUsMessage();

            var badResponse = _controller.Post(invalidObject);

            Assert.IsType<BadRequestObjectResult>(badResponse);
        }

        [Fact]
        public void Post_ValidObjectPassed_ReturnsOkResult()
        {
            var validObject = new ContactUsMessage()
            {
                senderName = "Bob",
                emailAddress = "bob@bobajob.co.uk",
                message = "Hi! We are looking for a web developer for a new project. Please email back if you are interested."
            };

            var okResponse = _controller.Post(validObject);

            Assert.IsType<OkObjectResult>(okResponse);
        }

    }

}
