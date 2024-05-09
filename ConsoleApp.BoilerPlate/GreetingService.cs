using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace ConsoleApp.BoilerPlate
{
    public class GreetingService : IGreetingService
    {
        private readonly ILogger<GreetingService> _log;
        private readonly IConfiguration _config;
        private readonly ICalculatorService _calculatorService;

        public GreetingService(ILogger<GreetingService> log, IConfiguration config,ICalculatorService calculatorService)
        {
            _log = log;
            _config = config;
            _calculatorService = calculatorService;
        }
        public void Run()
        {
            for (int i = 0; i < _config.GetValue<int>("LoopTimes"); i++)
            {
                _log.LogInformation("Run number {runNumber}", i);
            }

            _calculatorService.Add();
        }
    }
}
