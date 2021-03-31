using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using net_on_the_web.Models;

namespace net_on_the_web.Pages
{
    public class HelloWebModel : PageModel
    {

        public Student Peter = new Student();
        
        public void OnGet()
        {
            Peter.Id = 1;
            Peter.Name = "D'hondt";
            Peter.ClassId = 4;
        }
    }
}
