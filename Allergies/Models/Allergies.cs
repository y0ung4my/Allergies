using System;

namespace Allergies.Models {

  public class Allergy
  {
    public string Allergen;
    public int Score;

    public Allergy(string allergen, int score)
    {
      Allergen = allergen;
      Score = score;
    }
    // List<Car> Cars = new List<Car>() {egg, peanuts};
    // public int AddTwoAllergens (int score)
    // {
          
    // }
    
    public string AllergyChecker(int score)
    {
      if (score == this.Score)
      {
        return this.Allergen;
      }
      else
      {
        return "bupkis";
      } 
    }
  }
}

// checkAllergen(3); 
// output : eggs and peanuts
// allergies = char array[];
//  if (output < allergen.score) {
//    output - allergen.score
//    allergies.push(allergen)
//  }
// userinput = 3
// loop( that has an array )
// array {contains intialized allergens ex. ([eggs, 1] [peanutes, 2])}
// starts with peantus -2, leave the userinput at 1, so it continues the loop to next allergen
// until it hits 0
// returning allergen.name (eggs, peanutes)

// 1. intialize all allegen objects
// 2. put them in a list
// 3. make a loop that has a conditional that ends when output == 0 
// 4. how to target allergen.name and push to another list for result

