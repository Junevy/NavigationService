namespace NavigationService
{
    public interface INaviService
    {
        void NavigateTo<T>() where T : ViewModelBase;
        event Action? CurrentViewModelChanged;
        ViewModelBase CurrentViewModel { get; set; }
    }
}
