using System.IO;
using System.Text;

namespace PremiumTools;

public static class SystemOptimizer
{
    public static void CleanTemp()
    {
        var tempPaths = new[]
        {
            Path.GetTempPath(),
            Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\Temp",
            Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\Microsoft\\Windows\\INetCache"
        };

        int filesDeleted = 0;

        foreach (var path in tempPaths)
        {
            if (!Directory.Exists(path)) continue;

            try
            {
                foreach (var file in Directory.GetFiles(path))
                {
                    try
                    {
                        File.Delete(file);
                        filesDeleted++;
                    }
                    catch { }
                }

                foreach (var dir in Directory.GetDirectories(path))
                {
                    try
                    {
                        Directory.Delete(dir, true);
                    }
                    catch { }
                }
            }
            catch { }
        }
    }

    public static void ApplyPerformancePreset()
    {
        // System performance tuning simulation
        // Real Windows Registry modifications can be added for:
        // - Disable Visual Effects
        // - Adjust power settings for high performance
        // - Reduce animation delays
        // - Disable Windows Update background
    }

    public static void ApplyFiveMBoost()
    {
        // FiveM-specific optimization simulation
        // Can include:
        // - Set process priority to High
        // - Minimize background services
        // - Adjust network buffer sizes
        // - Enable CPU cache optimizations
    }

    public static void CopySystemInfo()
    {
        try
        {
            var info = new StringBuilder();
            info.AppendLine("=== SYSTEM INFORMATION ===");
            info.AppendLine($"OS: {Environment.OSVersion}");
            info.AppendLine($"Processor Count: {Environment.ProcessorCount}");
            info.AppendLine($"Machine: {Environment.MachineName}");
            info.AppendLine($"User: {Environment.UserName}");
            info.AppendLine($"Framework: .NET 8.0-Windows");
            info.AppendLine($"Application: Premium Tools v1.0");
            info.AppendLine($"License Status: ACTIVE");
            info.AppendLine($"Activation Key: godego");

            System.Windows.Forms.Clipboard.SetText(info.ToString());
        }
        catch { }
    }
}