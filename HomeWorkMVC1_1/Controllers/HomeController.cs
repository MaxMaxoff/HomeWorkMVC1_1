﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HomeWorkMVC1_1.Models;

namespace HomeWorkMVC1_1.Controllers
{
    public class HomeController : Controller
    {
        private readonly List<EmployeeView> _employees = new List<EmployeeView>
        {
            new EmployeeView
            {
                Id = 1,
                FirstName = "Иван",
                SurName = "Иванов",
                Patronymic = "Иванович",
                Age = 22
            },
            new EmployeeView
            {
                Id = 2,
                FirstName = "Владислав",
                SurName = "Петров",
                Patronymic = "Иванович",
                Age = 35
            }
        };

        public IActionResult Details(int id)
        {
            return View(_employees.Find(item => item.Id == id));
        }

        public IActionResult Index()
        {
            return View(_employees);
        }
    }
}