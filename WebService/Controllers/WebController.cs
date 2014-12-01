using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebService.Models;
using WebService.Models.Repository;

namespace WebService.Controllers
{
    public class WebController : ApiController
    {
        private ReservationRepository repo = new ReservationRepository(); 
        public IEnumerable<Reservation> GetAllReservations()
        {
            return repo.GetAll(); 
        }
        public Reservation GetReservation(int id)
        {
            return repo.Get(id);
        }
        public Reservation PostReservation(Reservation reservation)
        {
            return repo.Add(reservation);
        }
        public bool PutReservation(Reservation reservation)
        {
            return repo.Update(reservation); 
        }
        public void DeleteReservation(int id)
        {
            repo.Remove(id);
        }
    }
}