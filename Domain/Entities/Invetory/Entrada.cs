using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities.Invetory
{
    public class Entrada : Registros
    {
        public Entrada(DateTime fechaRegistro, int existencia, decimal valorU, decimal valorT) : base(fechaRegistro, existencia)
        {
            ValorUnidad = valorU;
            ValorTotal = valorT;
        }
    }
}
