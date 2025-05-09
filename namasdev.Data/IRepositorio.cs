﻿using System;
using System.Collections.Generic;

using namasdev.Core.Entity;

namespace namasdev.Data
{
    public interface IRepositorio<TEntidad, TId> : IRepositorioSoloLectura<TEntidad, TId>
        where TEntidad : class, IEntidad<TId>
        where TId : IEquatable<TId>
    {
        void Agregar(IEnumerable<TEntidad> entidades, int tamañoBatch = 100);
        void Agregar(TEntidad entidad);
        void Actualizar(IEnumerable<TEntidad> entidades, int tamañoBatch = 100);
        void Actualizar(TEntidad entidad);
        void ActualizarPropiedades(IEnumerable<TEntidad> entidades, int tamañoBatch = 100, params string[] propiedades);
        void ActualizarPropiedades(TEntidad entidad, params string[] propiedades);
        void ActualizarDatosBorrado(TEntidad entidad);
        void ActualizarDatosBorrado(IEnumerable<TEntidad> entidades, int tamañoBatch = 100);
        void Eliminar(IEnumerable<TEntidad> entidades, int tamañoBatch = 100);
        void Eliminar(TEntidad entidad);
        void EliminarPorId(IEnumerable<TId> ids, int tamañoBatch = 100);
        void EliminarPorId(TId id);
    }
}
