using System;
using System.Collections.Generic;

namespace WildlifePark.Models {
    public class Tracker {

      private List<Animal> animals = new List<Animal>();
      public Tracker() {

      }
      
      public void AddAnimal(Animal animal) {
        animals.Add(animal);
      }

      public List<Animal> GetAnimals() {
        return animals;
      }

    }
}