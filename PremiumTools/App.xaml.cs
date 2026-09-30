using System.Windows;

namespace PremiumTools;

public partial class App : Application
{
    private void Application_Startup(object sender, StartupEventArgs e)
    {
        var activationWindow = new ActivationWindow();
        activationWindow.Show();
    }
}
