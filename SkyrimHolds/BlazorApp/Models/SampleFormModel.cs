using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BlazorApp.Models
{
    public class SampleFormModel
    {
        [Required]
        [StringLength(15, MinimumLength = 2, ErrorMessage = "Invalid Username Length")]
        public string UserName { get; set; }
        
        [Required]
        [StringLength(15, MinimumLength = 2, ErrorMessage = "Invalid Password Length")]
        public string SamplePassword { get; set; }
        
        [Required]
        [Range(1,100, ErrorMessage = "Must be between 1 and 100")]
        public int SampleInt { get; set; }
        
        [Required]
        [Range(1,100, ErrorMessage = "Must be between 1 and 100")]
        public double SampleDouble { get; set; }
        
        [Required]
        [Range(typeof(bool), "true", "true", ErrorMessage = "You must check box to continue")]
        public bool SampleBool { get; set; }
        public DateTime SampleDate { get; set; }
        public string DropDownValue { get; set; }
    }
}
