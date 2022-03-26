﻿using System.Collections.Generic;

namespace Supermercado.Domain
{
    public class Produto
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        
        public ICollection<Categoria> Categorias { get; set; }
        public Estoque Estoque { get; set; } = default;
        
    }
}
