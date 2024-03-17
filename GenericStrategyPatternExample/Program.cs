//The File Name is Program.cs
// Example usage of the generic strategy pattern
using GenericStrategyPatternExample;

var contextString = new Context<string>();
var contextInt = new Context<int>();

// Set ConcreteStrategyA for contextString
var strategyA = new ConcreteStrategyA();
contextString.SetStrategy(strategyA);
contextString.ExecuteStrategy("Hello, Strategy Pattern!");

// Set ConcreteStrategyB for contextInt
var strategyB = new ConcreteStrategyB();
contextInt.SetStrategy(strategyB);
contextInt.ExecuteStrategy(42);