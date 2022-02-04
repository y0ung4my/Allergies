using Microsoft.VisualStudio.TestTools.UnitTesting;
using Allergies.Models;

namespace Allergies.Tests
{
  [TestClass]
  public class AllergiesTests
  {
    // Test methods go here
    [TestMethod]
    public void AllergyChecker_ReturnAllergen_Egg()
    {
      Allergy egg = new Allergy("egg", 1); 
      Assert.AreEqual("egg", egg.AllergyChecker(1));
    }
    [TestMethod]
    public void GetListAllergies_GettingListOfAllergies_Elements()
    {
      Allergy egg = new Allergy("egg", 1); 
      Allergy peanuts = new Allergy("peanuts", 2);
      Assert.AreEqual({{"egg", 1}, {"peanuts", 2}}, GetListAllergies(3));
  }
}