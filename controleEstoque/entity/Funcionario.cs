using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace controleEstoque.entity
{
    public class Funcionario
    {
        public int id {  get; set; }    
        public string? nome { get; set; }
        public string? cargo { get ; set; }
        public string? contato { get; set; }
        public string? dataCadastro { get; set; }
        public string? cidade { get; set; }
         public string? cpf_cnpj { get; set; }


    }
}
