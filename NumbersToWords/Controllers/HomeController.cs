using Microsoft.AspNetCore.Mvc;
using NToW.Models;

namespace NToW.Controllers
{
  public class HomeController : Controller
  {
    [Route("/")]
    public ActionResult Form() { return View(); }
    
    [Route("/words")]
    public ActionResult Words(string stringNum)
    {
      Numbers myNumber = new Numbers();
      myNumber.NtWs = stringNum;
      return View(myNumber);
    }
  }  
}