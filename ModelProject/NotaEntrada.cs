﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelProject
{
    public class NotaEntrada
    {
        public Guid Id { get; set; }
        public string Numero { get; set; }
        public Fornecedor FornecedorNota { get; set; }
        public string CNPJ { get; set; }
        public DateTime DataEmissão { get; set; }
        public DateTime DataEntrada { get; set; }
        public IList<ProdutoNotaEntrada> Produtos { get; set; }

        public NotaEntrada()
        {
            this.Produtos = new List<ProdutoNotaEntrada>();
        }
        public void RegistrarProdutos(ProdutoNotaEntrada produto)
        {
            if (!this.Produtos.Contains(produto))
                this.Produtos.Add(produto);

        }
        public void RemoverProduto(ProdutoNotaEntrada produto)
        {
            this.Produtos.Remove(produto);
        }
        public void RemovertodosProdutos()
        {
            this.Produtos.Clear();
        }
    }

}