﻿using System.ComponentModel.DataAnnotations.Schema;

namespace BlogProjetoFinal.Api.Domain.Entities
{
    public class BaseEntity
    {
        [NotMapped]
        public int CodigoRetorno { get; set; }
        [NotMapped]
        public string MensagemRetorno { get; set; }
    }
}