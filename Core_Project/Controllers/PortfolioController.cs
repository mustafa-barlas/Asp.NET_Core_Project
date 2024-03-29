﻿using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace Core_Project.Controllers
{
    [Authorize(Roles = "Admin")]
    public class PortfolioController : Controller
    {
        PortfolioManager portfolioManager = new PortfolioManager(new EfPortfolioDal());

        public IActionResult Index(Portfolio portfolio)
        {

            var values = portfolioManager.TGetList();
            return View(values);
        }


        [HttpGet]
        public IActionResult AddPortfolio()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddPortfolio(Portfolio portfolio)
        {
            
            PortfolioValidator validations = new PortfolioValidator();
            ValidationResult results = validations.Validate(portfolio);
            if (results.IsValid)
            {
                portfolioManager.Tadd(portfolio);
                return RedirectToAction("Index");

            }
            else
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
        }

        public IActionResult DeletePortfolio(int id)
        {
            var values = portfolioManager.TGetByID(id);
            portfolioManager.Tdelete(values);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult EditPortfolio(int id)
        {
            var values = portfolioManager.TGetByID(id);
            return View(values);
        }

        [HttpPost]
        public IActionResult EditPortfolio(Portfolio portfolio)
        {
            PortfolioValidator validations = new PortfolioValidator();    
            ValidationResult results = validations.Validate(portfolio);
            if (results.IsValid)
            {
                portfolioManager.Tupdate(portfolio);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
           
        }

    }
}
