using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Models.Extensions;

namespace Models
{
    public class Empleado : Persona 
    {
        public Guid numeroEmpleado {get;set;}
        public double salario {get; set;}
        public DateOnly fechaIngreso{get; set;}

        //Metodo de tipo get
        public int antiguedad{
            get{//Se puede obviar esto sino que se hace referencia como un metodo que obtiene
                return fechaIngreso.calcularAntiguedad();
            }
        }


    }
}