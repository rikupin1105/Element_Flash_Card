namespace ElementFlashCard.Mobile.Service
{
    public interface INavigationService
    {
        Task NavigateToAsync(string route, object parameter = null);
        Task GoBackAsync();
    }

    public class NavigationService : INavigationService
    {
        private readonly IServiceProvider _serviceProvider;

        public NavigationService(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public async Task NavigateToAsync(string route, object parameter = null)
        {
            if (parameter != null)
            {
                var navigationParameter = new Dictionary<string, object>
                {
                    { "Parameter", parameter }
                };
                await Shell.Current.GoToAsync(route, navigationParameter);
            }
            else
            {
                await Shell.Current.GoToAsync(route);
            }
        }

        public async Task GoBackAsync()
        {
            await Shell.Current.GoToAsync("..");
        }
    }

}
