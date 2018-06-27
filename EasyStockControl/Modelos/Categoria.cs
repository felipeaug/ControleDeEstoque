using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class Categoria
    {
        [Key]
        public int CategoriaId { get; set; }

        [Required, StringLength(20)]
        public string DescricaoCategoria { get; set; }

        public Boolean AtivoCategoria { get; set; }

    }
}
