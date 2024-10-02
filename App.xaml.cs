using Microsoft.Maui.Handlers;
using Microsoft.Maui.Platform;


namespace BruttoNettoRechnerMauiUi
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();
        }
    }
}
