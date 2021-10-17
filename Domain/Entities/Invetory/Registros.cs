using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities.Invetory
{
    public abstract class Registros
    {
        public DateTime FechaRegistro { get; set; }
        public int Existencia { get; set; }
        public decimal ValorUnidad { get; set; }
        public decimal ValorTotal { get; set; }

        protected Registros(DateTime fechaRegistro, int existencia)
        {
            this.FechaRegistro = fechaRegistro;
            this.Existencia = existencia;
        }
    }
}
