# netCore Api Versioning

### Instalar 
```bash
Install-Package Microsoft.AspNetCore.Mvc.Versioning -Version 4.1.1
```

### Modificación
#### startup.cs
```csharp
public void ConfigureServices(IServiceCollection services)
{
    services.AddControllers();
    services.AddApiVersioning(r => r.ApiVersionReader = new MediaTypeApiVersionReader());
}
```

#### Crear Models
```csharp
namespace ApiVersioning.Models
{
    public class AudioV1
    {
        public int id { get; set; }
        public string name { get; set; }
    }
}
```

#### Crear Controllers
```csharp
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

        [HttpGet]
        public IEnumerable<AudioV1> Get()
        {
            return audio;
        }
    }
}
```

#### Ejecutar pruebas
```csharp
var client = new RestClient("http://localhost:50494/api/audio");
var request = new RestRequest(Method.GET);
request.AddHeader("accept", "application/json;v=1.0");
IRestResponse response = client.Execute(request);
```




