using ecommerce.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ecommerce.DAO
{
    public class ProdutoDAO
    {
        private EcommerceContext context;

        public ProdutoDAO(EcommerceContext context)
        {
            this.context = context;
        }

        public void Adiciona(Produto produto)
        {
            context.Produtos.Add(produto);
            context.SaveChanges();       
        }

        public void Atualiza()
        {
            context.SaveChanges();
        }

        public IList<Produto> Lista()
        {
            return context.Produtos.ToList();
        }

        public void Remove (Produto produto)
        {
            context.Produtos.Remove(produto);
            context.SaveChanges();
        }

        public Produto BuscaPorId (int id)
        {
            return context.Produtos.FirstOrDefault(p => p.Id == id);

    }
}