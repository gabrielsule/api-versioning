using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiVersioning.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiVersioning.Controllers
{
    [ApiVersion("1.0")]
    [Route("api/audio")]
    [ApiController]
    public class AudioV1Controller : ControllerBase
    {
        static List<AudioV1> audio = new List<AudioV1>() 
        {
            new AudioV1(){id=1,name="Moby" },
            new AudioV1(){id=2,name="Subsonica" }
        };

        // GET: api/AudioV1
        [HttpGet]
        public IEnumerable<AudioV1> Get()
        {
            return audio;
        }
    }
}
