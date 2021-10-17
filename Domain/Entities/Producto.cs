using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class Producto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int Existencia { get; set; }
        public decimal Precio { get; set; }
        public DateTime FechaVencimiento { get; set; }
        public UnidadMedida UnidadMedida { get; set; }


        public decimal AsignarValoresTotalPONDERADO { get; set; }
        public decimal AsignarValoresUnidadPONDERADO { get; set; }
        public decimal TotalInventarioPONDERADO { get; set; }

        public decimal AsignarValoresUnidadPROMSIMPLE { get;set;}
            public decimal AsignarValoresTotalPROMSIMPLE { get;set;}
        public decimal TotalInventarioPROMSIMPLE { get; set; }



             public decimal AsignarValoresUnidadPEPS { get;set;}
            public decimal AsignarValoresTotalPEPS { get;set;}
        public decimal TotalInventarioPEPS { get; set; }




public class ProductoOrderByPrecio : IComparer<Producto>
        {
            public int Compare(Producto x, Producto y)
            {
                if(x.Precio < y.Precio)
                {
                    return -1;
                }else if(x.Precio > y.Precio)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
