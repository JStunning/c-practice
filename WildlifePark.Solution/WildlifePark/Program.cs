using System;
using WildlifePark.Models;
using System.Text.RegularExpressions;
using System.Collections.Generic;
  public class Program {
  public static Tracker tracker = new Tracker();
    public static void Continue(Tracker tracker) {
      Console.WriteLine("What would you like to do? ['list' to see all animals, 'add' to add an animal to the list, or 'exit' to exit.");
      string answer = Console.ReadLine();
      if(answer == "add") {
        Console.WriteLine("Enter the name, type, and age of the animal separated by a comma.");
        string animalProperties = Console.ReadLine();
        Regex.Replace(animalProperties, @"\s+", "");
        string[] props = animalProperties.Split(",");
        Animal a = new Animal(props[0], props[1], int.Parse(props[2]));
        tracker.AddAnimal(a);
        Continue(tracker);
      } else if (answer == "list") {
          List<Animal> animals = tracker.GetAnimals();
        if(animals.Count == 0) {
          Console.WriteLine("There are no animals in the list.");
        } else {
          foreach (Animal a in animals)
          {
            Console.WriteLine("Name: " + a.getName() + " \tType: " + a.getType() + " \tAge: " + a.getAge());
          }
          Console.ReadLine();
          Continue(tracker);
        }
      } else if(answer == "exit") {
        Console.WriteLine("Goodbye.");
      } else {
        Console.WriteLine("Not a valid option. Please check your input.");
        Continue(tracker);
      }
      
    }
    static void Main()
    {
      
      Console.WriteLine("Welcome to Animal TrackeR");
      Continue(tracker);
    }
  }
