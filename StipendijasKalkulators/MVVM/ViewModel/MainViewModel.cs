using System;
using System.Security.RightsManagement;
using StipendijasKalkulators.Core;
using StipendijasKalkulators.MVVM.ViewModel;

namespace StipendijasKalkulators.MVVM.ViewModel
{
    internal class MainViewModel : ObservableObject
    {
        public RelayCommand CalculatorViewCommand { get; set; }
        public RelayCommand HomeViewCommand { get; set; }

        public HomeViewModel HomeVm { get; set; }
        public CalculatorViewModel CalcVm { get; set; }

        public object CurrentView
        {
            get => _currentView;
            set
            {
                _currentView = value;
                OnPropertyChanged();
            }
        }

        public MainViewModel()
        {
            HomeVm = new HomeViewModel();
            CalcVm = new CalculatorViewModel();

            CurrentView = HomeVm;

            HomeViewCommand = new RelayCommand(o => { CurrentView = HomeVm; });
            CalculatorViewCommand = new RelayCommand(o => { CurrentView = CalcVm; });

        }

        private object _currentView;

    }
}
