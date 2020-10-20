using Microsoft.Extensions.Logging;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace SortJob.Api
{
    public class SortJobData : ISortJobData
    {
        private readonly ILogger<SortJobData> _logger;

        public SortJobData(ILogger<SortJobData> logger)
        {
            _logger = logger;
        }

        public async Task<SortJob> Process(SortJob job)
        {
            _logger.LogInformation("Start Processing job with ID '{JobId}'.", job.Id);

            var stopwatch = Stopwatch.StartNew();

            var output = job.InputData.OrderBy(n => n).ToArray();
            await Task.Delay(10000);

            var duration = stopwatch.Elapsed;

            _logger.LogInformation("Process Completed for Job ID '{JobId}'. Duration: '{Duration}'.", job.Id, duration);

            return new SortJob(
                id: job.Id,
                status: JobStatus.Completed,
                duration: duration,
                inputData: job.InputData,
                outputData: output);
        }
    }
}
