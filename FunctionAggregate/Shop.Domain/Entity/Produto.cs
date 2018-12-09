using System;
using System.Collections.Generic;

namespace Shop.Domain.Entity
{
    public class Produto
    {
        // IEnumerable nao tem o Add do List
        private List<Produto> _produtos;

        public Produto()
        {
            _produtos = new List<Produto>();
        }

        public string Nome { get; set; }
        public int Valor { get; set; }
        public string Categoria { get; set; }

        public List<Produto> ListarFrutas()
        {
            _produtos.Add(new Produto { Nome = "Banana", Valor = 19, Categoria = "Frutas" });
            _produtos.Add(new Produto { Nome = "Morango", Valor = 125, Categoria = "Frutas" });
            _produtos.Add(new Produto { Nome = "Pera", Valor = 15, Categoria = "Frutas" });
            _produtos.Add(new Produto { Nome = "Abacaxi",Valor = 4, Categoria = "Frutas" });
            _produtos.Add(new Produto { Nome = "Melão", Valor = 9, Categoria = "Frutas" });

            return _produtos;
        }

        public List<Produto> Listareletronicos()
        {
            _produtos.Add(new Produto { Nome = "Iphone", Valor = 1900, Categoria = "Eletronicos" });
            _produtos.Add(new Produto { Nome = "Galaxy", Valor = 1250, Categoria = "Eletronicos" });
            _produtos.Add(new Produto { Nome = "Motorola", Valor = 1500, Categoria = "Eletronicos" });
            _produtos.Add(new Produto { Nome = "Xperia", Valor = 4000, Categoria = "Eletronicos" });

            return _produtos;
        }
    }
}
