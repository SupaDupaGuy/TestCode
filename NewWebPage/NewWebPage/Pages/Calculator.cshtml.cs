using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace NewWebPage.Pages
{
    public class CalculatorModel : PageModel
    {
        int numQueries = 0;
        public void OnPost()
        {
            string aname = "I worked!";
            ViewData["name"] = aname;

            string Test = "Test";
            ViewData["mytest"] = Test;
        }

        public void OnGet()
        {
            numQueries++;
            var num1 = Request.Query["num1"];
            if (String.IsNullOrEmpty(num1) && numQueries > 1)
            {
                string aname = "You must enter in 2 numbers!";
                ViewData["view1"] = aname;
                numQueries = 5;
            }
            

            numQueries++;
            ViewData["numQ"] = numQueries;
            
        }
    }
}