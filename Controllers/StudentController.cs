using Microsoft.AspNetCore.Mvc;
namespace BTH2002.Controllers;

  public class StudentController : Controller
    {
      public IActionResult Index()
      {
        return View();
      }
      [HttpPost]
       public IActionResult Index( string name)
    {
      string strReturn = " Hello, " + name;
      // gui du lieu ve view
      ViewBag.abc = strReturn;
        return View();
    }

     public IActionResult Tong() 
      {
        return View();
      }
    [HttpPost]
      public IActionResult Tong(string Number)
      {
        int so = Convert.ToInt32(Number);
        int tong = 0;
        while (so > 0)
        {
          tong = tong + so%10;
          so = so/10;
        }
        ViewBag.Sum = "Tong cac chu so cua so" + Number + " = " + tong;  
        return View();
      }

      public IActionResult PTB2()
      {
        return View();
      }
    [HttpPost]
      public IActionResult PTB2(string hesoA ,string hesoB, string hesoC)
      {
        double delta;
        
        return View();
      }
}  

    



