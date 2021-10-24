using amuNewCrono.Models;
using amuNewCrono.Models.Interfaces;
using amuNewCrono.ViewModels;
using amuNewCrono.ViewModels.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System.Windows;

namespace amuNewCrono
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    /// 
    public partial class App : Application
    {
        private readonly ServiceProvider _serviceProvider;

        public App()
        {
            ServiceCollection services = new ServiceCollection();
            ConfigureServices(services);
            _serviceProvider = services.BuildServiceProvider();
        }

        private void ConfigureServices(ServiceCollection services)
        {
            services.AddSingleton<MainWindow>();
            services.AddSingleton<ICronoModel, cronoModel>();
            services.AddSingleton<ICronoViewModel, cronoViewModel>(); 
        }

        private void OnStartup(object sender, StartupEventArgs e)
        {
            var mainWindow = _serviceProvider.GetService<MainWindow>();
             mainWindow.Show();
        }
    }
}
