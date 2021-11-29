using FirtMVC.App.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace FirtMVC.App.Components
{    
    public class CustomerDataViewComponent : ViewComponent
    {
        private readonly DemoDbContext demoDebContext;

        public CustomerDataViewComponent(DemoDbContext demoDebContext)
        {
            this.demoDebContext = demoDebContext;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            int count = await demoDebContext.Customers.CountAsync();
            return View(count);
        }
    }
}
