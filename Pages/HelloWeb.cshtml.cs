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
        public Student[] studentArray = new Student[3];

        public void OnGet()
        {
            studentArray[0] = new Student(1, "Peter D'hondt", 4);
            studentArray[1] = new Student(2, "Thomas Pieters", 4);
            studentArray[2] = new Student(3, "Micha Harin", 4);
        }
    }
}
