using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorUI.Data
{
    public class CounterService : ICounterService
    {
        private readonly ILogger<CounterService> _logger;

        public int CounterValue { get; private set; }

        public CounterService(ILogger<CounterService> logger)
        {
            _logger = logger;
        }
        public void IncreamentCounter()
        {
            CounterValue += 1;
            _logger.LogInformation("The counter was incremented to {CounterValue}", CounterValue);
        }
    }
}
