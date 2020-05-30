using Microsoft.Extensions.DependencyInjection;
using ParkWifi.ApplicationServices.GetParkNameListUseCase;
using ParkWifi.ApplicationServices.Ports.Cache;
using ParkWifi.ApplicationServices.Repositories;
using ParkWifi.DesktopClient.InfrastructureServices.ViewModels;
using ParkWifi.DomainObjects;
using ParkWifi.DomainObjects.Ports;
using ParkWifi.InfrastructureServices.Cache;
using ParkWifi.InfrastructureServices.Repositories;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace ParkWifi.DesktopClient
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private readonly ServiceProvider _serviceProvider;

        public App()
        {
            var serviceCollection = new ServiceCollection();
            ConfigureServices(serviceCollection);
            _serviceProvider = serviceCollection.BuildServiceProvider();
        }

        private void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<IDomainObjectsCache<parkwifi>, DomainObjectsMemoryCache<parkwifi>>();
            services.AddSingleton<NetworkParkWifiRepository>(
                x => new NetworkParkWifiRepository("localhost", 80, useTls: false, x.GetRequiredService<IDomainObjectsCache<parkwifi>>())
            );
            services.AddSingleton<CachedReadOnlyParkWifiRepository>(
                x => new CachedReadOnlyParkWifiRepository(
                    x.GetRequiredService<NetworkParkWifiRepository>(), 
                    x.GetRequiredService<IDomainObjectsCache<parkwifi>>()
                )
            );
            services.AddSingleton<IReadOnlyParkWifiRepository>(x => x.GetRequiredService<CachedReadOnlyParkWifiRepository>());
            services.AddSingleton<IGetParkWifiListUseCase, GetParkWifiListUseCase>();
            services.AddSingleton<MainViewModel>();
            services.AddSingleton<MainWindow>();
        }

        private void OnStartup(object sender, StartupEventArgs args)
        {
            var mainWindow = _serviceProvider.GetService<MainWindow>();
            mainWindow.Show();
        }
    }
}
