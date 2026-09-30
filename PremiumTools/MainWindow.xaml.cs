using System.Windows;
using System.Windows.Controls;
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
        int cpu = _random.Next(20, 95);
        int ram = _random.Next(25, 85);
        int gpu = _random.Next(15, 80);

        ProgressCpu.Value = cpu;
        ProgressRam.Value = ram;
        ProgressGpu.Value = gpu;

        LabelCpu.Text = $"Processor Active Load ({cpu}%)";
        LabelRam.Text = $"{(ram / 2.0):F1} GB / 64.0 GB";
        LabelGpu.Text = $"NVIDIA / AMD Active Load ({gpu}%)";
    }

    private void BtnDashboard_Click(object sender, RoutedEventArgs e)
        => MessageBox.Show("Dashboard loaded.", "Premium Tools");

    private void BtnCleaning_Click(object sender, RoutedEventArgs e)
        => MessageBox.Show("Cleaning temp files and junk cache...", "Premium Tools");

    private void BtnOptimize_Click(object sender, RoutedEventArgs e)
        => MessageBox.Show("Optimizing system for gaming performance...", "Premium Tools");

    private void BtnBoost_Click(object sender, RoutedEventArgs e)
        => MessageBox.Show("FiveM Booster activated: CPU priority optimized, background services minimized.", "Premium Tools");

    private void BtnQuickTools_Click(object sender, RoutedEventArgs e)
        => MessageBox.Show("Quick tools menu opened.", "Premium Tools");

    private void BtnSystemInfo_Click(object sender, RoutedEventArgs e)
        => MessageBox.Show("System info copied to clipboard.", "Premium Tools");

    private void BtnSecurity_Click(object sender, RoutedEventArgs e)
        => MessageBox.Show("License verified. Key: godego", "Premium Tools");

    private void BtnSettings_Click(object sender, RoutedEventArgs e)
        => MessageBox.Show("Settings panel opened.", "Premium Tools");

    private void BtnMinimize_Click(object sender, RoutedEventArgs e)
        => WindowState = WindowState.Minimized;

    private void BtnClose_Click(object sender, RoutedEventArgs e)
        => Close();

    private void BtnStartupManager_Click(object sender, RoutedEventArgs e)
        => MessageBox.Show("Startup Manager: Manage background applications.", "Premium Tools");
}