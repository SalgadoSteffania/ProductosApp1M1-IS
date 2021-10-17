using Domain.Entities;
using Domain.Entities.Invetory;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infraestructure.Inventario
{
    public abstract class InventarioModel
    {
        protected Registros[] inventario;
        
        public void Create(Registros e)
        {
            Add(e, inventario);
        }
        private void Add(Registros e, Registros[] arr)
        {
            if (arr == null)
            {
                arr = new Registros[1];
                arr[0] = e;
                return;
            }

            Registros[] tmp = new Registros[arr.Length + 1];
            Array.Copy(arr, tmp, arr.Length);
            tmp[arr.Length + 1] = e;
            arr = tmp;
        }

        //public Entrada[] GetEntradas()
        //{
        //    Entrada[] arr;

        //    foreach

        //    return
        //}
        public decimal CalcularSaldo()
        {
            decimal totalEntradas = 0, totalSalidas = 0;
            CalcularValorTotal();

            foreach (Entrada e in inventario)
            {
                totalEntradas += e.ValorTotal;
            }

            foreach (Salida e in inventario)
            {
                totalSalidas += e.ValorTotal;
            }

            return totalEntradas - totalSalidas;
        }

        public abstract void CalcularValorTotal();








    }
}
