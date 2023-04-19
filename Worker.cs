using FactoryWorker_6._0.Process;

namespace FactoryWorker_6._0
{
    public class Worker : BackgroundService
    {
        private readonly ILogger<Worker> _logger;
        private readonly Processor _process;

        public Worker(ILogger<Worker> logger, Processor process)
        {
            _logger = logger;
            _process = process;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                _logger.LogInformation("Worker running at: {time}", DateTimeOffset.Now);

                var emailService = _process.FactoryServices();
                await emailService.Process().ConfigureAwait(false);

                await Task.Delay(1000, stoppingToken);
            }
        }
    }
}