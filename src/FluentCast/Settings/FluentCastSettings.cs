using System;
using System.Collections.Generic;
using System.Globalization;

namespace FluentCast.Settings
{
    public class FluentCastSettings
    {
        private CultureInfo defaultCulture = CultureInfo.InvariantCulture;
        private readonly Dictionary<Type, CultureInfo> typeCulture = new Dictionary<Type, CultureInfo>();

        public FluentCastSettings DefaultCulture(CultureInfo value)
        {
            defaultCulture = value;
            return this;
        }

        public FluentCastSettings DefaulCulture<T>(CultureInfo value)
        {
            typeCulture[typeof(T)] = value;
            return this;
        }
    }
}