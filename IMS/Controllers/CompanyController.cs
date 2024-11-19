
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using IMS.Models;

namespace IMS.Controllers;

public class CompanyController : Controller
{

  public IActionResult Login(){
    return View();
  }

  public IActionResult Register(){
    return View();
  }

}

