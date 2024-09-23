using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace pratica_de_cs2.Models
{
    public class Venda
    {
        // public Venda(int id, string produto, decimal preco, DateTime dataVenda){ //Constructor para Serialização
        //     Id = id;
        //     Produto = produto;
        //     Preco = preco;
        //     DataVenda = dataVenda;
        // }
        public int Id { get; set; }

        [JsonProperty("Nome_Produto")]
        public string Produto { get; set; }
        public decimal Preco { get; set; }
        public DateTime DataVenda { get; set; }
    }
}