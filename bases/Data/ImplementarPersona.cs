using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Data.Interfaces;
using Models;

namespace Data
{
    public class ImplementarPersona : IGenerico<Persona>
    {
        public List<Persona> personas = new List<Persona>();
        public void Agregar(Persona modelo)
        {
            personas.Add(modelo);
        }

        public Persona Obtener(int index)
        {
            return personas.Find(x => x.Id == index);
        }

        public IEnumerable<Persona> obtenerTodos()
        {
            return personas.ToList();
        }

        public int Total()
        {
            return personas.Count;
        }
        
    }
}