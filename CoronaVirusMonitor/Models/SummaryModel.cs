using System;
using System.Collections.Generic;

namespace CoronaVirusMonitor.Models
{
    public class SummaryModel : ObservableObject
    {
        private IEnumerable<CountryModel> _countries;

        public IEnumerable<CountryModel> Countries
        {
            get => _countries;
            set
            {
                _countries = value;
                OnPropertyChanged(nameof(_countries));
            }
        }

        private DateTime _date;

        public DateTime Date
        {
            get => _date;
            set
            {
                _date = value;
                OnPropertyChanged(nameof(Date));
            }
        }
    }
}
