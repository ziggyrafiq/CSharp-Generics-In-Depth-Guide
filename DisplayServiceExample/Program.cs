//The File Name is Program.cs
using DisplayServiceExample;

DisplayService<Person> personService = new DisplayService<Person>();
DisplayService<Animal> animalService = new DisplayService<Animal>();

Person person = new Person("John");
Animal animal = new Animal("Lion");

personService.AddItem(person);
animalService.AddItem(animal);

Console.WriteLine("Displaying Persons:");
personService.DisplayAll();

Console.WriteLine("\nDisplaying Animals:");
animalService.DisplayAll();
