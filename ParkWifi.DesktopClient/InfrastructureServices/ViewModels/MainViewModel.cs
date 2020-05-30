using ParkWifi.ApplicationServices.GetParkNameListUseCase;
using ParkWifi.ApplicationServices.Ports;
using ParkWifi.DomainObjects;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Threading.Tasks;

namespace ParkWifi.DesktopClient.InfrastructureServices.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {
        private readonly IGetParkWifiListUseCase _getParkWifiListUseCase;

        public MainViewModel(IGetParkWifiListUseCase getParkWifiListUseCase)
            => _getParkWifiListUseCase = getParkWifiListUseCase;

        private Task<bool> _loadingTask;
        private parkwifi _currentParkWifi;
        private ObservableCollection<parkwifi> _parkwifis;

        public event PropertyChangedEventHandler PropertyChanged;

        public parkwifi CurrentParkWifi
        {
            get => _currentParkWifi; 
            set
            {
                if (_currentParkWifi != value)
                {
                    _currentParkWifi = value;
                    OnPropertyChanged(nameof(CurrentParkWifi));
                }
            }
        }

        private async Task<bool> LoadParkWifis()
        {
            var outputPort = new OutputPort();
            bool result = await _getParkWifiListUseCase.Handle(GetParkWifiListUseCaseRequest.CreateAllParkWifisRequest(), outputPort);
            if (result)
            {
                ParkWifis = new ObservableCollection<parkwifi>(outputPort.ParkWifis);
            }
            return result;
        }

        public ObservableCollection<parkwifi> ParkWifis
        {
            get 
            {
                if (_loadingTask == null)
                {
                    _loadingTask = LoadParkWifis();
                }
                
                return _parkwifis; 
            }
            set
            {
                if (_parkwifis != value)
                {
                    _parkwifis = value;
                    OnPropertyChanged(nameof(ParkWifis));
                }
            }
        }

        private void OnPropertyChanged(string propertyName)
        {
           PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private class OutputPort : IOutputPort<GetParkWifiListUseCaseResponse>
        {
            public IEnumerable<parkwifi> ParkWifis { get; private set; }

            public void Handle(GetParkWifiListUseCaseResponse response)
            {
                if (response.Success)
                {
                    ParkWifis = new ObservableCollection<parkwifi>(response.ParkWifis);
                }
            }
        }
    }
}
