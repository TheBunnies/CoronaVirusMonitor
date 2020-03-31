using System;
using System.Threading.Tasks;
using CronaVirusAPI.Models;
using CronaVirusAPI.Services;
using System.Linq;

namespace Test
{
    class Program
    {
        static async Task Main(string[] args)
        {
            SummaryService service = new SummaryService();

            SummaryDTO dto = await service.GetData();

        }
    }
}
