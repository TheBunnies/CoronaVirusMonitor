namespace CoronaVirusMonitor.Models
{
    public class CountryModel : ObservableObject
    {
        private string _country;
        public string Country
        {
            get => _country;
            set
            {
                _country = value;
                OnPropertyChanged(nameof(Country));
            }
        }

        private string _slug;
        public string Slug
        {
            get => _slug;
            set
            {
                _slug = value;
                OnPropertyChanged(nameof(Slug));
            }
        }

        private int _newConfirmed;
        public int NewConfirmed
        {
            get => _newConfirmed;
            set
            {
                _newConfirmed = value;
                OnPropertyChanged(nameof(NewConfirmed));
            }
        }

        private int _totalConfirmed;
        public int TotalConfirmed
        {
            get => _totalConfirmed;
            set
            {
                _totalConfirmed = value;
                OnPropertyChanged(nameof(TotalConfirmed));
            }
        }

        private int _newDeaths;
        public int NewDeaths
        {
            get => _newDeaths;
            set
            {
                _newDeaths = value;
                OnPropertyChanged(nameof(NewDeaths));
            }
        }

        private int _totalDeaths;
        public int TotalDeaths
        {
            get => _totalDeaths;
            set
            {
                _totalDeaths = value;
                OnPropertyChanged(nameof(TotalDeaths));
            }
        }

        private int _newRecovered;
        public int NewRecovered
        {
            get => _newRecovered;
            set
            {
                _newRecovered = value;
                OnPropertyChanged(nameof(NewRecovered));
            }
        }

        private int _totalRecovered;
        public int TotalRecovered
        {
            get => _totalRecovered;
            set
            {
                _totalRecovered = value;
                OnPropertyChanged(nameof(TotalRecovered));
            }
        }
    }
}
