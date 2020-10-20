using System;
using System.Collections.Generic;

namespace SortJob.Api
{
    public class SortJob
    {
        public SortJob(Guid id, JobStatus status, TimeSpan? duration, IReadOnlyCollection<int> inputData, IReadOnlyCollection<int>? outputData)
        {
            Id = id;
            Status = status;
            Duration = duration;
            InputData = inputData;
            OutputData = outputData;
        }

        public Guid Id { get; }
        public JobStatus Status { get; }
        public TimeSpan? Duration { get; }
        public IReadOnlyCollection<int> InputData { get; }
        public IReadOnlyCollection<int>? OutputData { get; }
    }
}
