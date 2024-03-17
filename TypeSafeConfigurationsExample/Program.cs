//The File Name is Program.cs
// Example usage of type-safe configuration manager with generics
using TypeSafeConfigurationsExample;

var appConfig = new AppConfiguration
{
    AppName = "Code Example by Ziggy Rafiq App",
    MaxConnections = 100
};

var configManager = new ConfigurationManager<AppConfiguration>(appConfig);

// Retrieve and display the configuration
var retrievedConfig = configManager.GetConfiguration();
Helper.DisplayConfiguration(retrievedConfig);

// Modify the configuration (for demonstration purposes)
appConfig.MaxConnections = 200;

// Retrieve and display the updated configuration
var updatedConfig = configManager.GetConfiguration();
Helper.DisplayConfiguration(updatedConfig);