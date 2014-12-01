using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebService.Models
{
    public class Reservation
    {
        public int ResevationId { get; set; }
        public string ClientName { get; set; }
        public string Location { get; set; }
    }
}