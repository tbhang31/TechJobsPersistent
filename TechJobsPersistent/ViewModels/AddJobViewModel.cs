using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;
using TechJobsPersistent.Models;

namespace TechJobsPersistent.ViewModels
{
    public class AddJobViewModel
    {
        [Required(ErrorMessage = "Job name required")]
        [StringLength(100, ErrorMessage = "This job's name isn't the right amount of characters")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Employer's ID required")]
        public int EmployerId { get; set; }

        public List<SelectListItem> Employers { get; set; }

        public AddJobViewModel(List<Employer> employers)
        {
            Employers = new List<SelectListItem>();

            foreach (var employer in employers)
            {
                Employers.Add(
                    new SelectListItem
                    {
                        Value = employer.Id.ToString(),
                        Text = employer.Name,
                    }
                    );
            }
        }

        public AddJobViewModel()
        {
        }
    }
}

