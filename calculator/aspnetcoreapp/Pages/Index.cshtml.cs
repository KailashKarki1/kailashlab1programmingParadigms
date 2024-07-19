using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace aspnetcoreapp.Pages;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;

    public IndexModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {

    }
    public void OnPost()
    {
 
        if (Request.Method.Equals("POST", System.StringComparison.OrdinalIgnoreCase)){
 
            if(Request.Form["ADD"]=="+"){
 
                ViewData["summation"]=double.Parse(Request.Form["num1"])+double.Parse(Request.Form["num2"]);
 
            }
            if(Request.Form["SUB"]=="-"){
 
                ViewData["SUBTRACTION"]=double.Parse(Request.Form["num1"])-double.Parse(Request.Form["num2"]);
 
            }
            if(Request.Form["DIV"]=="/"){
 
                ViewData["DIVISION"]=double.Parse(Request.Form["num1"])/double.Parse(Request.Form["num2"]);
 
            }
            if(Request.Form["MUL"]=="*"){
 
                ViewData["MULTIPLY"]=double.Parse(Request.Form["num1"])*double.Parse(Request.Form["num2"]);
 
            }
            if(Request.Form["SQR"]=="SQR"){
                ViewData["Square"]=double.Parse(Request.Form["num1"])*double.Parse(Request.Form["num1"]);
            }

            if(Request.Form["POW"]=="POW"){          
                      ViewData["power"]= Math.Pow(double.Parse(Request.Form["num1"]),double.Parse(Request.Form["num2"]));

            }
            if(Request.Form["CUBE"]=="CUBE"){          
                      ViewData["CUB"]= double.Parse(Request.Form["num1"])*double.Parse(Request.Form["num1"])*double.Parse(Request.Form["num1"]);

            }
 
        }
    }
 
}