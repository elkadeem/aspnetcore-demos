using FirtMVC.App.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;

namespace FirtMVC.App.Components
{    
    [ViewComponent(Name = "CustomerDetails")]
    public class CustomerDetailsViewComponent : ViewComponent
    {
        private readonly DemoDbContext demoDebContext;

        public CustomerDetailsViewComponent(DemoDbContext demoDebContext)
        {
            this.demoDebContext = demoDebContext;
        }
        public async Task<IViewComponentResult> InvokeAsync(Guid id)
        {
            var customer = await demoDebContext.Customers.FirstOrDefaultAsync(c => c.Id == id);
            return View("CustomerDetails", customer);
        }
    }
}
