using Microsoft.Maui.Controls.PlatformConfiguration;

namespace CollectionViewFooterBugReproSample
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();

            Application.Current.UserAppTheme = AppTheme.Dark;
        }
    }
}