using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ecommerce.Entidades
{
    public class Produto
    {
        public int Id { get; set; }

        [Required]
        public String Nome { get; set; }

        [Required]
        public decimal Preco { get; set; }

    }
}