using System;
using System.IO;
using System.Diagnostics;

class Example
{
    public static void Main()
    {
        using (Process process = new Process())
        {
            process.StartInfo.FileName = "emotion.py";
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardOutput = true;
            process.Start();

            // Synchronously read the standard output of the spawned process.
            StreamReader reader = process.StandardOutput;
            string output = reader.ReadToEnd();

            // Write the redirected output to this application's window.
            Console.WriteLine(output);

            process.WaitForExit();
        }

        Console.WriteLine("\n\nPress any key to exit.");
        Console.ReadLine();
    }
}