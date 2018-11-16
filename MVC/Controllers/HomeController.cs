using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVC.Models;

using PRPCRepositoryLib;
using PRPCRepositoryLib.Models;


namespace MVC.Controllers
{
    public class HomeController : Controller
    {

        //private PRPCRepository repo;

        public HomeController()
        {
            //repo = new PRPCRepository();
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult ProveIt()
        {

            UserListViewModel vm = new UserListViewModel();
            PRPCRepository repo = new PRPCRepository();

            using(repo.Context = new PRPCRepositoryDbContext())
            {

                vm.Users = repo.Context.Users.ToList();
            }

            return View(vm);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
