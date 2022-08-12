using Liquid.Repository;
using System;

namespace BlogProjetoFinal.Domain.Entities
{
    public class UsuarioEntity : LiquidEntity<int>
    {
        public string Name { get; set; }
    }
}
