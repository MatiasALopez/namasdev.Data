using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace namasdev.Data
{
    public interface ICargaPropiedades<TEntidad>
        where TEntidad : class
    {
        IEnumerable<Expression<Func<TEntidad, object>>> CrearPaths();
    }
}
