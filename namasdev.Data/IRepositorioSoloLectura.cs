﻿using System;
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
        TEntidad Obtener(TId id, bool incluirBorrados = false, IEnumerable<string> cargarPropiedades = null);
        TEntidad Obtener(TId id, bool incluirBorrados = false, IEnumerable<Expression<Func<TEntidad, object>>> cargarPropiedades = null);
        IEnumerable<TEntidad> ObtenerLista(bool incluirBorrados = false, OrdenYPaginacionParametros op = null);
        IEnumerable<TEntidad> ObtenerLista(bool incluirBorrados = false, OrdenYPaginacionParametros op = null, IEnumerable<string> cargarPropiedades = null);
        IEnumerable<TEntidad> ObtenerLista(bool incluirBorrados = false, OrdenYPaginacionParametros op = null, IEnumerable<Expression<Func<TEntidad, object>>> cargarPropiedades = null);
        bool ExistePorId(TId id, bool incluirBorrados = false);
    }
}
