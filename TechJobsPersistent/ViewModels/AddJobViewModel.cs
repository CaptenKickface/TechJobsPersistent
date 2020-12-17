using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using TechJobsPersistent.Data;
using TechJobsPersistent.Models;

namespace TechJobsPersistent.ViewModels
{
    public class AddJobViewModel
    {
        private JobDbContext context;

        [Required(ErrorMessage = "Employer is required")]
        public int EmployerId { get; set; }

        [Required(ErrorMessage = "Job is required")]
        public int JobId { get; set; }
        public List<SelectListItem> employerList { get; set; }

        public List<Skill> skillsList { get; set; }

        public string Name { get; set; }

       

       

        

        public AddJobViewModel()
        {
        }

        public AddJobViewModel(JobDbContext dbContext)
        {
            //Is this "passing my variable into the constructor"?
            context = dbContext;
        }

        public AddJobViewModel(List<Employer> employers, List<Skill> skills)
        {
            employerList = new List<SelectListItem>();
            skillsList = skills;

            foreach (var emp in employers)
            {
                employerList.Add(new SelectListItem
                {
                    Value = emp.Id.ToString(),
                    Text = emp.Name
                });
            }
           
        }



    }
}
