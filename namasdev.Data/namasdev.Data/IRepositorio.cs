using System;
using System.Collections.Generic;

namespace namasdev.Data
{
    public interface IRepositorio<TEntidad, TId> : IRepositorioSoloLectura<TEntidad, TId>
        where TEntidad : class, IEntidad<TId>
        where TId : IEquatable<TId>
    {
        void Agregar(IEnumerable<TEntidad> entidades, int tamañoBatch);
        void Agregar(TEntidad entidad);
        void Actualizar(IEnumerable<TEntidad> entidades, int tamañoBatch);
        void Actualizar(TEntidad entidad);
        void Eliminar(IEnumerable<TEntidad> entidades, int tamañoBatch);
        void Eliminar(TEntidad entidad);
        void EliminarPorId(IEnumerable<TId> ids, int tamañoBatch);
        void EliminarPorId(TId id);
    }
}
