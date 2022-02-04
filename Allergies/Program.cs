using System;
using System.Collections.Generic;
using Allergies.Models;

namespace Allergies.Models
{
  public class Program
  {
    public static void Main()
    {
      Allergy egg = new Allergy("egg", 1);
      Allergy peanuts = new Allergy("peanuts", 2);

      Console.WriteLine("Enter your allergy score: ");
      int score = int.Parse(Console.ReadLine());

      // GetListAllergies("egg", "peanuts");
      
    }      
  }
}  
