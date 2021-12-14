using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF_Reservas
{
    // NOTA: puede usar el comando "Cambiar nombre" del menú "Refactorizar" para cambiar el nombre de interfaz "IServicioReserva" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IServicioReserva
    {
        [OperationContract]
        List<ReservaBE> ListarReservasPorCiudadOrigen(String ciudad);

        [OperationContract]
        List<ReservaBE> ListarReservasPorCiudadDestino(String ciudad);

        [OperationContract]
        List<ReservaBE> ListarReservas();

        [OperationContract]
        List<ReservaBE> ListarReservasPorFechaSalida(DateTime fecha1, DateTime fecha2);

        [OperationContract]
        List<ReservaBE> ListarReservasPorFechaLlegada(DateTime fecha1, DateTime fecha2);

        [OperationContract]
        List<ReservaBE> ListarReservasPorDni(String dni);

        [OperationContract]
        List<VueloBE> ListarDepartamentos();
        //[OperationContract]
        //List<ReservaBE> GetAllReservaPaisFechas(String fecini, String fecfin);

        //[OperationContract]
        //List<ReservaBE> GetAllAsientosDisponiblesDeAerolineaParaReserva(String nombre);

        //[OperationContract]
        //Int16 GetContarReservar(Int16 estado);

        //[OperationContract]
        //Int16 GetContarReservarForAerolinea(String nombre);
    }

    //Agregamos la DataContractual
    [DataContract]
    [Serializable]
    public class ReservaBE
    {
        private String nombre_aeropuertoOrigen;
        private String nombre_aerolinea;
        private String nombre_paisorigen;
        private String nombre_ciudadOrigen;
        private String foto;
        private String tipo_asiento;
        private Double precio;
        private String nombre_aeropuertodestino;
        private String nombre_paisdestino;
        private String nombre_ciudadDestino;
        private DateTime fecha_salida;
        private DateTime fecha_llegada;
        private Int32 idPais;
        private Int32 idDepart;
        private Int32 idAerolinea;
        private String nombre;
        private String numDocumento;
        private String asiento;
        private String email;
        private String telefono;
        private String genero;


        [DataMember]
        public String Email
        {
            get { return email; }
            set { email = value; }
        }

        [DataMember]
        public String Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }

        [DataMember]
        public String Genero
        {
            get { return genero; }
            set { genero = value; }
        }


        [DataMember]
        public String Asiento
        {
            get { return asiento; }
            set { asiento = value; }
        }

        [DataMember]
        public String NumDocumento
        {
            get { return numDocumento; }
            set { numDocumento = value; }
        }


        [DataMember]
        public String Nombre
        {
            get { return nombre; }
            set { nombre = value; }
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
        public String Nombre_ciudadDestino
        {
            get { return nombre_ciudadDestino; }
            set { nombre_ciudadDestino = value; }
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
        public String Nombre_ciudadOrigen
        {
            get { return nombre_ciudadOrigen; }
            set { nombre_ciudadOrigen = value; }
        }



        [DataMember]
        public String Foto
        {
            get { return foto; }
            set { foto = value; }
        }


        [DataMember]
        public String Tipo_asiento
        {
            get { return tipo_asiento; }
            set { tipo_asiento = value; }
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
