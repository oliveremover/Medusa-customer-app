using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace BlazorHybridApp.ViewModel
{
    public class HomePageViewModel : INotifyPropertyChanged
    {
        private string _welcomeMessage;
        public string WelcomeMessage
        {
            get => _welcomeMessage;
            set
            {
                if (_welcomeMessage != value)
                {
                    _welcomeMessage = value;
                    OnPropertyChanged();
                }
            }
        }

        public HomePageViewModel()
        {
            WelcomeMessage = "Welcome to the Medusa Customer App!";
        }

        public async Task RefreshDataAsync()
        {
            // Simulate data loading
            await Task.Delay(500);
            WelcomeMessage = "Data refreshed at " + System.DateTime.Now.ToShortTimeString();
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}