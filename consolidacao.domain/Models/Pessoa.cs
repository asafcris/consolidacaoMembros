namespace consolidacao.domain.Models
{
    public class Pessoa
    {
        public virtual int Id { get; set; }
        public virtual string Nome { get; set; }
        public virtual string Apelido { get; set; }
        public virtual string DataNascimento { get; set; }
        public virtual EnumSexo Sexo { get; set; }

    }
}
