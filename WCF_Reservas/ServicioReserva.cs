using System;
using System.Collections.Generic;
using System.Data.Entity.Core;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF_Reservas
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ServicioReserva" en el código y en el archivo de configuración a la vez.
    public class ServicioReserva : IServicioReserva
    {

        public List<ReservaBE> ListarReservas()
        {
            Agencia_BDEntities agencia = new Agencia_BDEntities();

            List<ReservaBE> objListaReserva = new List<ReservaBE>();

            try
            {
                var query = agencia.usp_ListarReservas();

                //Recorremos el resultado
                foreach (var resultado in query)
                {
                    ReservaBE objReservaBE = new ReservaBE();

                    objReservaBE.Nombre = resultado.Nombre_completo;
                    objReservaBE.NumDocumento = resultado.Numero_Documento;
                    objReservaBE.Telefono = resultado.telefono;
                    objReservaBE.Email = resultado.email;
                    objReservaBE.Asiento = resultado.Asiento;
                    objReservaBE.Genero = resultado.genero;
                    objReservaBE.Tipo_asiento = resultado.tipo;
                    objReservaBE.Precio = Convert.ToDouble(resultado.precio);
                    objReservaBE.Nombre_ciudadOrigen = resultado.Ciudad_Origen;
                    objReservaBE.Nombre_ciudadDestino = resultado.Ciudad_Destino;
                    objReservaBE.Fecha_Salida = Convert.ToDateTime(resultado.Fecha_Salida);
                    objReservaBE.Fecha_Llegada = Convert.ToDateTime(resultado.Fecha_Llegada);
                    objReservaBE.Nombre_PaisOrigen = resultado.Pais_Origen;
                    objReservaBE.Nombre_PaisDestino = resultado.Pais_Destino;
                    objReservaBE.NombreAeropuertoOrigen = resultado.Aeropuerto_Origen;
                    objReservaBE.NombreAeropuertoDestino = resultado.Aeropuerto_Destino;
                    objReservaBE.Nombre_Aerolinea = resultado.Aerolinea;


                    objListaReserva.Add(objReservaBE);
                }

                return objListaReserva;
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }

        }

        public List<ReservaBE> ListarReservasPorCiudadOrigen(String ciudad)
        {
            Agencia_BDEntities agencia = new Agencia_BDEntities();

            List<ReservaBE> objListaReserva = new List<ReservaBE>();

            try
            {
                var query = agencia.usp_ListarReservasPorCiudadOrigen(ciudad);

                //Recorremos el resultado
                foreach (var resultado in query)
                {
                    ReservaBE objReservaBE = new ReservaBE();

                    objReservaBE.Nombre = resultado.Nombre_completo;
                    objReservaBE.NumDocumento = resultado.Numero_Documento;
                    objReservaBE.Telefono = resultado.telefono;
                    objReservaBE.Email = resultado.email;
                    objReservaBE.Asiento = resultado.Asiento;
                    objReservaBE.Genero = resultado.genero;
                    objReservaBE.Tipo_asiento = resultado.tipo;
                    objReservaBE.Precio = Convert.ToDouble(resultado.precio);
                    objReservaBE.Nombre_ciudadOrigen = resultado.Ciudad_Origen;
                    objReservaBE.Nombre_ciudadDestino = resultado.Ciudad_Destino;
                    objReservaBE.Fecha_Salida = Convert.ToDateTime(resultado.Fecha_Salida);
                    objReservaBE.Fecha_Llegada = Convert.ToDateTime(resultado.Fecha_Llegada);
                    objReservaBE.Nombre_PaisOrigen = resultado.Pais_Origen;
                    objReservaBE.Nombre_PaisDestino = resultado.Pais_Destino;
                    objReservaBE.NombreAeropuertoOrigen = resultado.Aeropuerto_Origen;
                    objReservaBE.NombreAeropuertoDestino = resultado.Aeropuerto_Destino;
                    objReservaBE.Nombre_Aerolinea = resultado.Aerolinea;


                    objListaReserva.Add(objReservaBE);
                }

                return objListaReserva;
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }

        }

        public List<ReservaBE> ListarReservasPorCiudadDestino(String ciudad)
        {
            Agencia_BDEntities agencia = new Agencia_BDEntities();

            List<ReservaBE> objListaReserva = new List<ReservaBE>();

            try
            {
                var query = agencia.usp_ListarReservasPorCiudadDestino(ciudad);

                //Recorremos el resultado
                foreach (var resultado in query)
                {
                    ReservaBE objReservaBE = new ReservaBE();

                    objReservaBE.Nombre = resultado.Nombre_completo;
                    objReservaBE.NumDocumento = resultado.Numero_Documento;
                    objReservaBE.Telefono = resultado.telefono;
                    objReservaBE.Email = resultado.email;
                    //objReservaBE.Asiento = resultado.Asiento;
                    objReservaBE.Genero = resultado.genero;
                    //objReservaBE.Tipo_asiento = resultado.tipo;
                    //objReservaBE.Precio = Convert.ToDouble(resultado.precio);
                    objReservaBE.Nombre_ciudadOrigen = resultado.Ciudad_Origen;
                    objReservaBE.Nombre_ciudadDestino = resultado.Ciudad_Destino;
                    objReservaBE.Fecha_Salida = Convert.ToDateTime(resultado.Fecha_Salida);
                    objReservaBE.Fecha_Llegada = Convert.ToDateTime(resultado.Fecha_Llegada);
                    objReservaBE.Nombre_PaisOrigen = resultado.Pais_Origen;
                    objReservaBE.Nombre_PaisDestino = resultado.Pais_Destino;
                    objReservaBE.NombreAeropuertoOrigen = resultado.Aeropuerto_Origen;
                    objReservaBE.NombreAeropuertoDestino = resultado.Aeropuerto_Destino;
                    objReservaBE.Nombre_Aerolinea = resultado.Aerolinea;


                    objListaReserva.Add(objReservaBE);
                }

                return objListaReserva;
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }

        }

        public List<ReservaBE> ListarReservasPorFechaSalida(DateTime fecha1, DateTime fecha2)
        {
            Agencia_BDEntities agencia = new Agencia_BDEntities();

            List<ReservaBE> objListaReserva = new List<ReservaBE>();

            try
            {
                var query = agencia.usp_ListarReservasPorPorFechaSalida(fecha1, fecha2);

                //Recorremos el resultado
                foreach (var resultado in query)
                {
                    ReservaBE objReservaBE = new ReservaBE();

                    objReservaBE.Nombre = resultado.Nombre_completo;
                    objReservaBE.NumDocumento = resultado.Numero_Documento;
                    objReservaBE.Telefono = resultado.telefono;
                    objReservaBE.Email = resultado.email;
                    //objReservaBE.Asiento = resultado.Asiento;
                    objReservaBE.Genero = resultado.genero;
                    //objReservaBE.Tipo_asiento = resultado.tipo;
                    //objReservaBE.Precio = Convert.ToDouble(resultado.precio);
                    objReservaBE.Nombre_ciudadOrigen = resultado.Ciudad_Origen;
                    objReservaBE.Nombre_ciudadDestino = resultado.Ciudad_Destino;
                    objReservaBE.Fecha_Salida = Convert.ToDateTime(resultado.Fecha_Salida);
                    objReservaBE.Fecha_Llegada = Convert.ToDateTime(resultado.Fecha_Llegada);
                    objReservaBE.Nombre_PaisOrigen = resultado.Pais_Origen;
                    objReservaBE.Nombre_PaisDestino = resultado.Pais_Destino;
                    objReservaBE.NombreAeropuertoOrigen = resultado.Aeropuerto_Origen;
                    objReservaBE.NombreAeropuertoDestino = resultado.Aeropuerto_Destino;
                    objReservaBE.Nombre_Aerolinea = resultado.Aerolinea;


                    objListaReserva.Add(objReservaBE);
                }

                return objListaReserva;
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }

        }

        public List<ReservaBE> ListarReservasPorFechaLlegada(DateTime fecha1, DateTime fecha2)
        {
            Agencia_BDEntities agencia = new Agencia_BDEntities();

            List<ReservaBE> objListaReserva = new List<ReservaBE>();

            try
            {
                var query = agencia.usp_ListarReservasPorPorFechaLlegada(fecha1, fecha2);

                //Recorremos el resultado
                foreach (var resultado in query)
                {
                    ReservaBE objReservaBE = new ReservaBE();

                    objReservaBE.Nombre = resultado.Nombre_completo;
                    objReservaBE.NumDocumento = resultado.Numero_Documento;
                    objReservaBE.Telefono = resultado.telefono;
                    objReservaBE.Email = resultado.email;
                    //objReservaBE.Asiento = resultado.Asiento;
                    objReservaBE.Genero = resultado.genero;
                    //objReservaBE.Tipo_asiento = resultado.tipo;
                    //objReservaBE.Precio = Convert.ToDouble(resultado.precio);
                    objReservaBE.Nombre_ciudadOrigen = resultado.Ciudad_Origen;
                    objReservaBE.Nombre_ciudadDestino = resultado.Ciudad_Destino;
                    objReservaBE.Fecha_Salida = Convert.ToDateTime(resultado.Fecha_Salida);
                    objReservaBE.Fecha_Llegada = Convert.ToDateTime(resultado.Fecha_Llegada);
                    objReservaBE.Nombre_PaisOrigen = resultado.Pais_Origen;
                    objReservaBE.Nombre_PaisDestino = resultado.Pais_Destino;
                    objReservaBE.NombreAeropuertoOrigen = resultado.Aeropuerto_Origen;
                    objReservaBE.NombreAeropuertoDestino = resultado.Aeropuerto_Destino;
                    objReservaBE.Nombre_Aerolinea = resultado.Aerolinea;


                    objListaReserva.Add(objReservaBE);
                }

                return objListaReserva;
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }

        }

        public List<ReservaBE> ListarReservasPorDni(String dni)
        {
            Agencia_BDEntities agencia = new Agencia_BDEntities();

            List<ReservaBE> objListaReserva = new List<ReservaBE>();

            try
            {
                var query = agencia.usp_ListarReservasPorDni(dni);

                //Recorremos el resultado
                foreach (var resultado in query)
                {
                    ReservaBE objReservaBE = new ReservaBE();

                    objReservaBE.Nombre = resultado.Nombre_completo;
                    objReservaBE.NumDocumento = resultado.Numero_Documento;
                    objReservaBE.Telefono = resultado.telefono;
                    objReservaBE.Email = resultado.email;
                    objReservaBE.Asiento = resultado.Asiento;
                    objReservaBE.Genero = resultado.genero;
                    objReservaBE.Tipo_asiento = resultado.tipo;
                    objReservaBE.Precio = Convert.ToDouble(resultado.precio);
                    objReservaBE.Nombre_ciudadOrigen = resultado.Ciudad_Origen;
                    objReservaBE.Nombre_ciudadDestino = resultado.Ciudad_Destino;
                    objReservaBE.Fecha_Salida = Convert.ToDateTime(resultado.Fecha_Salida);
                    objReservaBE.Fecha_Llegada = Convert.ToDateTime(resultado.Fecha_Llegada);
                    objReservaBE.Nombre_PaisOrigen = resultado.Pais_Origen;
                    objReservaBE.Nombre_PaisDestino = resultado.Pais_Destino;
                    objReservaBE.NombreAeropuertoOrigen = resultado.Aeropuerto_Origen;
                    objReservaBE.NombreAeropuertoDestino = resultado.Aeropuerto_Destino;
                    objReservaBE.Nombre_Aerolinea = resultado.Aerolinea;


                    objListaReserva.Add(objReservaBE);
                }

                return objListaReserva;
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }

        }

        public List<VueloBE> ListarDepartamentos()
        {
            Agencia_BDEntities vuelo = new Agencia_BDEntities();

            List<VueloBE> objListaVuelo = new List<VueloBE>();
            try
            {

                var query = vuelo.Tb_departamento.OrderBy(x => x.nombre);

                foreach (var resultado in query)
                {
                    VueloBE objVueloBE = new VueloBE();
                    objVueloBE.IdDepart = (Int32)resultado.id_departamento;
                    objVueloBE.Nombre_Departamento = resultado.nombre;
                    objListaVuelo.Add(objVueloBE);
                }
                return objListaVuelo;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        //public List<ReservaBE> GetAllReservaPaisFechas(String fecini, String fecfin)
        //{
        //    Agencia_BDEntities agencia = new Agencia_BDEntities();

        //    List<ReservaBE> objListaReserva = new List<ReservaBE>();

        //    try
        //    {
        //        var query = agencia.usp_ListarAerolineaReservaPaisPorFecha(fecini, fecfin);

        //    foreach (var resultado in query)
        //        {
        //            ReservaBE objReservaBE = new ReservaBE();

        //            objReservaBE.Aerolinea = resultado.Aerolinea;
        //            objReservaBE.Ruc = resultado.RUC;
        //            objReservaBE.Pais= resultado.Pais;
        //            objReservaBE.Departamento = resultado.Departamento;

        //            objListaReserva.Add(objReservaBE);
        //        }

        //        return objListaReserva;
        //    }
        //    catch (EntityException ex)
        //    {
        //        throw new Exception(ex.Message);
        //    }

        //}


        //public List<ReservaBE> GetAllAsientosDisponiblesDeAerolineaParaReserva(String nombre)
        //{
        //    Agencia_BDEntities agencia = new Agencia_BDEntities();

        //    List<ReservaBE> objListaReserva = new List<ReservaBE>();

        //    try
        //    {
        //        //var query = agencia.usp_ListarAsientosDisponiblesDeAerolineaParaReserva(nombre);

        //        ////Recorremos el resultado
        //        //foreach (var resultado in query)
        //        //{
        //        //    ReservaBE objReservaBE = new ReservaBE();

        //        //    objReservaBE.Nombre = resultado.nombre;
        //        //    objReservaBE.Ruc = resultado.ruc;
        //        //    objReservaBE.Letra = resultado.letra;
        //        //    objReservaBE.Fila = Convert.ToInt16(resultado.fila);
        //        //    objReservaBE.Precio = (double)resultado.precio;

        //        //    objListaReserva.Add(objReservaBE);
        //        //}

        //        return objListaReserva;
        //    }
        //    catch (EntityException ex)
        //    {
        //        throw new Exception(ex.Message);
        //    }

        //}


        //public Int16 GetContarReservar(Int16 estado)
        //{
        //    Agencia_BDEntities agencia = new Agencia_BDEntities();

        //    try
        //    {
        //        Int16 cantReservas = Convert.ToInt16
        //        (
        //        (
        //        from objReserva in agencia.Tb_reserva
        //        where objReserva.estado == estado
        //        select objReserva).Count()
        //        );

        //        return cantReservas;
        //    }
        //    catch (EntityException ex)
        //    {
        //        throw new Exception(ex.Message);
        //    }


        //}


        //public Int16 GetContarReservarForAerolinea(String nombre)
        //{
        //    Agencia_BDEntities agencia = new Agencia_BDEntities();

        //    try
        //    {

        //        Int16 cantReservas = Convert.ToInt16
        //            (
        //                (
        //                from Res in agencia.Tb_Reserva
        //                join Ast in agencia.Tb_Asiento on Res.id_asiento equals Ast.id
        //                join Vue in agencia.Tb_Vuelo on Ast.id_vuelo equals Vue.id
        //                join Avi in agencia.Tb_Avion on Vue.id_avion equals Avi.id
        //                join Aer in agencia.Tb_Aerolinea on Avi.id_aerolinea equals Aer.id
        //                where Aer.nombre == nombre
        //                select Res).Count()
        //            );

        //        return cantReservas;
        //    }
        //    catch (EntityException ex)
        //    {
        //        throw new Exception(ex.Message);
        //    }


        //}


    }

}
