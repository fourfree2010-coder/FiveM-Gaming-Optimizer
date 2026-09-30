using System.Windows;

namespace PremiumTools;

public partial class ActivationWindow : Window
{
    private const string ActivationKey = "godego";

    public ActivationWindow()
    {
        InitializeComponent();
        KeyPasswordBox.Focus();
    }

    private void UnlockButton_Click(object sender, RoutedEventArgs e)
    {
        string enteredKey = KeyPasswordBox.Password;

        if (string.Equals(enteredKey.Trim(), ActivationKey, StringComparison.OrdinalIgnoreCase))
        {
            MainWindow mainWindow = new();
            mainWindow.Show();
            this.Close();
            return;
        }

        MessageBox.Show("Invalid activation key.\n\nCorrect key: godego", "Premium Tools", MessageBoxButton.OK, MessageBoxImage.Warning);
        KeyPasswordBox.Clear();
        KeyPasswordBox.Focus();
    }

    private void CancelButton_Click(object sender, RoutedEventArgs e)
    {
        Application.Current.Shutdown();
    }
}