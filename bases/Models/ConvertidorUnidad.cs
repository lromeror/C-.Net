using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

//Clase Models
namespace Models{
    public class ConvertidorUnidad{

        int radio;

        public ConvertidorUnidad(int radio){
            this.radio=radio;
        }

        public int convertir(int unidad){
            return unidad*radio ;
        }

    }
}