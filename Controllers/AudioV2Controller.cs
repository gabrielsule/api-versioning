using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiVersioning.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiVersioning.Controllers
{
    [ApiVersion("2.0")]
    [Route("api/audio")]
    [ApiController]
    public class AudioV2Controller : ControllerBase
    {
        static List<AudioV2> audio = new List<AudioV2>()
        {
            new AudioV2(){id=2, name="Moby", rate=5 },
            new AudioV2(){id=2, name="Subsonica", rate=4 }
        };

        // GET: api/AudioV2
        [HttpGet]
        public IEnumerable<AudioV2> Get()
        {
            return audio;
        }
    }
}
