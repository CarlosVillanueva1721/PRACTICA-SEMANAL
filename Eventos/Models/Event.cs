using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;

namespace Eventos.Models
{
    public class Event
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Description { get; set; }
        public DateTime Fecha { get; set; }
        public string Organisador { get; set; }
        public int CityId { get; set; }
        [ForeignKey("CityId")]
        public City City { get; set; }

    }
}