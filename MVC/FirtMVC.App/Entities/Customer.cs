using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace FirtMVC.App.Entities
{
    public class Customer
    {
        public Guid Id { get; set; }

        [Display(Name = "Customer Name")]
        [MaxLength(100)]
        [Required(ErrorMessage = "حقل الإسم مطلوب")]
        public string Name { get; set; }

        public string Phone { get; set; }

        [EmailAddress(ErrorMessage = "الإيميل غير صحيح")]
        [MaxLength(100)]
        [Required(ErrorMessage = "البريد الإلكتروني مطلوب")]
        public string Email { get; set; }

        [DataType(DataType.Date)]
        public DateTime Birthdate { get; set; }

        [Display(Name = "Active")]
        public bool IsActive { get; set; }

        public string Country { get; set; }

        public string City { get; set; }

        [Display(Name = "Activities")]
        public List<string> Tags { get; set; }

        public IEnumerable<SelectListItem> Countries { get; set; }
    }
}
