using Liquid.Repository;
using System;
using System.Collections;
using System.Collections.Generic;

namespace BlogProjetoFinal.Domain.Entities
{
    public class CategoriaEntity : LiquidEntity<int>
    {
        public string NomeCategoria { get; set; }
        public DateTime DataCriacao { get; set; }
        public DateTime DataAtualizacao { get; set; }
    }
}