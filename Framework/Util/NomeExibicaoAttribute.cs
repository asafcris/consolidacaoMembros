namespace Framework.Util
{
    [AttributeUsage(AttributeTargets.Field)]
    public sealed class NomeExibicaoAttribute : AbstractEnumStringAttribute
    {
        public string Nome => base.Valor;

        public NomeExibicaoAttribute(string nome)
            : base(nome)
        {
        }

        public static string GetNome<T>(T tipo)
        {
            return GetValor<T, NomeExibicaoAttribute>(tipo);
        }

        public static T GetEnumPeloNome<T>(string nome)
        {
            return GetEnum<T, NomeExibicaoAttribute>(nome);
        }
    }
}
