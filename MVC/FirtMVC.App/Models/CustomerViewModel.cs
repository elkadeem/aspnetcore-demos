using FirtMVC.App.Entities;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FirtMVC.App.Models
{
    public class CustomerViewModel
    {
        public Customer Customer { get; set; }

        [Display(Name = "Activities")]        
        public List<string> Tags { get; set; } 
        
        public IEnumerable<SelectListItem> Countries { get; set; }
    }
}
