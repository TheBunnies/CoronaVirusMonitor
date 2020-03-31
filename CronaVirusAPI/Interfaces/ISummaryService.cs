using System.Threading.Tasks;
using CronaVirusAPI.Models;

namespace CronaVirusAPI.Interfaces
{
    public interface ISummaryService
    {
        Task<SummaryDTO> GetData();
    }
}
