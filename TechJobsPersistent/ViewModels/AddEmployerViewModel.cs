﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;
using TechJobsPersistent.Models;

namespace TechJobsPersistent.ViewModels
{
    public class AddEmployerViewModel
    {
        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Location is required")]
        public string Location { get; set; }


        public AddEmployerViewModel()
        {

        }
        public AddEmployerViewModel(List<Employer> theEmployer)
        {
            foreach (var e in theEmployer)
            {
                Name = e.Name;
                Location = e.Location;
            }
        }

        //Might need something else via JobSkillView
    }
}