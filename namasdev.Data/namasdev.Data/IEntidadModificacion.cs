using System;

namespace namasdev.Data
{
    public interface IEntidadModificacion
    {
        string UltimaModificacionPor { get; set; }
        DateTime UltimaModificacionFecha { get; set; }
    }
}
