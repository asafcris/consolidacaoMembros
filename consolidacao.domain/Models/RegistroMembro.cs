namespace consolidacao.domain.Models
{
    public class RegistroMembro
    {
        public virtual int Id { get; set; }
        public virtual Pessoa Pessoa { get; set; }
        public virtual DateTime DataConversao { get; set; }
        public virtual DateTime DataBatismo { get; set; }

    }
}
