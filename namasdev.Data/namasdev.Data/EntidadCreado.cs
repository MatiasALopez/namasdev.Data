﻿using System;

namespace namasdev.Data
{
    public abstract class EntidadCreado<TId> : Entidad<TId>, IEntidadCreado
        where TId : IEquatable<TId>
    {
		public string CreadoPor { get; set; }
		public DateTime CreadoFecha { get; set; }
	}
}
