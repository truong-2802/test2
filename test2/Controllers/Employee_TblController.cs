using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using test2.Entities;
using test2.Models;
using Microsoft.AspNetCore.Mvc;

namespace test2.Controllers
{

    public class Employee_TblController : Controller
    {

        private readonly Datacontext _context;
        public Employee_TblController(Datacontext context)
        {
            _context = context;
        }
        //public IActionResult Index()
        //{
        //    return View();
        //}
        public IActionResult Index()
        {
            List<Employee_Tbl> ls = _context.Employee_Tbls.ToList();

            return View(ls);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Employee_TblModel model)
        {
            if (ModelState.IsValid)
            {
                // save to db
                _context.Employee_Tbls.Add(new Employee_Tbl { Employee_name = model.Employee_name, Employee_code = model.Employee_code, Department = model.Department, Rank = model.Rank });
                _context.SaveChanges();
                // redirect to list
                return RedirectToAction("Index");
            }
            return View(model);
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            Employee_Tbl employee_Tbl = _context.Employee_Tbls.Find(id);
            if (employee_Tbl == null)
                return NotFound();
            return View(new Employee_Tbl { Id = employee_Tbl.Id, Employee_name = employee_Tbl.Employee_name, Employee_code = employee_Tbl.Employee_code, Department = employee_Tbl.Department, Rank = employee_Tbl.Rank });


        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Employee_Tbl model)
        {
            if (ModelState.IsValid)
            {

                _context.Employee_Tbls.Update(new Employee_Tbl
                {
                    Employee_name = model.Employee_name,
                    Employee_code = model.Employee_code,
                    Department = model.Department,
                    Rank = model.Rank
                });
                _context.SaveChanges();
                return RedirectToAction("Index");


            }
            return View(model);
        }
        public IActionResult Delete(int id)
        {
            Employee_Tbl department = _context.Employee_Tbls.Find(id);
            if (department == null)
                return NotFound();
            _context.Employee_Tbls.Remove(department);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
}
