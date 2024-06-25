using System;
using System.Diagnostics;

class Program
{
    static void Main()
    {
        Console.WriteLine("This program will shut down your computer.");
        Console.Write("Are you sure you want to proceed? (yes/no): ");
        string choice = Console.ReadLine();

        if (choice.ToLower() == "yes")
        {
            if (OperatingSystem.IsWindows())
            {
                // Shutdown command for Windows
                Console.WriteLine("Shutting down Windows...");
                Process.Start(new ProcessStartInfo("shutdown", "/s /t 0") { CreateNoWindow = true, UseShellExecute = false });
            }
            else if (OperatingSystem.IsLinux())
            {
                // Shutdown command for Linux
                Console.WriteLine("Shutting down Linux...");
                Process.Start("shutdown", "-h now");
            }
            else
            {
                Console.WriteLine("Unsupported operating system.");
            }
        }
        else
        {
            Console.WriteLine("Shutdown canceled.");
        }
    }
}

