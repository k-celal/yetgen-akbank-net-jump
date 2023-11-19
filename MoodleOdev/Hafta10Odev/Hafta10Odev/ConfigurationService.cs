// See https://aka.ms/new-console-template for more information
using Microsoft.Extensions.Configuration;

public class ConfigurationService
{
    private static ConfigurationService instance;
    public static ConfigurationService GetInstance()
    {
        if (instance is null)
            instance= new ConfigurationService();
        return instance;
    }
    public string GetValue(string key)
    {
        ConfigurationManager configurationManager = new();
        string path = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;
        configurationManager.SetBasePath(path);
        configurationManager.AddJsonFile("Configuration.json");
        return configurationManager.GetSection(key).Value;

    }
    private ConfigurationService()
    {
        Console.WriteLine("Instance Created");
    }
}