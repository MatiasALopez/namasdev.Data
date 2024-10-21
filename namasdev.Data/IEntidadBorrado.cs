﻿using System;

namespace namasdev.Data
{
    public interface IEntidadBorrado
    {
        string BorradoPor { get; set; }
        DateTime? BorradoFecha { get; set; }
        bool Borrado { get; set; }
    }
}
