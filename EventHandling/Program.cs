//The File Name is Program.cs
using EventHandling;

Zoo myZoo = new Zoo();
myZoo.AnimalAdded +=myZoo.HandleAnimalAdded;

Animal lion = new Animal { Name = "Lion" };
myZoo.AddAnimal(lion);