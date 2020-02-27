using System;
using Dealership.Models;
using System.Collections.Generic;
  public class Program {
    static void Main()
    {
      Car volkswagen = new Car("Wow! This car has only had 1 owner! Want the neighborhood to know you're coming? This is the car for you! Ride in style with the humming of a chainsaw.", "1974 Volkswagen Thing", 1100, 368792);
      Car yugo = new Car("Boring, don't buy.","1980 Yugo Koral", 700,  90000);
      Car ford = new Car("My car. Please buy it.","1988 Ford Country Squire", 1400, 239001);
      Car amc = new Car("Vroom vroom","1976 AMC Pacer", 400, 198000);

      List<Car> Cars = new List<Car>() { volkswagen, yugo, ford, amc };

      Console.WriteLine("Enter maximum price: ");
      string stringMaxPrice = Console.ReadLine();
      Console.WriteLine("Enter a maximum number of miles: ");
      string stringMaxMiles = Console.ReadLine();
      int maxPrice = int.Parse(stringMaxPrice);
      int maxMiles = int.Parse(stringMaxMiles);

      List<Car> CarsMatchingSearch = new List<Car>(0);

      bool noneFound = true;
      foreach (Car automobile in Cars)
      {
        if (automobile.WorthBuying(maxPrice, maxMiles))
        {
          CarsMatchingSearch.Add(automobile);
          noneFound = false;
        }
      }
      if(noneFound == true) {
        Console.WriteLine("There are no cars less than the max price entered.");
      } else {
        foreach(Car automobile in CarsMatchingSearch)
        {
          Console.WriteLine("----------------------");
          Console.WriteLine("Make: " + automobile.MakeModel + " Miles: " + automobile.Miles + " Price: $" + automobile.Price);
          Console.WriteLine("Description: " + automobile.Description);
        }
      }
    }
  }

  //  MakeModel = makeModel;
  //     Price = price;
  //     Miles = miles;