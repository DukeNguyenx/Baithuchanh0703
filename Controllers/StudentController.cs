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
      public IActionResult PTB2(string heSoA ,string heSoB, string heSoC)
      {
      
        double delta, x1, x2, a = 0, b = 0, c = 0;
        string ketqua;
  
        if(!String.IsNullOrEmpty(heSoA)) a = Convert.ToDouble(heSoA);
        if(!String.IsNullOrEmpty(heSoB)) b = Convert.ToDouble(heSoB);
        if(!String.IsNullOrEmpty(heSoC)) c = Convert.ToDouble(heSoC);
        if(a==0) ketqua = "Khong phai phuong trinh bac 2";
        else
        {
          delta = Math.Pow(b,2) - 4 * a * c;
          if(delta<0) ketqua = "Phuong trinh vo nghiem";
          else if(delta == 0)
          {
            x1 = -b/(2*a);
            ketqua = "Phuong trinh co nghiem kep = " + x1;
          }
          else
          {
            x1 = (-b + Math.Sqrt(delta))/(2*a);
            x2 = (-b - Math.Sqrt(delta))/(2*a);
            ketqua = "Phuong trinh bac 2 co 2 nghiem phan biet: x1 = " + x1 + ", x2 = " + x2;
          }
        }
        ViewBag.message = ketqua;
        return View();
      }
}  

    



