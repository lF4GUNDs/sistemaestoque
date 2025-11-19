using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace controleEstoque.entity
{
    public  class Fornecedor
    {
        public int id { get; set; }
        public string? nome { get; set; }
        public string? cpf_cnpj { get; set; }
        public string? endreco { get; set; }        
        public string? telefone { get; set; }    
        public string? email { get; set; }
        public string? contato { get; set; }
        public string? bairro { get; set; }
        public string? dataCadastro { get; set; }
        public string? cidade { get; set; } 
    }
}
