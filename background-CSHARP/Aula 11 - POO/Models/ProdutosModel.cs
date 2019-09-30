using System;
namespace Aula_1___POO.Models
{
    public class ProdutosModel
    {
        public int IdProduto {get; set;}

        public string NomeProduto {get; set;}

        public string Descricao {get; set;}

        public double Preço {get; set;}

        public FornecedoresModel Fornecedor {get; set;}
    }
}