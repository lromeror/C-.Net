using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Entidades
{
    [Table("libro")]
    public class Libro
    {
        [Key]
        [Column("libroId")]
        public int Id { get; set; }
        public string titulo { get; set; }
        public string descripcion { get; set; }
        [Column("publicado")]
        public DateTime fech_publicado { get; set; }
        public decimal precio { get; set; }
        public int categoriaId { get; set; }
        [ForeignKey("categoriaId")]
        public Categoria categoria { get; set; }//Hacer la navegacion
    }
}
