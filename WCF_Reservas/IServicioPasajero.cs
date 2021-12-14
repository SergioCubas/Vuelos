using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF_Reservas
{
    // NOTA: puede usar el comando "Cambiar nombre" del menú "Refactorizar" para cambiar el nombre de interfaz "IServicioPasajero" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IServicioPasajero
    {

        //[OperationContract]
        //List<PasajeroBE> GetAllPasajeroForDni(String dni);

        [OperationContract]
        List<PasajeroBE> GetPasajeroDetallePagoPorDni(String dni);

        //[OperationContract]
        //List<PasajeroBE> GetPasajeroAerolinea(String ruc);
        [OperationContract]
        List<PasajeroBE> ListarPasajerosPorDepartamento(String departamento);
        
        [OperationContract]
        List<PasajeroBE> ListarPasajerosPorGenero(String genero);

        [OperationContract]
        List<PasajeroBE> ListarPasajerosPorPais(String pais);

        [OperationContract]
        List<PasajeroBE> ListarPasajeros();

        [OperationContract]
        List<PasajeroBE> ListarPaises();

        [OperationContract]
        List<PasajeroBE> ListarDepartamentos();

        [OperationContract]
        Int16 GetContarPasajerosPorPais(String pais);

    }

    //Agregamos la DataContractual
    [DataContract]
    [Serializable]
    public class PasajeroBE
    {
        private String nombreCompleto;
        private String num_documento;
        private String pais;
        private String aerolinea;
        private String ruc;

        private String tipo_vuelo;
        private String tipo_comprobante;
        private String medio_pago;


        private DateTime fechaPago;
        private DateTime fechanac;
        private string num_comprobante;
        private string precio;
        private string telefono;
        private string email;
        private string genero;
        private string departamento;
        private Int32 idDepart;
        private string nomDep;
        private Int32 idPais;
        private string nomPais;

        [DataMember]
        public Int32 IdPais
        {
            get { return idPais; }
            set { idPais = value; }
        }

        [DataMember]
        public String NomPais
        {
            get { return nomPais; }
            set { nomPais = value; }
        }

        [DataMember]
        public Int32 IdDepart
        {
            get { return idDepart; }
            set { idDepart = value; }
        }

        [DataMember]
        public String NomDep
        {
            get { return nomDep; }
            set { nomDep = value; }
        }

        [DataMember]
        public String Departamento
        {
            get { return departamento; }
            set { departamento = value; }
        }

        [DataMember]
        public String Genero
        {
            get { return genero; }
            set { genero = value; }
        }

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
        public String Precio
        {
            get { return precio; }
            set { precio = value; }
        }

        [DataMember]
        public String MedioPago
        {
            get { return medio_pago; }
            set { medio_pago = value; }
        }


        [DataMember]
        public String TipoComprobante
        {
            get { return tipo_comprobante; }
            set { tipo_comprobante = value; }
        }


        [DataMember]
        public String TipoVuelo
        {
            get { return tipo_vuelo; }
            set { tipo_vuelo = value; }
        }

        [DataMember]
        public String NombreCompleto
        {
            get { return nombreCompleto; }
            set { nombreCompleto = value; }
        }

        [DataMember]
        public String NumeroDocumento
        {
            get { return num_documento; }
            set { num_documento = value; }
        }

        [DataMember]
        public String Pais
        {
            get { return pais; }
            set { pais = value; }
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
        public DateTime FechaPago
        {
            get { return fechaPago; }
            set { fechaPago = value; }
        }

        [DataMember]
        public DateTime FechaNac
        {
            get { return fechanac; }
            set { fechanac = value; }
        }

        [DataMember]
        public string NumeroComprobante
        {
            get { return num_comprobante; }
            set { num_comprobante = value; }
        }

        
    }
}
