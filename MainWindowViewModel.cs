using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NavigationService
{
    public partial class MainWindowViewModel : ViewModelBase
    {

        //public
        private readonly INaviService Navigator;

        [ObservableProperty]
        private ViewModelBase currentViewModel;

        public MainWindowViewModel(INaviService navigationService)
        {
            Navigator = navigationService;
            Navigator.CurrentViewModelChanged += OnVMChanged;
            Navigator.NavigateTo<LoginViewModel>();
        }

        public void OnVMChanged()
        {
            CurrentViewModel = Navigator.CurrentViewModel!;  

        }
    }
}
