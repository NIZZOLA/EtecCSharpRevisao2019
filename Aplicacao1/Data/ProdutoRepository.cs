﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacao1.Data
{
    public class ProdutoRepository
    {
        AppEstoqueContext ctx;

        public ProdutoRepository()
        {
            ctx = new AppEstoqueContext();
        }

        public void Incluir( Produto prod)
        {
            ctx.Produtos.Add(prod);
            ctx.SaveChanges();
        }

        public void Alterar( Produto prod )
        {
            var item = this.Consultar(prod.ProdutoId);
            item.Descricao = prod.Descricao;
            item.Custo = prod.Custo;
            item.Margem = prod.Margem;
            item.ValorVenda = prod.ValorVenda;

            ctx.Produtos.Attach(item);
            ctx.Entry(item).State = System.Data.Entity.EntityState.Modified;
            ctx.SaveChanges();
        }

        public void Excluir(int codigo )
        {
            var item = this.Consultar(codigo);
            ctx.Produtos.Remove(item);
            ctx.SaveChanges();
        }

        public Produto Consultar(int codigo)
        {
            var item = ctx.Produtos.Where(a => a.ProdutoId == codigo).FirstOrDefault();
            return item;
        }

        public List<Produto> ConsultarTodos()
        {
            return ctx.Produtos.ToList();
        }
    }
}
