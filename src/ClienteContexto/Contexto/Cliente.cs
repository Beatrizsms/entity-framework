﻿using System;
using System.Collections.Generic;

#nullable disable

namespace ClienteContexto.Contexto
{
    public partial class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Observacao { get; set; }
        public int EnderecoId { get; set; }

        public virtual Endereco Endereco { get; set; }
    }
}
