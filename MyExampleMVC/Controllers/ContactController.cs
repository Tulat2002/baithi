using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyExampleMVC.Data;
using MyExampleMVC.Entities;
using MyExampleMVC.Models;
using MyExampleMVC.Models.Domain;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MyExampleMVC.Controllers
{
    
    public class ContactController : Controller
    {
        private readonly DataContext _context;
        public ContactController(DataContext dataContext)
        {
            _context = dataContext;
        }
        public IActionResult Index()
        {
            List<Contact> contacts = _context.Contacts.ToList<Contact>();
            
            return View(contacts);
        }

        public IActionResult Create()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Create(ContaxtViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                _context.Contacts.Add(new Contact
                {
                    ContactName = viewModel.ContactName,
                    ContactNumber = viewModel.ContactNumber,
                    GroupName = viewModel.GroupName,
                    HireDate = viewModel.HireDate,
                    Birthday = viewModel.Birthday
                });
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(viewModel);
        }
    }
    
}

