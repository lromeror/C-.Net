using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
//Reutilizables y un tipo de dato especifico DateOnly
//Obejtivo extender de clases y crear propios metodos
namespace Models.Extensions
{
    public static class DateTimeExtensions
    {
        public static int calcularAntiguedad(this DateOnly fecha){//this le estamos diciendo que calcular antiguead va a trabjar con tipos de datos dateOnly, extendemos de tipo de dato dateOnly
        DateOnly hoy=DateOnly.FromDateTime(DateTime.Now);
        int antiguead=hoy.Year-fecha.Year;
            return antiguead;
        }
    }
}