using Microsoft.Extensions.Logging;

namespace ConsoleApp.BoilerPlate
{
    public class CalculatorService : ICalculatorService
    {
        private readonly ILogger<CalculatorService> _log;

        public CalculatorService(ILogger<CalculatorService> log)
        {
            _log = log;
        }

        public void Add()
        {
            _log.LogInformation("Testing Add Service");
        }
    }
}
