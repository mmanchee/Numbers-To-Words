using Microsoft.VisualStudio.TestTools.UnitTesting;
using NToW.Models;

namespace NToW.Tests
{
  [TestClass]
  public class NuWordTests
  {
    [TestMethod]
    public void GetWord_GetWordFromUserNumber_Word()
    {
      Assert.AreEqual("1", Word.GetWord("one"));
    }
  }
}