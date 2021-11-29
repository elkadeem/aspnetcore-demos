using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FirtMVC.App.Pages
{
    public class IndexModel : PageModel
    {
        public string Title { get; set; }

        [BindProperty]
        public string Name { get; set; }

        public IndexModel()
        {
            Name = "Wael";
        }

        public void OnGet()
        {
        }
    }
}
