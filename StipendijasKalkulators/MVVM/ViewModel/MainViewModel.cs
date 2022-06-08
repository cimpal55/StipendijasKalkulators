using StipendijasKalkulators.Core;

namespace StipendijasKalkulators.ViewModel
{
    internal class MainViewModel : ObservableObject
    {
        public object CurrentView
        {
            get => _currentView;
            set
            {
                _currentView = value;
                OnPropertyChanged();
            }
        }
        public string Title
        {
            get => _title;
            set => Set(ref _title, value);
        }

        private object _currentView;

        private string _title = "Calculator Stipendijas";

    }
}
