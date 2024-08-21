using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace Models
{
    public class Direccion
    {
        public string numero {get; set;}
        public string nombreCalle {get; set;}
        public string ciudad {get;set;}
        public string provincia {get; set;}
        public string pais {get; set;}

        public string DireccionCompleta{
            get{
                return $"{numero} {nombreCalle},{ciudad}";
            }
        }

    }
}