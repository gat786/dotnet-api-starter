using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [Route("/api")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        [HttpGet]
        public Message Get()
        {
            return new Message
            {
                MessageId = 1,
                MessageText = "Hello World"
            };
        }
    }
}
