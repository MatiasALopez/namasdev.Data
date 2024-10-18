using System;

namespace namasdev.Data
{
    public abstract class EntidadCreadoModificado<TId> : EntidadCreado<TId>, IEntidadModificacion
        where TId : IEquatable<TId>
    {
		public string UltimaModificacionPor { get; set; }
		public DateTime UltimaModificacionFecha { get; set; }
	}
}
