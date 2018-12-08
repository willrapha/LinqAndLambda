using System;
using System.Collections.Generic;
using System.Text;

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

        public Guid Id { get; set; }
        public string Nome { get; set; }
        public int Quantidade { get; set; }
        public int Valor { get; set; }
        public DateTime DataVencimento { get; set; }

        public List<Produto> Listar()
        {
            _produtos.Add(new Produto { Id = Guid.NewGuid(), Nome = "Banana", Quantidade = 5, Valor = 19, DataVencimento = DateTime.Now.AddDays(5) });
            _produtos.Add(new Produto { Id = Guid.NewGuid(), Nome = "Morango", Quantidade = 4, Valor = 12, DataVencimento = DateTime.Now.AddDays(5) });
            _produtos.Add(new Produto { Id = Guid.NewGuid(), Nome = "Pera", Quantidade = 2, Valor = 15, DataVencimento = DateTime.Now.AddDays(5) });
            _produtos.Add(new Produto { Id = Guid.NewGuid(), Nome = "Abacaxi", Quantidade = 1, Valor = 4, DataVencimento = DateTime.Now.AddDays(5) });
            _produtos.Add(new Produto { Id = Guid.NewGuid(), Nome = "Melão", Quantidade = 35, Valor = 9, DataVencimento = DateTime.Now.AddYears(1) });

            return _produtos;
        }
    }
}
