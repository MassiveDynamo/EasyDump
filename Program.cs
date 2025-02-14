using System;
using Microsoft.Extensions.Configuration;

class Program
{
    static void Main(string[] args)
    {
        // Build a configuration object from command line
        IConfiguration config = new ConfigurationBuilder()
            .AddCommandLine(args)
            .Build();

        // Read configuration values
        Console.WriteLine($"InputPath: {config["InputPath"]}");
        Console.WriteLine($"OutputPath: {config["OutputPath"]}");
    }
}