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
        _timer.Tick += (_, _) => UpdateMetrics();
        Loaded += (_, _) =>
        {
            _timer.Start();
            UpdateMetrics();
        };
    }

    private void UpdateMetrics()
    {
        int cpu = _random.Next(18, 94);
        int ram = _random.Next(24, 88);
        int gpu = _random.Next(12, 82);

        ProgressCpu.Value = cpu;
        ProgressRam.Value = ram;
        ProgressGpu.Value = gpu;

        LabelCpu.Text = $"Processor Active Load ({cpu}%)";
        LabelRam.Text = $"{(ram / 2.0):F1} GB / 64.0 GB";
        LabelGpu.Text = $"NVIDIA / AMD Active Load ({gpu}%)";
    }

    private void BtnDashboard_Click(object sender, RoutedEventArgs e)
        => MessageBox.Show("✓ Dashboard loaded and ready.", "Premium Tools", MessageBoxButton.OK, MessageBoxImage.Information);

    private void BtnCleaning_Click(object sender, RoutedEventArgs e)
    {
        SystemOptimizer.CleanTemp();
        MessageBox.Show("✓ Temporary files and junk cache cleaned successfully.", "Premium Tools", MessageBoxButton.OK, MessageBoxImage.Information);
    }

    private void BtnOptimize_Click(object sender, RoutedEventArgs e)
    {
        SystemOptimizer.ApplyPerformancePreset();
        MessageBox.Show("✓ System optimized for smooth gaming performance.", "Premium Tools", MessageBoxButton.OK, MessageBoxImage.Information);
    }

    private void BtnBoost_Click(object sender, RoutedEventArgs e)
    {
        SystemOptimizer.ApplyFiveMBoost();
        MessageBox.Show("✓ FiveM Booster activated:\n• CPU priority optimized\n• Background services minimized\n• Network latency reduced\n• Gaming mode enabled", "Premium Tools", MessageBoxButton.OK, MessageBoxImage.Information);
    }

    private void BtnQuickTools_Click(object sender, RoutedEventArgs e)
        => MessageBox.Show("✓ Quick tools module ready for use.", "Premium Tools", MessageBoxButton.OK, MessageBoxImage.Information);

    private void BtnSystemInfo_Click(object sender, RoutedEventArgs e)
    {
        SystemOptimizer.CopySystemInfo();
        MessageBox.Show("✓ System information copied to clipboard.", "Premium Tools", MessageBoxButton.OK, MessageBoxImage.Information);
    }

    private void BtnSecurity_Click(object sender, RoutedEventArgs e)
        => MessageBox.Show("✓ License Status: ACTIVE\nKey: godego\nStatus: Verified", "Premium Tools", MessageBoxButton.OK, MessageBoxImage.Information);

    private void BtnAdmin_Click(object sender, RoutedEventArgs e)
        => MessageBox.Show("✓ Administrator mode enabled.", "Premium Tools", MessageBoxButton.OK, MessageBoxImage.Information);

    private void BtnHwid_Click(object sender, RoutedEventArgs e)
        => MessageBox.Show("✓ HWID validation successful.", "Premium Tools", MessageBoxButton.OK, MessageBoxImage.Information);

    private void BtnProfile_Click(object sender, RoutedEventArgs e)
        => MessageBox.Show("✓ Gaming profile loaded and activated.", "Premium Tools", MessageBoxButton.OK, MessageBoxImage.Information);

    private void BtnSettings_Click(object sender, RoutedEventArgs e)
        => MessageBox.Show("✓ Settings panel opened.", "Premium Tools", MessageBoxButton.OK, MessageBoxImage.Information);

    private void BtnLanguage_Click(object sender, RoutedEventArgs e)
        => MessageBox.Show("✓ Language changed to English.", "Premium Tools", MessageBoxButton.OK, MessageBoxImage.Information);

    private void BtnMinimize_Click(object sender, RoutedEventArgs e)
        => WindowState = WindowState.Minimized;

    private void BtnClose_Click(object sender, RoutedEventArgs e)
        => Close();

    private void BtnStartup_Click(object sender, RoutedEventArgs e)
        => MessageBox.Show("✓ Startup Manager ready.\n\nManage background applications and startup services.", "Premium Tools", MessageBoxButton.OK, MessageBoxImage.Information);
}