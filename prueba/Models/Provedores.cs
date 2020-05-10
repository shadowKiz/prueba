using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace prueba.Models
{
    public class Provedores
    {
      

        public int Id { get; set; }
     

        public string Nombre { get; set; }

        [DisplayName("Tienda Online | Fisica")]
        public string Tipotienda { get; set; }
       
        [DisplayName("Direccion de la tienda ")]
        public string URL { get; set; }
    }
}