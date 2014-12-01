using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebService.Models.Repository
{
    public class ReservationRepository
    {
        private static ReservationRepository repo = new ReservationRepository();
        public static ReservationRepository Current
        {
            get
            {
                return repo; 
            }
        }

        private List<Reservation> data = new List<Reservation>
        {
            new Reservation{
                ResevationId = 1, ClientName = "Adam", Location = "Room"
            },
            new Reservation{
                ResevationId = 2, ClientName = "Anton", Location = "Room"
            },
        };
        public IEnumerable<Reservation> GetAll()
        {
            return data.AsEnumerable();
        }
        public Reservation Get(int id)
        {
            return data.Where(r => r.ResevationId == id).FirstOrDefault(); 
        }
        public Reservation Add(Reservation reservation)
        {
            reservation.ResevationId = data.Count + 1;
            data.Add(reservation);
            return reservation;
        }
        public void Remove(int id)
        {
            Reservation reservation = Get(id);
            if(reservation != null)
            {
                data.Remove(reservation); 
            }
        }
        public bool Update(Reservation reservation)
        {
            Reservation storedReservation = Get(reservation.ResevationId);
            if(storedReservation != null)
            {
                storedReservation.ClientName = reservation.ClientName;
                storedReservation.Location = reservation.Location;
                return true;
            }
            return false;
        }
        }
}