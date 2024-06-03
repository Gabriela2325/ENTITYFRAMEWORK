using System.ComponentModel.DataAnnotations;

namespace loja.models
{
    public class Produto{
        [Key] // **** Definindo o Id como Primary Key *****
        public int Id {get;set;}
        public String Nome {get;set;}
        public Double Preco {get;set;}

        public String Fornecedor {get; set;}
    }
}