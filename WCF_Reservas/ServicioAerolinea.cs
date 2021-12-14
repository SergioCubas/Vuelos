using System;
using System.Collections.Generic;
using System.Data.Entity.Core;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF_Reservas
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ServicioAerolinea" en el código y en el archivo de configuración a la vez.
    public class ServicioAerolinea : IServicioAerolinea
    {

        public List<AerolineaBE> ListarAerolinea()
        {
            Agencia_BDEntities agencia = new Agencia_BDEntities();

            List<AerolineaBE> objListaAerolinea = new List<AerolineaBE>();
            try
            {
                //var query = agencia.usp_ListarAerolinea();
                //foreach (var resultado in query)
                //{
                //    AerolineaBE objAerolineaBE = new AerolineaBE();
                //    objAerolineaBE.Aerolinea = resultado.nombre;
                //    objAerolineaBE.Ruc = resultado.ruc;
                //    objListaAerolinea.Add(objAerolineaBE);
                //}
                return objListaAerolinea;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public List<AerolineaBE> GetAllAerolineaPais(String departamento)
        {
            Agencia_BDEntities agencia = new Agencia_BDEntities();

            List<AerolineaBE> objListaAerolinea = new List<AerolineaBE>();

            try
            {
                var query = agencia.usp_ListarAerolineaPaisPorDepartamento(departamento);

            foreach (var resultado in query)
                {
                    AerolineaBE objAerolineaBE = new AerolineaBE();

                    objAerolineaBE.Aerolinea = resultado.Aerolinea;
                    objAerolineaBE.Ruc = resultado.RUC;
                    objAerolineaBE.Pais = resultado.Pais;
                    objAerolineaBE.Departamento = resultado.Departamento;

                    objListaAerolinea.Add(objAerolineaBE);
                }

                return objListaAerolinea;
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }

        }




        public Int16 GetContarAerolinea()
        {
            Agencia_BDEntities agencia = new Agencia_BDEntities();

            try
            {

                Int16 cantAerolinea = Convert.ToInt16
                    (
                        (
                        from Ae in agencia.Tb_aerolinea
                        where Ae.estado == 1
                        select Ae.nombre).Count()
                    );

                return cantAerolinea;
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }


        }


        //public List<AerolineaBE> GetAllAerolineaAeropuerto(String ruc)
        //{
        //    Agencia_BDEntities agencia = new Agencia_BDEntities();

        //    List<AerolineaBE> objListaAerolinea = new List<AerolineaBE>();

        //    try
        //    {
        //        var query = agencia.usp_ListarAerolineaAeropuerto(ruc);

        //        //Recorremos el resultado
        //        foreach (var resultado in query)
        //        {
        //            AerolineaBE objAerolineaBE = new AerolineaBE();
        //            objAerolineaBE.Aeropuerto = resultado.Aeropuerto;
        //            objAerolineaBE.Aerolinea = resultado.Aerolinea;
        //            objAerolineaBE.Ruc = resultado.ruc;
        //            objAerolineaBE.Pais = resultado.Pais;
        //            objAerolineaBE.Ciudad = resultado.Ciudad;

        //            objListaAerolinea.Add(objAerolineaBE);
        //        }

        //        return objListaAerolinea;
        //    }
        //    catch (EntityException ex)
        //    {
        //        throw new Exception(ex.Message);
        //    }

        //}

        public List<AerolineaBE> GetAllPrecioAerolineaAsiento(String ruc)
        {
            Agencia_BDEntities agencia = new Agencia_BDEntities();

            List<AerolineaBE> objListaAerolinea = new List<AerolineaBE>();

            try
            {
                var query = agencia.usp_ListarAsientosDisponiblesPorRucAerolinea(ruc);

                foreach (var resultado in query)
                {
                    AerolineaBE objAerolineaBE = new AerolineaBE();
                    objAerolineaBE.Aerolinea = resultado.nombre;
                    objAerolineaBE.Ruc = resultado.ruc;
                    objAerolineaBE.Tipo = resultado.tipo;
                    objAerolineaBE.Fila = resultado.fila;

                    objListaAerolinea.Add(objAerolineaBE);
                }

                return objListaAerolinea;
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }

        }



    }
}
