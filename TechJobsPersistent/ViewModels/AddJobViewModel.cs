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
        [StringLength(100, ErrorMessage = "Please enter a valid job")]
        public string Name { get; set; }

        public int EmployerId { get; set; }

        [Required(ErrorMessage = "Please select an employer")]
        public List<SelectListItem> Employers { get; set; }

        [Required(ErrorMessage = "Please select the required job skills")]
        public List<Skill> Skills { get; set; }

        public List<int> SkillId { get; set; }

        public AddJobViewModel(List<Employer> employers, List<Skill> skills)
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

            Skills = skills;
        }

        public AddJobViewModel()
        {
        }
    }
}

