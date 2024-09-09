using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Entidades
{
    [Table("categoria")]//nombre de la tabla en mi base de dato
    public class Categoria
    {
        //Las columnas pasan a ser los atributos de mi clase
        [Key]//nos ayudara a mapear el key de nuestra columna, NO ES NECESARIO MAPEAR SI se llaman iguales tanto en la base como en la clase
        [Column("categoriaId")]
        public int Id { get; set; }
        public string nombre { get; set; }
    }
}
