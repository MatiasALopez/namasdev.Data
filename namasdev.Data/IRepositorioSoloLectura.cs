using System;
using System.Collections.Generic;
using System.Linq.Expressions;

using namasdev.Core.Entity;
using namasdev.Core.Types;

namespace namasdev.Data
{
    public interface IRepositorioSoloLectura<TEntidad, TId>
        where TEntidad : class, IEntidad<TId>
        where TId : IEquatable<TId>
    {
        TEntidad Obtener(TId id, bool incluirBorrados = false);
        TEntidad Obtener(TId id, IEnumerable<string> cargarPropiedades, bool incluirBorrados = false);
        TEntidad Obtener(TId id, IEnumerable<Expression<Func<TEntidad, object>>> cargarPropiedades, bool incluirBorrados = false);
        TEntidad Obtener(TId id, ICargaPropiedades<TEntidad> cargarPropiedades, bool incluirBorrados = false);
        IEnumerable<TEntidad> ObtenerLista(bool incluirBorrados = false, OrdenYPaginacionParametros op = null);
        IEnumerable<TEntidad> ObtenerLista(IEnumerable<string> cargarPropiedades, bool incluirBorrados = false, OrdenYPaginacionParametros op = null);
        IEnumerable<TEntidad> ObtenerLista(IEnumerable<Expression<Func<TEntidad, object>>> cargarPropiedades, bool incluirBorrados = false, OrdenYPaginacionParametros op = null);
        IEnumerable<TEntidad> ObtenerLista(ICargaPropiedades<TEntidad> cargarPropiedades, bool incluirBorrados = false, OrdenYPaginacionParametros op = null);
        bool ExistePorId(TId id, bool incluirBorrados = false);
    }
}
