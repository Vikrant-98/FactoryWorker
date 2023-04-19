using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryWorker_6._0.Service
{
    public class EmailServices : IFactoryServices
    {

        private readonly ILogger<EmailServices> _logger;

        private readonly IConfiguration _configuration;

        public EmailServices(ILogger<EmailServices> logger, IConfiguration configuration) 
        {
            _logger = logger;
            _configuration = configuration;
        }

        public async Task Process() 
        {
            
        }
    }
}
