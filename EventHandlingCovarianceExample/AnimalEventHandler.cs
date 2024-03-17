//The File Name is AnimalEventHandler.cs
namespace EventHandlingCovarianceExample;

public delegate void AnimalEventHandler<in T>(object sender, T e) where T : AnimalEventArgs;
