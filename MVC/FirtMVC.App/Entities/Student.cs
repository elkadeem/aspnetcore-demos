using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FirtMVC.App.Entities
{
    public class Student
    {
        [Display(Name = "الأسم")]
        public string FirstName { get; set; }

        [Display(Name = "اسم الأب")]
        public string FatherName { get; set; }

        [Display(Name = "اسم الجد")]
        public string MiddleName { get; set; }

        [Display(Name = "العائلة")]
        public string FamilyName { get; set; }

        [Display(Name = "تاريخ الميلاد")]
        [DataType(DataType.Date)]
        public DateTime Birthdate { get; set; }

        [Display(Name = "المحافظة")]
        public string Gov { get; set; }

        [Display(Name = "البريد الإلكتروني")]
        public string Email { get; set; }

        [Display(Name = "النوع")]        
        public Gender Gender { get; set; }

        [Display(Name = "اللغات التي يدرسها")]
        public List<string> Languages { get; set; }

        [Display(Name = "ملاحظات")]
        [DataType(DataType.MultilineText)]
        public string Notes { get; set; }
    }

    public enum Gender
    {
        [Display(Name = "ذكر")]
        Male,
        [Display(Name = "أنثي")]
        Female
    }
}
