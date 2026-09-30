using System.Windows;

namespace PremiumTools;

public partial class App : Application
{
    private void Application_Startup(object sender, StartupEventArgs e)
    {
        ActivationWindow activationWindow = new();
        activationWindow.Show();
    }
}
