using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class Estoque
    {
        [Key]
        public int EstoqueID { get; set; }

        [Required, StringLength(10)]
        public string Referencia { get; set; }

        [Required, StringLength(30)]
        public string Descricao { get; set; }

        public string Preco { get; set; }

        public string Quantidade { get; set; }

        public int CategoriaID { get; set; }
    }
}
