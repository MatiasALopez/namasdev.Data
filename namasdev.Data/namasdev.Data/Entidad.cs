
using System;

namespace namasdev.Data
{
    public abstract class Entidad<TId> : IEntidad<TId>
        where TId : IEquatable<TId>
    {
		public TId Id { get; set; }
    }
}
