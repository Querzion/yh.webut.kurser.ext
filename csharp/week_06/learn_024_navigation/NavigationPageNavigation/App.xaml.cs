using NavigationPageNavigation.Pages;

namespace NavigationPageNavigation
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new ProductListPage());
        }
    }
}
