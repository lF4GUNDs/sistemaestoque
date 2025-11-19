using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace controleEstoque.entity
{
    public class MovimentaEstoque
    {
        public int id { get; set; }
        public string? quantidade { get; set; }
        public int idFuncionario { get; set; }
        public string? descricaoCategoria { get; set; }
        public string? descricaoUnidadeMedida { get; set; }
        public string? nomeFuncionario { get; set; }
        public int idProduto { get; set; }
        public string? codigoProduto {get; set; }
        public string? descricaoProduto { get; set; }
        public string? dataMovimentacao { get; set; }
        public string?   observacao { get; set; }
        public int idFornecedor { get; set; }
        public string? nomeFornecedor { get; set; }
     
    }
}
