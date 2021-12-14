using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF_Reservas
{
    // NOTA: puede usar el comando "Cambiar nombre" del menú "Refactorizar" para cambiar el nombre de interfaz "IServicioVuelo" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IServicioVuelo
    {
        [OperationContract]
        List<VueloBE> GetAllVuelos();

        [OperationContract]
        List<VueloBE> ListarPorAerolinea(String aerolinea);

        [OperationContract]
        List<VueloBE> ListarPorCiudadOrigen(String ciudad);

        [OperationContract]
        List<VueloBE> ListarPorCiudadDestino(String ciudad);

        [OperationContract]
        List<VueloBE> ListarPorFechaSalida(DateTime fecha1, DateTime fecha2);

        [OperationContract]
        List<VueloBE> ListarPorFechaLlegada(DateTime fecha1, DateTime fecha2);

        [OperationContract]
        List<VueloBE> ListarDepartamentos();

        [OperationContract]
        List<VueloBE> ListarAerolineas();

    }


    //Agregamos la DataContractual
    [DataContract]
    [Serializable]
    public class VueloBE
    {
        private String nombre_aeropuertoOrigen;
        private String nombre_aerolinea;
        private String nombre_paisorigen;
        private String nombre_departamento;
        private String foto;
        private String letra;
        private String fila;
        private String tipo_vuelo;
        private Double precio;
        private String nombre_aeropuertodestino;
        private String nombre_paisdestino;
        private String nombre_departamentoDestino;
        private DateTime fecha_salida;
        private DateTime fecha_llegada;
        private Int32 idPais;
        private Int32 idDepart;


        private Int32 idAerolinea;
        private Int32 idReserva;
        private Int32 idDepartamento;
        private Int32 idAeropuerto;
        private Int32 idAsiento;
        private Int32 idAvion;
        private Int32 idDestino;



        [DataMember]
        public Int32 IdDestino
        {
            get { return idDestino; }
            set { idDestino = value; }
        }

        [DataMember]
        public Int32 IdAvion
        {
            get { return idAvion; }
            set { idAvion = value; }
        }

        [DataMember]
        public Int32 IdAsiento
        {
            get { return idAsiento; }
            set { idAsiento = value; }
        }

        [DataMember]
        public Int32 IdAeropuerto
        {
            get { return idAeropuerto; }
            set { idDepartamento = value; }
        }

        [DataMember]
        public Int32 IdDepartamento
        {
            get { return idDepartamento; }
            set { idAeropuerto = value; }
        }

        [DataMember]
        public Int32 IdReserva
        {
            get { return idReserva; }
            set { idReserva = value; }
        }

        [DataMember]
        public String Fila
        {
            get { return fila; }
            set { fila = value; }
        }

        [DataMember]
        public String Letra
        {
            get { return letra; }
            set { letra = value; }
        }

        [DataMember]
        public Int32 IdAerolinea
        {
            get { return idAerolinea; }
            set { idAerolinea = value; }
        }

        [DataMember]
        public Int32 IdDepart
        {
            get { return idDepart; }
            set { idDepart = value; }
        }

        [DataMember]
        public Int32 IdPais
        {
            get { return idPais; }
            set { idPais = value; }
        }

        [DataMember]
        public String NombreAeropuertoOrigen
        {
            get { return nombre_aeropuertoOrigen; }
            set { nombre_aeropuertoOrigen = value; }
        }

        [DataMember]
        public DateTime Fecha_Salida
        {
            get { return fecha_salida; }
            set { fecha_salida = value; }
        }

        [DataMember]
        public DateTime Fecha_Llegada
        {
            get { return fecha_llegada; }
            set { fecha_llegada = value; }
        }

        [DataMember]
        public String Nombre_departamentoDestino
        {
            get { return nombre_departamentoDestino; }
            set { nombre_departamentoDestino = value; }
        }



        [DataMember]
        public String Nombre_Aerolinea
        {
            get { return nombre_aerolinea; }
            set { nombre_aerolinea = value; }
        }


        [DataMember]
        public String Nombre_PaisOrigen
        {
            get { return nombre_paisorigen; }
            set { nombre_paisorigen = value; }
        }


        [DataMember]
        public String Nombre_Departamento
        {
            get { return nombre_departamento; }
            set { nombre_departamento = value; }
        }



        [DataMember]
        public String Foto
        {
            get { return foto; }
            set { foto = value; }
        }


        [DataMember]
        public String Tipo_Vuelo
        {
            get { return tipo_vuelo; }
            set { tipo_vuelo = value; }
        }


        [DataMember]
        public Double Precio
        {
            get { return precio; }
            set { precio = value; }
        }

        [DataMember]
        public String NombreAeropuertoDestino
        {
            get { return nombre_aeropuertodestino; }
            set { nombre_aeropuertodestino = value; }
        }

        [DataMember]
        public String Nombre_PaisDestino
        {
            get { return nombre_paisdestino; }
            set { nombre_paisdestino = value; }
        }

    }


}
