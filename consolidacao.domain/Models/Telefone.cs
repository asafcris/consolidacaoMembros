﻿namespace consolidacao.domain.Models
{
    public class Telefone
    {
        public virtual int Id { get; set; }
        public virtual int Numero { get; set; }
        public virtual EnumTipo TipoTelefone { get; set; }
        public virtual Pessoa Pessoa { get; set; }

    }
}
