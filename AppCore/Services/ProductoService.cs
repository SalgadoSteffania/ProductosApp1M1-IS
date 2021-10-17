using AppCore.Interfaces;
using Domain.Entities;
using Domain.Enums;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppCore.Services
{
    public class ProductoService : IProductoService
    {
        private IProductoModel productoModel;

        public ProductoService(IProductoModel productoModel)
        {
            this.productoModel = productoModel;
        }

        public void AsignarValoresTotalPEPS(Producto t)
        {
            throw new NotImplementedException();
        }

        public Producto AsignarValoresTotalPONDERADO()
        {
            throw new NotImplementedException();
        }

        public void AsignarValoresTotalPONDERADO(Producto t)
        {
            throw new NotImplementedException();
        }

        public void AsignarValoresTotalPROMSIMPLE(Producto t)
        {
            throw new NotImplementedException();
        }

        public void AsignarValoresTotalUEPS(Producto t)
        {
            throw new NotImplementedException();
        }

        public void AsignarValoresUnidadPEPS(Producto t)
        {
            throw new NotImplementedException();
        }

        public void AsignarValoresUnidadPONDERADO(Producto t)
        {
            throw new NotImplementedException();
        }

        public void AsignarValoresUnidadPROMSIMPLE(Producto t)
        {
            throw new NotImplementedException();
        }

        public void AsignarValoresUnidadUEPS(Producto t)
        {
            throw new NotImplementedException();
        }

        public void Create(Producto t)
        {
            if (t == null)
            {
                throw new ArgumentNullException(nameof(t));
            }

            try
            {
                productoModel.Create(t);   
            }
            catch(Exception ex)
            {
                throw ex;
            }
            
        }

        public bool Delete(Producto t)
        {
            if (t == null)
            {
                throw new ArgumentNullException(nameof(t));
            }

            try
            {
                return productoModel.Delete(t);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Producto[] FindAll()
        {
            return productoModel.FindAll();
        }

        public Producto[] FindAll(Producto t)
        {
            throw new NotImplementedException();
        }

        public int GetLastProductoId()
        {
            return productoModel.GetLastProductoId();
        }

        public Producto GetProductoById(int id)
        {
            if(id <= 0)
            {
                throw new ArgumentException($"El id: {id} no es valido.");
            }   
            return productoModel.GetProductoById(id);
        }

        public string GetProductosAsJson()
        {
            return productoModel.GetProductosAsJson();
        }

        public Producto[] GetProductosByFechaVencimiento(DateTime dt)
        {
            return productoModel.GetProductosByFechaVencimiento(dt);
        }

        public Producto[] GetProductosByRangoPrecio(decimal start, decimal end)
        {
            return productoModel.GetProductosByRangoPrecio(start, end);
        }

        public Producto[] GetProductosByUnidadMedida(UnidadMedida um)
        {
            return productoModel.GetProductosByUnidadMedida(um);
        }

        public Producto[] GetProductosOrderByPrecio()
        {
            return productoModel.GetProductosOrderByPrecio();
        }

        public void TotalInventarioPEPS(Producto t)
        {
            throw new NotImplementedException();
        }

        public void TotalInventarioPONDERADO(Producto t)
        {
            throw new NotImplementedException();
        }

        public void TotalInventarioPROMSIMPLE(Producto t)
        {
            throw new NotImplementedException();
        }

        public void TotalInventarioUEPS(Producto t)
        {
            throw new NotImplementedException();
        }

        public int Update(Producto t)
        {
            if (t == null)
            {
                throw new ArgumentNullException(nameof(t));
            }

            try
            {
                return productoModel.Update(t);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

       







    }
}
