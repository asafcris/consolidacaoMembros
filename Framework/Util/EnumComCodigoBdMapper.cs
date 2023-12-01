using NHibernate.Type;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.Util
{
    public class EnumComCodigoBdMapper<T> : EnumStringType<T>
    {
        public override object GetInstance(object value);
        public override object GetValue(object enumValue);
    }
}
