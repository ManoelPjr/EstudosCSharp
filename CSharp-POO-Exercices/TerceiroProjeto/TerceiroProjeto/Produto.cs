using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace TerceiroProjeto
{
    class Produto
    {
        private string _nome;
        public double Preco { get; private set; }
        public int Quantidade { get; private set; }
    

        public Produto()
        {
            Quantidade = 10;
        }

        public Produto(string nome, double preco) : this()
        {
            _nome = nome;
            Preco = preco;
        }

        public Produto(string nome, double preco, int quantidade) : this(nome, preco)
        {
            Quantidade = quantidade;
        }

        /// <summary>
        /// propertys ajudam a simplificar os gets e sets sem expor os fields
        /// </summary>
        public string Nome
        {
            get
            {
                return _nome;
            }
            set
            {
                string NomeLimpo = value.Trim();
                if (NomeLimpo != null && NomeLimpo.Length > 1)
                {
                    _nome = NomeLimpo;
                }
            }
        }



        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }

        public void AdicionarProdutos(int quantidade)
        {
            Quantidade += quantidade;
        }

        public void RemoverProdutos(int quantidade)
        {
            Quantidade -= quantidade;
        }

        public override string ToString()
        {
            return _nome
                + ", $ "
                + Preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + Quantidade
                + " unidades, Total: $ "
                + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
