using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace NavigationService
{
    public partial class HomeViewModel : ViewModelBase
    {
        private readonly INaviService naviService;
        private readonly UserService userService;
        [ObservableProperty]
        private string? userName;

        public HomeViewModel(INaviService naviService, UserService userService)
        {
            this.naviService = naviService;
            this.userService = userService;
            this.UserName = userService.UserName;
        }

        [RelayCommand]
        public void NaviToLogin()
        {
            userService.UserName = null;
            naviService.NavigateTo<LoginViewModel>();
        }
    }
}
