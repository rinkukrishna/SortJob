using System.Threading.Tasks;

namespace SortJob.Api
{
    public interface ISortJobData
    {
        Task<SortJob> Process(SortJob job);
    }
}