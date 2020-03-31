using System;
using System.Collections.Generic;
using CronaVirusAPI.Models;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Input;
using AutoMapper;
using CoronaVirusMonitor.Commands;
using CoronaVirusMonitor.Models;
using CronaVirusAPI.Interfaces;
using CronaVirusAPI.Services;

namespace CoronaVirusMonitor.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        public ObservableCollection<CountryModel> Countries { get; private set; }

        private CountryModel _selectedCountry;

        public CountryModel SelectedCountry
        {
            get => _selectedCountry;
            set
            {
                _selectedCountry = value;
                OnPropertyChanged(nameof(SelectedCountry));
            }
        }
        
        private ISummaryService _serivce { get; set; }

        private ICollectionView countriesView;

        private string _filter;

        public string Filter
        {
            get => _filter;
            set
            {
                if (value != _filter)
                {
                    _filter = value;
                    countriesView.Refresh();
                    OnPropertyChanged(nameof(Filter));
                }
            }
        }

        private ICommand _refreshCommand;

        public ICommand RefreshCommand
        {
            get
            {
                return _refreshCommand ??= new RelayCommand(obj =>
                {
                    _selectedCountry = null;
                    Task.Run(this.GetCollection).Wait();
                });
            }
        }


        public MainViewModel()
        {
            Task.Run(this.GetCollection).Wait();

            countriesView = CollectionViewSource.GetDefaultView(Countries);
            countriesView.Filter = o =>
                String.IsNullOrEmpty(Filter) || ((CountryModel) o).Country.ToUpper().Contains(Filter.ToUpper());

        }

        private async Task GetCollection()
        {
            var configuration = new MapperConfiguration(cfg => cfg.CreateMap<CountryDTO, CountryModel>());

            Mapper mapper = new Mapper(configuration);

            _serivce = new SummaryService();

            var summary = await _serivce.GetData();

            var countries = summary.Countries;

            IEnumerable<CountryModel> list = mapper.Map<IEnumerable<CountryDTO>, IEnumerable<CountryModel>>(countries);

            Countries = new ObservableCollection<CountryModel>(list.Where(x => !string.IsNullOrWhiteSpace(x.Country)));
        }
    }
}
