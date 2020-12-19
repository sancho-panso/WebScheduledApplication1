using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using WebScheduledApplication1.Controllers;

namespace WebScheduledApplication1.Services
{
    public class MyCronJob : CronJobService
    {
        private readonly ILogger<MyCronJob> _logger;

        public MyCronJob(IScheduleConfig<MyCronJob> config, ILogger<MyCronJob> logger)
            : base(config.CronExpression, config.TimeZoneInfo)
        {
            _logger = logger;
        }

        public override Task StartAsync(CancellationToken cancellationToken)
        {
            _logger.LogInformation("CronJob starts.");
            return base.StartAsync(cancellationToken);
        }

        public override Task DoWork(CancellationToken cancellationToken)
        {
             _logger.LogInformation($"{DateTime.Now:hh:mm:ss} CronJob  is working.");
            
            return Task.CompletedTask;
        }

        public override Task StopAsync(CancellationToken cancellationToken)
        {
            _logger.LogInformation("CronJob is stopping.");
            return base.StopAsync(cancellationToken);
        }
    }
}
