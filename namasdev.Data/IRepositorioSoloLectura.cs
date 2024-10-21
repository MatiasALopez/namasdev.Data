using System;
using System.Collections.Generic;

using namasdev.Core.Types;

namespace namasdev.Data
{
    public interface IRepositorioSoloLectura<TEntidad, TId>
        where TEntidad : class, IEntidad<TId>
        where TId : IEquatable<TId>
    {
        TEntidad Obtener(TId id);
        IEnumerable<TEntidad> ObtenerLista(OrdenYPaginacionParametros op = null);
        bool ExistePorId(TId id);
    }
}
