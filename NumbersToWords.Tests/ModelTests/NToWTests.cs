using Microsoft.VisualStudio.TestTools.UnitTesting;
using NToW.Models;

namespace NToW.Tests
{
  [TestClass]
  public class NuWordTests
  {
    [TestMethod]
    public void GetWord_GetOneNumberFromUser_Word()
    {
      Assert.AreEqual("One", Numbers.GetWord("1"));
    }

    [TestMethod]
    public void GetWord_GetTwoNumbersFromUser_Word()
    {
      Assert.AreEqual("Nineteen", Numbers.GetWord("19"));
    }
  }
}