
using System;

namespace namasdev.Data
{
    public interface IEntidad<TId>
        where TId : IEquatable<TId>
    {
        TId Id { get; set; }
    }
}
