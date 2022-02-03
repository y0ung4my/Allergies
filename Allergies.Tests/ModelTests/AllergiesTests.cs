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
  }
}