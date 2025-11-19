using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace controleEstoque.entity
{
    public class Estoque
    {
        public int id { get; set; }
        public double quantidade { get; set; }
        public string? dataMovimentacao { get; set; }
        public int idProduto { get; set; }

        public string? descricaoCategoria { get; set; }
        public string? descricaoProduto {get; set; }
        public string? descricaoUnidadeMedida { get; set; }
        public int idCategoria { get; set; }
        public string? codigoProduto { get; set; }
    }
}
