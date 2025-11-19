using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace controleEstoque.entity
{
    public  class Produto
    {
        public int id { get; set; }
        public string descricao { get; set; }
        public double estoqueMinimo { get; set; }
        public string observacao { get; set; }
        public  int codigoProduto { get; set; }

        public String dataCadasto { get; set; }

       public String  categoriaDescricao {get; set; }

       public String unidadeMedidaDescricao { get; set; }
       public string quantidade { get; set; }  

        public string nome { get; set; }

      public  int idFuncionario { get; set; }
      public int idCategoria { get; set; }
      public int idUnidadeMedida { get; set; }

    }
}
