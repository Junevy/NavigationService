using Microsoft.Extensions.DependencyInjection;

namespace NavigationService
{ 
    /// <summary>
    /// 负责调度 current view model
    /// </summary>
    public class NaviService : INaviService
    {
        private static readonly Lazy<NaviService> _lazyNavigationService = new();
        public static NaviService Instance => _lazyNavigationService.Value;
        public event Action? CurrentViewModelChanged;

        private ViewModelBase currentViewModel;

        public ViewModelBase CurrentViewModel 
        { 
            get => currentViewModel; 
            set
            {
                currentViewModel = value;
                CurrentViewModelChanged?.Invoke();
            }
        }

        public void NavigateTo<T>() where T : ViewModelBase
            => CurrentViewModel = App.Current.Services.GetService<T>();
    }
}
