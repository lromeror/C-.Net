using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Models
{
    public class Persona
    {
        public int Id {get;set;}
        public string Nombres {get;set;}
        public string Apellidos {get;set;}

        public Genero genero {get;set;}
         public Direccion direccion{get; set;}

        public string nombreComleto{
            get{
                return $"{Nombres} {Apellidos}";
            }
        }
        public string telefono{get; set;}
    }

    public enum Genero{
        Masculino,Femenino
    }
}