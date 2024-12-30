using Tabbed_Navigation.Tabs;

namespace Tabbed_Navigation
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new TabbedPages();
        }
    }
}
