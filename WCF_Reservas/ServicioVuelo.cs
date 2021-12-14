using System;
using System.Collections.Generic;
using System.Data.Entity.Core;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF_Reservas
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ServicioVuelo" en el código y en el archivo de configuración a la vez.
    public class ServicioVuelo : IServicioVuelo
    {
        public List<VueloBE> GetAllVuelos()
        {
            Agencia_BDEntities vuelo = new Agencia_BDEntities();

            List<VueloBE> objListaVuelo = new List<VueloBE>();

            try
            {
                var query = vuelo.usp_ListarVuelos();

                //Recorremos el resultado
                foreach (var resultado in query)
                {
                    VueloBE objVueloBE = new VueloBE();

                    objVueloBE.Nombre_Aerolinea = resultado.Aerolinea;
                    objVueloBE.NombreAeropuertoOrigen = resultado.Aeropuerto_Origen;                    
                    objVueloBE.Nombre_PaisOrigen = resultado.Pais_Origen;
                    objVueloBE.Nombre_Departamento = resultado.Ciudad_Origen;
                    objVueloBE.Foto = resultado.Imagen_Destino;
                    objVueloBE.Fila = resultado.Fila;
                    objVueloBE.Letra = resultado.Letra;
                    objVueloBE.Precio = (double)resultado.Precio;
                    objVueloBE.Tipo_Vuelo = resultado.Tipo;
                    objVueloBE.Fecha_Salida = Convert.ToDateTime(resultado.Fecha_Salida);
                    objVueloBE.NombreAeropuertoDestino = resultado.Aeropuerto_Destino;
                    objVueloBE.Nombre_PaisDestino = resultado.Pais_Destino;
                    objVueloBE.Nombre_departamentoDestino = resultado.Ciudad_Destino;
                    objVueloBE.Fecha_Llegada = Convert.ToDateTime(resultado.Fecha_Llegada);
                    objVueloBE.Estado = (int)resultado.Estado_Reserva;
                    
                    objVueloBE.IdReserva = resultado.IdReserva;
                    objVueloBE.IdDepartamento = resultado.IdDepartamento;
                    objVueloBE.IdAeropuerto = resultado.IdAeropuerto;
                    objVueloBE.IdAsiento = resultado.IdAsiento;
                    objVueloBE.IdAvion = resultado.IdAvion;
                    objVueloBE.IdDestino = resultado.IdDestino;


                    objListaVuelo.Add(objVueloBE);

                }

                return objListaVuelo;
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }

        }

        public List<VueloBE> ListarPorAerolinea(String aerolinea)
        {
            Agencia_BDEntities vuelo = new Agencia_BDEntities();

            List<VueloBE> objListaVuelo = new List<VueloBE>();

            try
            {
                var query = vuelo.usp_ListarVuelosPorAerolinea(aerolinea);

                //Recorremos el resultado
                foreach (var resultado in query)
                {
                    VueloBE objVueloBE = new VueloBE();

                    objVueloBE.Nombre_Aerolinea = resultado.Aerolinea;
                    objVueloBE.NombreAeropuertoOrigen = resultado.Aeropuerto_Origen;
                    objVueloBE.Nombre_PaisOrigen = resultado.Pais_Origen;
                    objVueloBE.Nombre_Departamento = resultado.Ciudad_Origen;
                    objVueloBE.Fecha_Salida = Convert.ToDateTime(resultado.Fecha_Salida);
                    objVueloBE.NombreAeropuertoDestino = resultado.Aeropuerto_Destino;
                    objVueloBE.Nombre_PaisDestino = resultado.Pais_Destino;
                    objVueloBE.Nombre_departamentoDestino = resultado.Ciudad_Destino;
                    objVueloBE.Fecha_Llegada = Convert.ToDateTime(resultado.Fecha_Llegada);

                    objListaVuelo.Add(objVueloBE);

                }

                return objListaVuelo;
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }

        }

        public List<VueloBE> ListarPorCiudadOrigen(String ciudad)
        {
            Agencia_BDEntities vuelo = new Agencia_BDEntities();

            List<VueloBE> objListaVuelo = new List<VueloBE>();

            try
            {
                var query = vuelo.usp_ListarVuelosPorCiudadOrigen(ciudad);

                //Recorremos el resultado
                foreach (var resultado in query)
                {
                    VueloBE objVueloBE = new VueloBE();

                    objVueloBE.Nombre_Aerolinea = resultado.Aerolinea;
                    objVueloBE.NombreAeropuertoOrigen = resultado.Aeropuerto_Origen;
                    objVueloBE.Nombre_PaisOrigen = resultado.Pais_Origen;
                    objVueloBE.Nombre_Departamento = resultado.Ciudad_Origen;
                    objVueloBE.Fecha_Salida = Convert.ToDateTime(resultado.Fecha_Salida);
                    objVueloBE.NombreAeropuertoDestino = resultado.Aeropuerto_Destino;
                    objVueloBE.Nombre_PaisDestino = resultado.Pais_Destino;
                    objVueloBE.Nombre_departamentoDestino = resultado.Ciudad_Destino;
                    objVueloBE.Fecha_Llegada = Convert.ToDateTime(resultado.Fecha_Llegada);

                    objListaVuelo.Add(objVueloBE);

                }

                return objListaVuelo;
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }

        }

        public List<VueloBE> ListarPorCiudadDestino(String ciudad)
        {
            Agencia_BDEntities vuelo = new Agencia_BDEntities();

            List<VueloBE> objListaVuelo = new List<VueloBE>();

            try
            {
                var query = vuelo.usp_ListarVuelosPorCiudadDestino(ciudad);

                //Recorremos el resultado
                foreach (var resultado in query)
                {
                    VueloBE objVueloBE = new VueloBE();

                    objVueloBE.Nombre_Aerolinea = resultado.Aerolinea;
                    objVueloBE.NombreAeropuertoOrigen = resultado.Aeropuerto_Origen;
                    objVueloBE.Nombre_PaisOrigen = resultado.Pais_Origen;
                    objVueloBE.Nombre_Departamento = resultado.Ciudad_Origen;
                    objVueloBE.Fecha_Salida = Convert.ToDateTime(resultado.Fecha_Salida);
                    objVueloBE.NombreAeropuertoDestino = resultado.Aeropuerto_Destino;
                    objVueloBE.Nombre_PaisDestino = resultado.Pais_Destino;
                    objVueloBE.Nombre_departamentoDestino = resultado.Ciudad_Destino;
                    objVueloBE.Fecha_Llegada = Convert.ToDateTime(resultado.Fecha_Llegada);

                    objListaVuelo.Add(objVueloBE);

                }

                return objListaVuelo;
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }

        }

        public List<VueloBE> ListarPorFechaSalida(DateTime fecha1, DateTime fecha2)
        {
            Agencia_BDEntities vuelo = new Agencia_BDEntities();

            List<VueloBE> objListaVuelo = new List<VueloBE>();

            try
            {
                var query = vuelo.usp_ListarVuelosPorFechaSalida(fecha1, fecha2);

                //Recorremos el resultado
                foreach (var resultado in query)
                {
                    VueloBE objVueloBE = new VueloBE();

                    objVueloBE.Nombre_Aerolinea = resultado.Aerolinea;
                    objVueloBE.NombreAeropuertoOrigen = resultado.Aeropuerto_Origen;
                    objVueloBE.Nombre_PaisOrigen = resultado.Pais_Origen;
                    objVueloBE.Nombre_Departamento = resultado.Ciudad_Origen;
                    objVueloBE.Fecha_Salida = Convert.ToDateTime(resultado.Fecha_Salida);
                    objVueloBE.NombreAeropuertoDestino = resultado.Aeropuerto_Destino;
                    objVueloBE.Nombre_PaisDestino = resultado.Pais_Destino;
                    objVueloBE.Nombre_departamentoDestino = resultado.Ciudad_Destino;
                    objVueloBE.Fecha_Llegada = Convert.ToDateTime(resultado.Fecha_Llegada);

                    objListaVuelo.Add(objVueloBE);

                }

                return objListaVuelo;
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }

        }

        public List<VueloBE> ListarPorFechaLlegada(DateTime fecha1, DateTime fecha2)
        {
            Agencia_BDEntities vuelo = new Agencia_BDEntities();

            List<VueloBE> objListaVuelo = new List<VueloBE>();

            try
            {
                var query = vuelo.usp_ListarVuelosPorFechaLlegada(fecha1, fecha2);

                //Recorremos el resultado
                foreach (var resultado in query)
                {
                    VueloBE objVueloBE = new VueloBE();

                    objVueloBE.Nombre_Aerolinea = resultado.Aerolinea;
                    objVueloBE.NombreAeropuertoOrigen = resultado.Aeropuerto_Origen;
                    objVueloBE.Nombre_PaisOrigen = resultado.Pais_Origen;
                    objVueloBE.Nombre_Departamento = resultado.Ciudad_Origen;
                    objVueloBE.Fecha_Salida = Convert.ToDateTime(resultado.Fecha_Salida);
                    objVueloBE.NombreAeropuertoDestino = resultado.Aeropuerto_Destino;
                    objVueloBE.Nombre_PaisDestino = resultado.Pais_Destino;
                    objVueloBE.Nombre_departamentoDestino = resultado.Ciudad_Destino;
                    objVueloBE.Fecha_Llegada = Convert.ToDateTime(resultado.Fecha_Llegada);

                    objListaVuelo.Add(objVueloBE);

                }

                return objListaVuelo;
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

        public List<VueloBE> ListarAerolineas()
        {
            Agencia_BDEntities vuelo = new Agencia_BDEntities();

            List<VueloBE> objListaVuelo = new List<VueloBE>();
            try
            {

                var query = vuelo.Tb_aerolinea.OrderBy(x => x.nombre);

                foreach (var resultado in query)
                {
                    VueloBE objVueloBE = new VueloBE();
                    objVueloBE.IdAerolinea = (Int32)resultado.idAerolinea;
                    objVueloBE.Nombre_Aerolinea = resultado.nombre;
                    objListaVuelo.Add(objVueloBE);
                }
                return objListaVuelo;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }




    }
}
