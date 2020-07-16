using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LeaveManagement.Models
{
    public class LeaveTypeVM
    {
        
        public int Id { get; set; }
        [Required]
        [Display(Name = "Leave Type")]
        public string Name { get; set; }
        [Required]
        [Range(1,25,ErrorMessage ="Please enter valid number")]
        [Display(Name ="Default Number of Days")]
        public int DefaultDays { get; set; }
        [Display(Name="Date Created")]
        public DateTime DateCreated { get; set; }
    }
}
