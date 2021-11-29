using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using FirtMVC.App.Entities;

namespace FirtMVC.App.Pages.CustomersP
{
    public class IndexModel : PageModel
    {
        private readonly FirtMVC.App.Entities.DemoDbContext _context;

        public IndexModel(FirtMVC.App.Entities.DemoDbContext context)
        {
            _context = context;
        }

        public IList<Customer> Customer { get;set; }

        public async Task OnGetAsync()
        {
            Customer = await _context.Customers.ToListAsync();
        }
    }
}
