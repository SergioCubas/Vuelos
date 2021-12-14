using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF_Reservas
{
    // NOTA: puede usar el comando "Cambiar nombre" del menú "Refactorizar" para cambiar el nombre de interfaz "IServicioAerolinea" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IServicioAerolinea
    {
        [OperationContract]
        List<AerolineaBE> GetAllAerolineaPais(String departamento);

        [OperationContract]
        List<AerolineaBE> ListarAerolinea();

        //[OperationContract]
        //List<AerolineaBE> GetAllAerolineaAeropuerto(String ruc);

        [OperationContract]
        Int16 GetContarAerolinea();

        [OperationContract]
        List<AerolineaBE> GetAllPrecioAerolineaAsiento(String ruc);
    }

    //Agregamos la DataContractual
    [DataContract]
    [Serializable]
    public class AerolineaBE
    {
        private String aerolinea;
        private String ruc;
        private String pais;
        private String ciudad;

        private String aeropuerto;
        private String fila;
        private String letra;
        private String precio;

        private String departamento;
        private String tipo;


        [DataMember]
        public String Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }


        [DataMember]
        public String Departamento
        {
            get { return departamento; }
            set { departamento = value; }
        }


        [DataMember]
        public String Aerolinea
        {
            get { return aerolinea; }
            set { aerolinea = value; }
        }

        [DataMember]
        public String Ruc
        {
            get { return ruc; }
            set { ruc = value; }
        }

        [DataMember]
        public String Pais
        {
            get { return pais; }
            set { pais = value; }
        }

        [DataMember]
        public String Ciudad
        {
            get { return ciudad; }
            set { ciudad = value; }
        }

        [DataMember]
        public String Aeropuerto
        {
            get { return aeropuerto; }
            set { aeropuerto = value; }
        }

        [DataMember]
        public String Letra
        {
            get { return letra; }
            set { letra = value; }
        }

        [DataMember]
        public String Fila
        {
            get { return fila; }
            set { fila = value; }
        }

        [DataMember]
        public String Precio
        {
            get { return precio; }
            set { precio = value; }
        }

    }


}
