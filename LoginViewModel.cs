using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace NavigationService
{
    public partial class LoginViewModel : ViewModelBase
    {
        private readonly INaviService naviService;
        private readonly UserService userService;

        [ObservableProperty]
        private string? userName;

        public LoginViewModel(INaviService naviService, UserService userService)
        {
            this.naviService = naviService;
            this.userService = userService;
        }

        [RelayCommand]
        public void NaviToHome()
        {
            userService.UserName = UserName;
            naviService.NavigateTo<HomeViewModel>();
        }
    }
}
