using Microsoft.Extensions.DependencyInjection;
using System.Windows;

namespace NavigationService
{
    public partial class App : Application
    {
        public IServiceProvider Services { get; }
        public static new App Current = (App)Application.Current;
        public App()
        {
            var container = new ServiceCollection();

            container.AddSingleton<MainWindow>();
            container.AddSingleton<MainWindowViewModel>();
            container.AddTransient<LoginViewModel>();
            container.AddTransient<HomeViewModel>();
            container.AddSingleton<UserService>();
            container.AddSingleton<INaviService, NaviService>();

            Services = container.BuildServiceProvider();
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            MainWindow = Services.GetService<MainWindow>();
            MainWindow!.Show();
        }
    }

}
