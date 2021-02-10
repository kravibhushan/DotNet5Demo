using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;

namespace DotNet5.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly ILogger<ValuesController> _logger;

        public ValuesController(ILogger<ValuesController> logger)
        {
            _logger = logger;
            _logger.LogInformation("Writing to log file with INFORMATION severity level.");
        
            _logger.LogDebug("Writing to log file with DEBUG severity level."); 
        
            _logger.LogWarning("Writing to log file with WARNING severity level.");
        
            _logger.LogError("Writing to log file with ERROR severity level.");
        
            _logger.LogCritical("Writing to log file with CRITICAL severity level.");

            //this.logger = logger;
        }
        public List<string> get() 
        {
            List<string> lstString = new List<string>() { "Value1", "Value2", "Value3" };
            return lstString;
        }
    }
}
