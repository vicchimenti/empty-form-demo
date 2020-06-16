using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.TagHelpers;

namespace empty_form_demo.Pages
{
    public class IndexModel : PageModel
    {
        public string Message { get; set; }


        public void OnGet()
        {
            Message = "Enter your message";
        }

        public void OnPost()
        {
            Message = Request.Form[nameof(Message)];
        }
    }
}