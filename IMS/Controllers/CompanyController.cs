
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using IMS.Models.Entities;
using IMS.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Data.Sqlite;

namespace IMS.Controllers;

public class CompanyController : Controller
{

    private readonly ApplicationDbContext _context;

    public CompanyController(ApplicationDbContext context)
    {
        _context = context;
    }

    public IActionResult Login()
    {
        return View();
    }

    public IActionResult Register()
    {
        return View();
    }

    public IActionResult Dashboard()
    {
        return View();
    }


    [HttpPost]
    public IActionResult Login(Login Model)
    {
        if (ModelState.IsValid)
        {
            var sql = "SELECT * from Companies WHERE Email = @Email AND Password = @Password";
            var emailParam = new SqliteParameter("@Email", Model.Email);
            var passwordParam = new SqliteParameter("@Password", Model.Password);

            // Execute the raw SQL query and get the result
            var company = _context.Companies
                .FromSqlRaw(sql, emailParam, passwordParam)  // Pass parameters to the query
                .FirstOrDefault();  // Retrieve the first result or null if no match is found

            if (company != null)
            {
                return RedirectToAction("Dashboard");
            }
            else
            {
                ModelState.AddModelError("Email", "Invalid email or password.");
            }
        }




        return View(Model);
    }

    [HttpPost]
    public IActionResult Register(Company Model)
    {
        if (ModelState.IsValid)
        {

            var sql = "INSERT INTO Companies  (Name,Address,Email,Fax,Phone,Password,Website) VALUES ({0},{1},{2},{3},{4},{5},{6})";

            _context.Database.ExecuteSqlRaw(sql, Model.Name, Model.Address, Model.Email, Model.Fax, Model.Phone, Model.Password, Model.Website);


            return RedirectToAction("Login");
        }


        return View(Model);
    }

}

