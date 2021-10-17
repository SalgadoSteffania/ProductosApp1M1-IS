using Domain.Entities;
using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Interfaces
{
    public interface IProductoModel : IModel<Producto>
    {
        Producto GetProductoById(int id);

        Producto[] GetProductosByUnidadMedida(UnidadMedida um);

        Producto[] GetProductosByFechaVencimiento(DateTime dt);

        Producto[] GetProductosByRangoPrecio(decimal start, decimal end);

        string GetProductosAsJson();

        Producto[] GetProductosOrderByPrecio();

        int GetLastProductoId();


        decimal AsignarValoresUnidadPONDERADO();
        decimal AsignarValoresTotalPONDERADO();
        decimal TotalInventarioPONDERADO();


        decimal AsignarValoresUnidadPROMSIMPLE();
        decimal AsignarValoresTotalPROMSIMPLE();
        decimal TotalInventarioPROMSIMPLE();

        decimal AsignarValoresUnidadPEPS();
        decimal AsignarValoresTotalPEPS();
        decimal TotalInventarioPEPS();





















    }
}
