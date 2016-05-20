using ecommerce.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ecommerce.DAO
{
    public class EcommerceContext : DbContext
    {
        public DbSet<Produto> Produtos { get; set; }
  
    }
}