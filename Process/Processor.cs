using FactoryWorker_6._0.Service;

namespace FactoryWorker_6._0.Process
{
    public class Processor
    {
        private readonly EmailServices _emailServices;

        private readonly ILogger<Processor> _logger;

        private readonly IConfiguration _configuration;

        public Processor(EmailServices emailServices, ILogger<Processor> logger, IConfiguration configuration) 
        {
            _emailServices = emailServices;
            _logger = logger;
            _configuration = configuration;
        }

        public IFactoryServices FactoryServices() 
        {
            IFactoryServices factoryServices = null;
            factoryServices = _emailServices;
            return factoryServices;
        }


    }
}
