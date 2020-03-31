using System;
using System.Collections.Generic;

namespace CronaVirusAPI.Models
{
    public class SummaryDTO
    {
        public IEnumerable<CountryDTO> Countries { get; set; }
        public DateTime Date { get; set; }
    }
}
