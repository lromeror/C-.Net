using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Data.Interfaces
{
    public interface IGenerico<T>where T:class//Tipo de dato Parametrizado
    {
        T Obtener(int index);
        void Agregar(T modelo);
        int Total();
        IEnumerable<T> obtenerTodos(); //Retorna una lista de tipo T
    }
}