using System.Reflection;

namespace Framework.Util
{
    [AttributeUsage(AttributeTargets.Field)]
    public abstract class AbstractEnumStringAttribute : Attribute
    {
        protected string Valor { get; set; }

        protected AbstractEnumStringAttribute(string valor)
        {
            Valor = valor;
        }

        protected static string GetValor<T, TEnumStringAttribute>(T tipo) where TEnumStringAttribute : AbstractEnumStringAttribute
        {
            FieldInfo field = tipo.GetType().GetField(tipo.ToString());
            if (field != null)
            {
                TEnumStringAttribute[] array = field.GetCustomAttributes(typeof(TEnumStringAttribute), inherit: false) as TEnumStringAttribute[];
                if (array != null && array.Length != 0)
                {
                    return array[0].Valor;
                }
            }

            return null;
        }

        protected static T GetEnum<T, TEnumStringAttribute>(string valor) where TEnumStringAttribute : AbstractEnumStringAttribute
        {
            if (valor == null)
            {
                throw new ArgumentNullException("valor");
            }

            string value = valor.Trim();
            foreach (T value2 in Enum.GetValues(typeof(T)))
            {
                string valor2 = GetValor<T, TEnumStringAttribute>(value2);
                if (valor2 != null && valor2.Equals(value))
                {
                    return value2;
                }
            }

            throw new ArgumentException($"Enumerável não encontrado para o tipo '{typeof(T)}', valor {valor}.");
        }
    }
}
