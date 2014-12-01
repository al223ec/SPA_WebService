using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebService.Models;
using WebService.Models.Repository;

namespace WebService.Controllers
{
    public class HomeController : Controller
    {
        private ReservationRepository repo = new ReservationRepository(); 
        public ActionResult Index()
        {
            return View(repo.GetAll());
        }
        public ActionResult Add(Reservation reservation)
        {
            if(ModelState.IsValid)
            {
                repo.Add(reservation);
                return RedirectToAction("Index"); 
            }
            return View("Index");
        }
        public ActionResult Remove(int id)
        {
            repo.Remove(id);
            return RedirectToAction("Index");
        }
        public ActionResult Update(Reservation reservation)
        {
            if(ModelState.IsValid && repo.Update(reservation))
            {
                return RedirectToAction("Index");
            }
            return View("Index");
        }
    }
}