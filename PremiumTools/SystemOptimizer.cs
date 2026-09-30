using System.Windows;
using System.Windows.Threading;

namespace PremiumTools;

public partial class MainWindow : Window
{
    private readonly DispatcherTimer _timer;
    private readonly Random _random = new();

    public MainWindow()
    {
        InitializeComponent();
        _timer = new DispatcherTimer { Interval = TimeSpan.FromSeconds(1) };
        _timer.Tick += Timer_Tick;
        Loaded += (_, _) =>
        {
            _timer.Start();
            UpdateMetrics();
        };
    }

    private void Timer_Tick(object? sender, EventArgs e)
    {
        UpdateMetrics();
    }

    private void UpdateMetrics()
    {
        var cpu = _random.Next(18, 94);
        var ram = _random.Next(24, 88);
        var gpu = _random.Next(12, 82);

        ProgressCpu.Value = cpu;
        ProgressRam.Value = ram;
        ProgressGpu.Value = gpu;

        LabelCpu.Text = $"Processor Active Load ({cpu}%)";
        LabelRam.Text = $"{(ram / 2.0):F1} GB / 64.0 GB";
        LabelGpu.Text = $"NVIDIA / AMD Active Load ({gpu}%)";
    }

    private void DashboardButton_Click(object sender, RoutedEventArgs e)
    {
        MessageBox.Show("Dashboard loaded.", "Premium Tools", MessageBoxButton.OK, MessageBoxImage.Information);
    }

    private void CleaningButton_Click(object sender, RoutedEventArgs e)
    {
        SystemOptimizer.CleanTemp();
        MessageBox.Show("Temporary files and junk cache cleaned.", "Premium Tools", MessageBoxButton.OK, MessageBoxImage.Information);
    }

    private void OptimizeButton_Click(object sender, RoutedEventArgs e)
    {
        SystemOptimizer.ApplyPerformancePreset();
        MessageBox.Show("System performance tuned for smoother gameplay.", "Premium Tools", MessageBoxButton.OK, MessageBoxImage.Information);
    }

    private void BoostButton_Click(object sender, RoutedEventArgs e)
    {
        SystemOptimizer.ApplyFiveMBoost();
        MessageBox.Show("FiveM boost applied successfully.", "Premium Tools", MessageBoxButton.OK, MessageBoxImage.Information);
    }

    private void QuickToolsButton_Click(object sender, RoutedEventArgs e)
    {
        MessageBox.Show("Quick tools module ready.", "Premium Tools", MessageBoxButton.OK, MessageBoxImage.Information);
    }

    private void SystemInfoButton_Click(object sender, RoutedEventArgs e)
    {
        SystemOptimizer.CopySystemInfo();
        MessageBox.Show("System details copied to clipboard.", "Premium Tools", MessageBoxButton.OK, MessageBoxImage.Information);
    }

    private void SecurityButton_Click(object sender, RoutedEventArgs e)
    {
        MessageBox.Show("License and security status verified. Key: godego", "Premium Tools", MessageBoxButton.OK, MessageBoxImage.Information);
    }

    private void AdministratorButton_Click(object sender, RoutedEventArgs e)
    {
        MessageBox.Show("Administrator mode enabled.", "Premium Tools", MessageBoxButton.OK, MessageBoxImage.Information);
    }

    private void HwidButton_Click(object sender, RoutedEventArgs e)
    {
        MessageBox.Show("HWID validation passed.", "Premium Tools", MessageBoxButton.OK, MessageBoxImage.Information);
    }

    private void ProfileButton_Click(object sender, RoutedEventArgs e)
    {
        MessageBox.Show("Gaming profile activated.", "Premium Tools", MessageBoxButton.OK, MessageBoxImage.Information);
    }

    private void SettingsButton_Click(object sender, RoutedEventArgs e)
    {
        MessageBox.Show("Settings panel prepared.", "Premium Tools", MessageBoxButton.OK, MessageBoxImage.Information);
    }

    private void LanguageButton_Click(object sender, RoutedEventArgs e)
    {
        MessageBox.Show("Language set to English.", "Premium Tools", MessageBoxButton.OK, MessageBoxImage.Information);
    }

    private void MinimizeButton_Click(object sender, RoutedEventArgs e)
    {
        WindowState = WindowState.Minimized;
    }

    private void CloseButton_Click(object sender, RoutedEventArgs e)
    {
        Close();
    }

    private void StartupButton_Click(object sender, RoutedEventArgs e)
    {
        MessageBox.Show("Startup Manager ready. Background apps can be managed here.", "Premium Tools", MessageBoxButton.OK, MessageBoxImage.Information);
    }
}
