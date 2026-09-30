using System.Diagnostics;
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
            Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + "\\Microsoft\\Windows\\Temporary Internet Files"
        };

        foreach (var path in tempPaths)
        {
            if (Directory.Exists(path))
            {
                try
                {
                    foreach (var file in Directory.GetFiles(path))
                    {
                        try { File.Delete(file); }
                        catch { }
                    }

                    foreach (var dir in Directory.GetDirectories(path))
                    {
                        try { Directory.Delete(dir, true); }
                        catch { }
                    }
                }
                catch { }
            }
        }
    }

    public static void ApplyPerformancePreset()
    {
        // Lightweight simulation for gaming performance presets.
        // Actual Windows tuning can be added in later stages if needed.
    }

    public static void ApplyFiveMBoost()
    {
        // Real optimization behaviors can be implemented later for service toggling, process priorities, and registry settings.
        // This version keeps the app safe and uses a controlled UI simulation.
    }

    public static void CopySystemInfo()
    {
        var info = new StringBuilder();
        info.AppendLine("Operating System: " + Environment.OSVersion);
        info.AppendLine("Processor Count: " + Environment.ProcessorCount);
        info.AppendLine("Machine Name: " + Environment.MachineName);
        info.AppendLine("User Name: " + Environment.UserName);
        info.AppendLine("Framework: .NET 8.0");
        info.AppendLine("Gaming Profile: Premium Tools");
        info.AppendLine("Activation Key: godego");

        try
        {
            Clipboard.SetText(info.ToString());
        }
        catch
        {
            // Ignore clipboard failure in headless or restricted environments.
        }
    }
}
