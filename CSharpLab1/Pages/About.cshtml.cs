﻿using Microsoft.AspNetCore.Mvc.RazorPages;
using System;

namespace CSharpLab1.Pages
{
    public class AboutModel : PageModel
    {
        public string Message { get; set; }

        public void OnGet()
        {
            string directory = Environment.CurrentDirectory;
            Message = String.Format("Your directory is {0}.", directory);
        }
    }
}
