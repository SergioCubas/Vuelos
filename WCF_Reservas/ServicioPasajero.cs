using System;
using System.Collections.Generic;
using System.Data.Entity.Core;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF_Reservas
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ServicioPasajero" en el código y en el archivo de configuración a la vez.
    public class ServicioPasajero : IServicioPasajero
    {

        public List<PasajeroBE> ListarPasajeros()
        {
            Agencia_BDEntities agencia = new Agencia_BDEntities();

            List<PasajeroBE> objListaPasajero = new List<PasajeroBE>();

            try
            {
                var query = agencia.usp_ListarPasajeros();

                //Recorremos el resultado
                foreach (var resultado in query)
                {
                    PasajeroBE objPasajeroBE = new PasajeroBE();

                    objPasajeroBE.NombreCompleto = resultado.Nombre_completo;
                    objPasajeroBE.NumeroDocumento = resultado.Número_de_Documento;
                    objPasajeroBE.Telefono = resultado.telefono;
                    objPasajeroBE.Email = resultado.email;
                    objPasajeroBE.Pais = resultado.País;
                    objPasajeroBE.Genero = resultado.genero;
                    objPasajeroBE.Departamento = resultado.Departamento;
                    objListaPasajero.Add(objPasajeroBE);
                }

                return objListaPasajero;
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }

        }


        public List<PasajeroBE> GetPasajeroDetallePagoPorDni(String dni)
        {
            Agencia_BDEntities agencia = new Agencia_BDEntities();

            List<PasajeroBE> objListaPasajero = new List<PasajeroBE>();

            try
            {
                var query = agencia.usp_ListarPasajeroDetallePagoPorDocumento(dni);
                //Recorremos el resultado
               foreach (var resultado in query)
                {
                    PasajeroBE objPasajeroBE = new PasajeroBE();

                    objPasajeroBE.NombreCompleto = resultado.Nombre_completo;
                    objPasajeroBE.NumeroDocumento = resultado.num_documento;
                    objPasajeroBE.NumeroComprobante = resultado.num_comprobante;
                    objPasajeroBE.MedioPago = resultado.medio_pago;
                    objPasajeroBE.TipoComprobante = resultado.tipo_comprobante;
                    objPasajeroBE.TipoVuelo = resultado.Tipo_de_Vuelo;
                    objPasajeroBE.Precio = resultado.precio.ToString();


                    objListaPasajero.Add(objPasajeroBE);
                }

                return objListaPasajero;
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }

        }

        public Int16 GetContarPasajerosPorPais(String pais)
        {
            Agencia_BDEntities agencia = new Agencia_BDEntities();

            try
            {

                Int16 cantPasajeros = Convert.ToInt16
                    (
                        (
                        from Pas in agencia.Tb_pasajero
                        join Ubi in agencia.Tb_pais on Pas.idPais equals Ubi.idPais
                        where Ubi.nombre == pais
                        select Pas).Count()
                    );

                return cantPasajeros;
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }


        }

        public List<PasajeroBE> ListarPasajerosPorDepartamento(String departamento)
        {
            try
            {
                Agencia_BDEntities agencia = new Agencia_BDEntities();
                List<PasajeroBE> listaPasajero = new List<PasajeroBE>();
                var query = agencia.usp_ListarPasajerosPorDepartamento(departamento);
                //Recorremos el resultado
                foreach (var resultado in query)
                {
                    PasajeroBE objPasajeroBE = new PasajeroBE();

                    objPasajeroBE.NombreCompleto = resultado.Nombre_completo;
                    objPasajeroBE.NumeroDocumento = resultado.Número_de_Documento;
                    objPasajeroBE.Telefono = resultado.telefono;
                    objPasajeroBE.Email = resultado.email;
                    objPasajeroBE.Pais = resultado.País;
                    objPasajeroBE.Departamento = resultado.Departamento;

                    listaPasajero.Add(objPasajeroBE);
                }

                return listaPasajero;
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<PasajeroBE> ListarPasajerosPorGenero(String genero)
        {
            try
            {
                Agencia_BDEntities agencia = new Agencia_BDEntities();
                List<PasajeroBE> listaPasajero = new List<PasajeroBE>();
                var query = agencia.usp_ListarPasajerosPorGeneroO(genero);
                //Recorremos el resultado
                foreach (var resultado in query)
                {
                    PasajeroBE objPasajeroBE = new PasajeroBE();

                    objPasajeroBE.NombreCompleto = resultado.Nombre_completo;
                    objPasajeroBE.NumeroDocumento = resultado.Número_de_Documento;
                    objPasajeroBE.Telefono = resultado.telefono;
                    objPasajeroBE.Email = resultado.email;
                    objPasajeroBE.Pais = resultado.País;
                    objPasajeroBE.Departamento = resultado.Departamento;

                    listaPasajero.Add(objPasajeroBE);
                }

                return listaPasajero;
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<PasajeroBE> ListarPasajerosPorPais(String pais)
        {
            try
            {
                Agencia_BDEntities agencia = new Agencia_BDEntities();
                List<PasajeroBE> listaPasajero = new List<PasajeroBE>();
                var query = agencia.usp_ListarPasajerosPorPais(pais);
                //Recorremos el resultado
                foreach (var resultado in query)
                {
                    PasajeroBE objPasajeroBE = new PasajeroBE();

                    objPasajeroBE.NombreCompleto = resultado.Nombre_completo;
                    objPasajeroBE.NumeroDocumento = resultado.Número_de_Documento;
                    objPasajeroBE.Telefono = resultado.telefono;
                    objPasajeroBE.Email = resultado.email;
                    objPasajeroBE.Pais = resultado.País;
                    objPasajeroBE.Departamento = resultado.Departamento;
                    listaPasajero.Add(objPasajeroBE);
                }

                return listaPasajero;
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<PasajeroBE> ListarDepartamentos()
        {
            Agencia_BDEntities agencia = new Agencia_BDEntities();
            try
            {
                List<PasajeroBE> listaPasajero = new List<PasajeroBE>();
                var query = agencia.Tb_departamento.OrderBy(x => x.nombre);

                foreach (var resultado in query)
                {
                    PasajeroBE objPasajeroBE = new PasajeroBE();
                    objPasajeroBE.IdDepart = (Int32)resultado.id_departamento;
                    objPasajeroBE.NomDep = resultado.nombre;
                    listaPasajero.Add(objPasajeroBE);
                }
                return listaPasajero;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public List<PasajeroBE> ListarPaises()
        {
            Agencia_BDEntities agencia = new Agencia_BDEntities();
            try
            {
                List<PasajeroBE> listaPasajero = new List<PasajeroBE>();
                var query = agencia.Tb_pais.OrderBy(x => x.nombre);

                foreach (var resultado in query)
                {
                    PasajeroBE objPasajeroBE = new PasajeroBE();
                    objPasajeroBE.IdPais = (Int32)resultado.idPais;
                    objPasajeroBE.NomPais = resultado.nombre;
                    listaPasajero.Add(objPasajeroBE);
                }
                return listaPasajero;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }






        //public List<PasajeroBE> GetPasajeroDetallePagoPorDni(String dni)
        //{
        //    Agencia_BDEntities agencia = new Agencia_BDEntities();

        //    List<PasajeroBE> objListaPasajero = new List<PasajeroBE>();

        //    try
        //    {
        //        var query = agencia.usp_ListarPasajeroDetallePorDni(dni);

        //        //Recorremos el resultado
        //        foreach (var resultado in query)
        //        {
        //            PasajeroBE objPasajeroBE = new PasajeroBE();

        //            objPasajeroBE.NombreCompleto = resultado.NombreCompleto;
        //            objPasajeroBE.NumeroDocumento = resultado.num_documento;
        //            objPasajeroBE.FechaPago = resultado.FechaPago;
        //            objPasajeroBE.NumeroComprobante = resultado.num_comprobante;

        //            objListaPasajero.Add(objPasajeroBE);
        //        }

        //        return objListaPasajero;
        //    }
        //    catch (EntityException ex)
        //    {
        //        throw new Exception(ex.Message);
        //    }

        //}


        //public List<PasajeroBE> GetPasajeroAerolinea(String ruc)
        //{
        //    Agencia_BDEntities agencia = new Agencia_BDEntities();

        //    List<PasajeroBE> objListaPasajero = new List<PasajeroBE>();

        //    try
        //    {
        //        var query = agencia.usp_ListarPasajeroAerolinea(ruc);

        //        //Recorremos el resultado
        //        foreach (var resultado in query)
        //        {
        //            PasajeroBE objPasajeroBE = new PasajeroBE();

        //            objPasajeroBE.NombreCompleto = resultado.NombreCompleto;
        //            objPasajeroBE.NumeroDocumento = resultado.num_documento;
        //            objPasajeroBE.Ruc = resultado.ruc;
        //            objPasajeroBE.Aerolinea = resultado.Aerolinea;

        //            objListaPasajero.Add(objPasajeroBE);
        //        }

        //        return objListaPasajero;
        //    }
        //    catch (EntityException ex)
        //    {
        //        throw new Exception(ex.Message);
        //    }

        //}


    }
}
