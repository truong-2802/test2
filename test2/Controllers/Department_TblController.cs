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

    public class Department_TblController : Controller
    {

        private readonly Datacontext _context;
        public Department_TblController(Datacontext context)
        {
            _context = context;
        }
        //public IActionResult Index()
        //{
        //    return View();
        //}
        public IActionResult Index()
        {
            List<Department_Tbl> ls = _context.Department_Tbls.ToList();

            return View(ls);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Department_TblModel model)
        {
            if (ModelState.IsValid)
            {
                // save to db
                _context.Department_Tbls.Add(new Department_Tbl { Department_name = model.Department_name, Department_code = model.Department_code, Location = model.Location, Number_of = model.Number_of, Personals = model.Personals, Employee_TblId = model.Employee_TblId });
                _context.SaveChanges();
                // redirect to list
                return RedirectToAction("Index");
            }
            return View(model);
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            Department_Tbl department_Tbl = _context.Department_Tbls.Find(id);
            if (department_Tbl == null)
                return NotFound();
            return View(new Department_TblModel { Id = department_Tbl.Id, Department_name = department_Tbl.Department_name, Department_code = department_Tbl.Department_code, Location = department_Tbl.Location, Number_of = department_Tbl.Number_of, Personals = department_Tbl.Personals , Employee_TblId = department_Tbl.Employee_TblId });


        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Department_TblModel model)
        {
            if (ModelState.IsValid)
            {

                _context.Department_Tbls.Update(new Department_Tbl
                {
                    Department_name = model.Department_name,
                    Department_code = model.Department_code,
                    Location = model.Location,
                    Number_of = model.Number_of,
                    Personals = model.Personals,
                    Employee_TblId = model.Employee_TblId
                });
                _context.SaveChanges();
                return RedirectToAction("Index");


            }
            return View(model);
        }
        public IActionResult Delete(int id)
        {
            Department_Tbl department = _context.Department_Tbls.Find(id);
            if (department == null)
                return NotFound();
            _context.Department_Tbls.Remove(department);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}

