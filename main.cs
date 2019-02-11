using System;
using System.Collections.Generic;
using System.Linq;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine($"Mutant Power: {CharacterGenerator.RandomMutation()}");

    Console.WriteLine($"Secret Society: {CharacterGenerator.RandomSociety()}");

    Console.WriteLine("Inventory:");

    var awesomeList = new List<Item>();

    var itemCount = 6;

    for (int i = 0; i < itemCount; i++)
    {
        awesomeList.Add(InventoryGenerator.RandomItem());
    }

    var sortedList = awesomeList.OrderBy(x => (int) (x.Clearance) ).ToList();

    foreach (var element in sortedList)
    {
      Console.WriteLine($"{element.Name} - Clearance: {element.Clearance}");
    }
  }
}