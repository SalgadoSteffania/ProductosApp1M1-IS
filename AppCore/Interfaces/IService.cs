using System;
using System.Collections.Generic;
using System.Text;

namespace AppCore.Interfaces
{
    public interface IService<T> // CRUD
    {
        void Create(T t);
        int Update(T t);
        bool Delete(T t);
        T[] FindAll(T t);


        /// <summary>
        /// UEPS
        /// </summary>
        /// <param name="t"></param>

       void AsignarValoresUnidadUEPS(T t);
        void AsignarValoresTotalUEPS(T t);
        void TotalInventarioUEPS(T t);

        /// <summary>
        /// Promedio simple
        /// </summary>
        /// <param name="t"></param>
        void AsignarValoresUnidadPEPS(T t);
        void AsignarValoresTotalPEPS(T t);
        void TotalInventarioPEPS(T t);


        void AsignarValoresUnidadPONDERADO(T t);
        void AsignarValoresTotalPONDERADO(T t);
        void TotalInventarioPONDERADO(T t);



        void AsignarValoresUnidadPROMSIMPLE(T t);
        void AsignarValoresTotalPROMSIMPLE(T t);
        void TotalInventarioPROMSIMPLE(T t);


    }
}
