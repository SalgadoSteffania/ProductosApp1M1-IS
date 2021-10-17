using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities.Invetory
{
    public class Salida : Registros
    {
        public Salida(DateTime fechaRegistro, int existencia) : base(fechaRegistro, existencia)
        {
            ValorUnidad = 0;
            ValorTotal = 0;
        }
    }
}
