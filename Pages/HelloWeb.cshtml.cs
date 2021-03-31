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
        public Student Thomas = new Student();
        public Student Micha = new Student();

        public void OnGet()
        {
            Peter.Id = 1;
            Peter.Name = "Peter D'hondt";
            Peter.ClassId = 4;

            Thomas.Id = 2;
            Thomas.Name = "Thomas Pieters";
            Thomas.ClassId = 4;

            Micha.Id = 3;
            Micha.Name = "Micha Harin";
            Micha.ClassId = 4;
        }
    }
}
