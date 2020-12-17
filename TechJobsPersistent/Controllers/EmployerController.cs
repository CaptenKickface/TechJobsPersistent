using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TechJobsPersistent.Data;
using TechJobsPersistent.Models;
using TechJobsPersistent.ViewModels;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TechJobsPersistent.Controllers
{
    public class EmployerController : Controller
    {
        private JobDbContext context;


        public EmployerController(JobDbContext dbContext)
        {
            //Is this "passing my variable into the constructor"?
            context = dbContext;         
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            //Can't access because they aren't in controllers?            
            List<Employer> employers = context.Employers.ToList();
            return View(employers);
        }

        public IActionResult Add()
        {
            AddEmployerViewModel addEmployerViewModel = new AddEmployerViewModel();

            return View(addEmployerViewModel);
        }

        public IActionResult ProcessAddEmployerForm(AddEmployerViewModel addEmployerViewModel)
        {

            //Needs to process form submissions/Make sure only valid Employer objects are being saved
            if (ModelState.IsValid)
            {
                Employer newEmployer = new Employer
                {                    
                    Name = addEmployerViewModel.Name,
                    Location = addEmployerViewModel.Location
                };
                context.Employers.Add(newEmployer);
                context.SaveChanges();

                return Redirect("/Employer");
            }

            return View("Add", addEmployerViewModel);
        }

        public IActionResult About(int id)
        {
            //Needs to pass an actual Employer object to the view
            List<Employer> employers = context.Employers
                .Where(es => es.Id == id)
                .ToList();


            return View(employers);
        }
    }
}
