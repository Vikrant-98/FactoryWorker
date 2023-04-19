using FactoryWorker_6._0;
using FactoryWorker_6._0.Process;

IHost host = Host.CreateDefaultBuilder(args)
    .ConfigureServices(services =>
    {
        services.AddHostedService<Worker>();
        services.AddTransient<Processor>();
    })
    .Build();

await host.RunAsync();
