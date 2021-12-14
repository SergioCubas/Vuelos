﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Proyecto_MVC.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class Agencia_BDEntities : DbContext
    {
        public Agencia_BDEntities()
            : base("name=Agencia_BDEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Tb_aerolinea> Tb_aerolinea { get; set; }
        public virtual DbSet<Tb_aeropuerto> Tb_aeropuerto { get; set; }
        public virtual DbSet<Tb_asiento> Tb_asiento { get; set; }
        public virtual DbSet<Tb_avion> Tb_avion { get; set; }
        public virtual DbSet<Tb_departamento> Tb_departamento { get; set; }
        public virtual DbSet<Tb_Destino> Tb_Destino { get; set; }
        public virtual DbSet<Tb_pago> Tb_pago { get; set; }
        public virtual DbSet<Tb_pais> Tb_pais { get; set; }
        public virtual DbSet<Tb_pasajero> Tb_pasajero { get; set; }
        public virtual DbSet<Tb_reserva> Tb_reserva { get; set; }
        public virtual DbSet<Tb_rol> Tb_rol { get; set; }
        public virtual DbSet<Tb_vuelo> Tb_vuelo { get; set; }
    
        public virtual int sp_alterdiagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_alterdiagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_creatediagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_creatediagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_dropdiagram(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_dropdiagram", diagramnameParameter, owner_idParameter);
        }
    
        public virtual int sp_helpdiagramdefinition(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_helpdiagramdefinition", diagramnameParameter, owner_idParameter);
        }
    
        public virtual int sp_helpdiagrams(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_helpdiagrams", diagramnameParameter, owner_idParameter);
        }
    
        public virtual int sp_renamediagram(string diagramname, Nullable<int> owner_id, string new_diagramname)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var new_diagramnameParameter = new_diagramname != null ?
                new ObjectParameter("new_diagramname", new_diagramname) :
                new ObjectParameter("new_diagramname", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_renamediagram", diagramnameParameter, owner_idParameter, new_diagramnameParameter);
        }
    
        public virtual int sp_upgraddiagrams()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_upgraddiagrams");
        }
    
        public virtual ObjectResult<usp_ListaPasajeroPorPais_Result> usp_ListaPasajeroPorPais(string pais)
        {
            var paisParameter = pais != null ?
                new ObjectParameter("pais", pais) :
                new ObjectParameter("pais", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<usp_ListaPasajeroPorPais_Result>("usp_ListaPasajeroPorPais", paisParameter);
        }
    
        public virtual ObjectResult<usp_ListarAerolineaPaisPorDepartamento_Result> usp_ListarAerolineaPaisPorDepartamento(string departamento)
        {
            var departamentoParameter = departamento != null ?
                new ObjectParameter("departamento", departamento) :
                new ObjectParameter("departamento", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<usp_ListarAerolineaPaisPorDepartamento_Result>("usp_ListarAerolineaPaisPorDepartamento", departamentoParameter);
        }
    
        public virtual ObjectResult<usp_ListarAerolineaReservaPaisPorFecha_Result> usp_ListarAerolineaReservaPaisPorFecha(string finicio, string ffin)
        {
            var finicioParameter = finicio != null ?
                new ObjectParameter("finicio", finicio) :
                new ObjectParameter("finicio", typeof(string));
    
            var ffinParameter = ffin != null ?
                new ObjectParameter("ffin", ffin) :
                new ObjectParameter("ffin", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<usp_ListarAerolineaReservaPaisPorFecha_Result>("usp_ListarAerolineaReservaPaisPorFecha", finicioParameter, ffinParameter);
        }
    
        public virtual ObjectResult<usp_ListarAsientosDisponiblesPorRucAerolinea_Result> usp_ListarAsientosDisponiblesPorRucAerolinea(string ruc)
        {
            var rucParameter = ruc != null ?
                new ObjectParameter("ruc", ruc) :
                new ObjectParameter("ruc", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<usp_ListarAsientosDisponiblesPorRucAerolinea_Result>("usp_ListarAsientosDisponiblesPorRucAerolinea", rucParameter);
        }
    
        public virtual ObjectResult<usp_ListarPasajeroDetallePagoPorDocumento_Result> usp_ListarPasajeroDetallePagoPorDocumento(string documento)
        {
            var documentoParameter = documento != null ?
                new ObjectParameter("documento", documento) :
                new ObjectParameter("documento", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<usp_ListarPasajeroDetallePagoPorDocumento_Result>("usp_ListarPasajeroDetallePagoPorDocumento", documentoParameter);
        }
    
        public virtual ObjectResult<usp_ListarPasajeros_Result> usp_ListarPasajeros()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<usp_ListarPasajeros_Result>("usp_ListarPasajeros");
        }
    
        public virtual ObjectResult<usp_ListarPasajerosPorDepartamento_Result> usp_ListarPasajerosPorDepartamento(string departamento)
        {
            var departamentoParameter = departamento != null ?
                new ObjectParameter("departamento", departamento) :
                new ObjectParameter("departamento", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<usp_ListarPasajerosPorDepartamento_Result>("usp_ListarPasajerosPorDepartamento", departamentoParameter);
        }
    
        public virtual ObjectResult<usp_ListarPasajerosPorFechaReserva_Result> usp_ListarPasajerosPorFechaReserva(string finicio, string ffin)
        {
            var finicioParameter = finicio != null ?
                new ObjectParameter("finicio", finicio) :
                new ObjectParameter("finicio", typeof(string));
    
            var ffinParameter = ffin != null ?
                new ObjectParameter("ffin", ffin) :
                new ObjectParameter("ffin", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<usp_ListarPasajerosPorFechaReserva_Result>("usp_ListarPasajerosPorFechaReserva", finicioParameter, ffinParameter);
        }
    
        public virtual ObjectResult<usp_ListarPasajerosPorGenero_Result> usp_ListarPasajerosPorGenero(string genero)
        {
            var generoParameter = genero != null ?
                new ObjectParameter("genero", genero) :
                new ObjectParameter("genero", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<usp_ListarPasajerosPorGenero_Result>("usp_ListarPasajerosPorGenero", generoParameter);
        }
    
        public virtual ObjectResult<usp_ListarPasajerosPorGeneroO_Result> usp_ListarPasajerosPorGeneroO(string genero)
        {
            var generoParameter = genero != null ?
                new ObjectParameter("genero", genero) :
                new ObjectParameter("genero", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<usp_ListarPasajerosPorGeneroO_Result>("usp_ListarPasajerosPorGeneroO", generoParameter);
        }
    
        public virtual ObjectResult<usp_ListarPasajerosPorPais_Result> usp_ListarPasajerosPorPais(string pais)
        {
            var paisParameter = pais != null ?
                new ObjectParameter("Pais", pais) :
                new ObjectParameter("Pais", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<usp_ListarPasajerosPorPais_Result>("usp_ListarPasajerosPorPais", paisParameter);
        }
    
        public virtual ObjectResult<usp_ListarReservas_Result> usp_ListarReservas()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<usp_ListarReservas_Result>("usp_ListarReservas");
        }
    
        public virtual ObjectResult<usp_ListarReservasPorAerolinea_Result> usp_ListarReservasPorAerolinea(string aerolinea)
        {
            var aerolineaParameter = aerolinea != null ?
                new ObjectParameter("aerolinea", aerolinea) :
                new ObjectParameter("aerolinea", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<usp_ListarReservasPorAerolinea_Result>("usp_ListarReservasPorAerolinea", aerolineaParameter);
        }
    
        public virtual ObjectResult<usp_ListarReservasPorCiudadDestino_Result> usp_ListarReservasPorCiudadDestino(string ciudad)
        {
            var ciudadParameter = ciudad != null ?
                new ObjectParameter("ciudad", ciudad) :
                new ObjectParameter("ciudad", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<usp_ListarReservasPorCiudadDestino_Result>("usp_ListarReservasPorCiudadDestino", ciudadParameter);
        }
    
        public virtual ObjectResult<usp_ListarReservasPorCiudadOrigen_Result> usp_ListarReservasPorCiudadOrigen(string ciudad)
        {
            var ciudadParameter = ciudad != null ?
                new ObjectParameter("ciudad", ciudad) :
                new ObjectParameter("ciudad", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<usp_ListarReservasPorCiudadOrigen_Result>("usp_ListarReservasPorCiudadOrigen", ciudadParameter);
        }
    
        public virtual ObjectResult<usp_ListarReservasPorCodigo_Result> usp_ListarReservasPorCodigo(Nullable<int> codigo)
        {
            var codigoParameter = codigo.HasValue ?
                new ObjectParameter("codigo", codigo) :
                new ObjectParameter("codigo", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<usp_ListarReservasPorCodigo_Result>("usp_ListarReservasPorCodigo", codigoParameter);
        }
    
        public virtual ObjectResult<usp_ListarReservasPorDni_Result> usp_ListarReservasPorDni(string dni)
        {
            var dniParameter = dni != null ?
                new ObjectParameter("dni", dni) :
                new ObjectParameter("dni", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<usp_ListarReservasPorDni_Result>("usp_ListarReservasPorDni", dniParameter);
        }
    
        public virtual ObjectResult<usp_ListarReservasPorPorFechaLlegada_Result> usp_ListarReservasPorPorFechaLlegada(Nullable<System.DateTime> fecha1, Nullable<System.DateTime> fecha2)
        {
            var fecha1Parameter = fecha1.HasValue ?
                new ObjectParameter("Fecha1", fecha1) :
                new ObjectParameter("Fecha1", typeof(System.DateTime));
    
            var fecha2Parameter = fecha2.HasValue ?
                new ObjectParameter("Fecha2", fecha2) :
                new ObjectParameter("Fecha2", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<usp_ListarReservasPorPorFechaLlegada_Result>("usp_ListarReservasPorPorFechaLlegada", fecha1Parameter, fecha2Parameter);
        }
    
        public virtual ObjectResult<usp_ListarReservasPorPorFechaSalida_Result> usp_ListarReservasPorPorFechaSalida(Nullable<System.DateTime> fecha1, Nullable<System.DateTime> fecha2)
        {
            var fecha1Parameter = fecha1.HasValue ?
                new ObjectParameter("Fecha1", fecha1) :
                new ObjectParameter("Fecha1", typeof(System.DateTime));
    
            var fecha2Parameter = fecha2.HasValue ?
                new ObjectParameter("Fecha2", fecha2) :
                new ObjectParameter("Fecha2", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<usp_ListarReservasPorPorFechaSalida_Result>("usp_ListarReservasPorPorFechaSalida", fecha1Parameter, fecha2Parameter);
        }
    
        public virtual ObjectResult<usp_ListarVuelos_Result> usp_ListarVuelos()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<usp_ListarVuelos_Result>("usp_ListarVuelos");
        }
    
        public virtual ObjectResult<usp_ListarVuelosDeAerolineasPorFechaRegistro_Result> usp_ListarVuelosDeAerolineasPorFechaRegistro(string finicio, string ffin)
        {
            var finicioParameter = finicio != null ?
                new ObjectParameter("finicio", finicio) :
                new ObjectParameter("finicio", typeof(string));
    
            var ffinParameter = ffin != null ?
                new ObjectParameter("ffin", ffin) :
                new ObjectParameter("ffin", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<usp_ListarVuelosDeAerolineasPorFechaRegistro_Result>("usp_ListarVuelosDeAerolineasPorFechaRegistro", finicioParameter, ffinParameter);
        }
    
        public virtual ObjectResult<usp_ListarVuelosPorAerolinea_Result> usp_ListarVuelosPorAerolinea(string aerolinea)
        {
            var aerolineaParameter = aerolinea != null ?
                new ObjectParameter("Aerolinea", aerolinea) :
                new ObjectParameter("Aerolinea", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<usp_ListarVuelosPorAerolinea_Result>("usp_ListarVuelosPorAerolinea", aerolineaParameter);
        }
    
        public virtual ObjectResult<usp_ListarVuelosPorCiudadDestino_Result> usp_ListarVuelosPorCiudadDestino(string ciudad)
        {
            var ciudadParameter = ciudad != null ?
                new ObjectParameter("Ciudad", ciudad) :
                new ObjectParameter("Ciudad", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<usp_ListarVuelosPorCiudadDestino_Result>("usp_ListarVuelosPorCiudadDestino", ciudadParameter);
        }
    
        public virtual ObjectResult<usp_ListarVuelosPorCiudadOrigen_Result> usp_ListarVuelosPorCiudadOrigen(string ciudad)
        {
            var ciudadParameter = ciudad != null ?
                new ObjectParameter("Ciudad", ciudad) :
                new ObjectParameter("Ciudad", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<usp_ListarVuelosPorCiudadOrigen_Result>("usp_ListarVuelosPorCiudadOrigen", ciudadParameter);
        }
    
        public virtual ObjectResult<usp_ListarVuelosPorFechaLlegada_Result> usp_ListarVuelosPorFechaLlegada(Nullable<System.DateTime> fecha1, Nullable<System.DateTime> fecha2)
        {
            var fecha1Parameter = fecha1.HasValue ?
                new ObjectParameter("Fecha1", fecha1) :
                new ObjectParameter("Fecha1", typeof(System.DateTime));
    
            var fecha2Parameter = fecha2.HasValue ?
                new ObjectParameter("Fecha2", fecha2) :
                new ObjectParameter("Fecha2", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<usp_ListarVuelosPorFechaLlegada_Result>("usp_ListarVuelosPorFechaLlegada", fecha1Parameter, fecha2Parameter);
        }
    
        public virtual ObjectResult<usp_ListarVuelosPorFechaSalida_Result> usp_ListarVuelosPorFechaSalida(Nullable<System.DateTime> fecha1, Nullable<System.DateTime> fecha2)
        {
            var fecha1Parameter = fecha1.HasValue ?
                new ObjectParameter("Fecha1", fecha1) :
                new ObjectParameter("Fecha1", typeof(System.DateTime));
    
            var fecha2Parameter = fecha2.HasValue ?
                new ObjectParameter("Fecha2", fecha2) :
                new ObjectParameter("Fecha2", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<usp_ListarVuelosPorFechaSalida_Result>("usp_ListarVuelosPorFechaSalida", fecha1Parameter, fecha2Parameter);
        }
    
        public virtual ObjectResult<usp_Login_Result> usp_Login(string email, string dni)
        {
            var emailParameter = email != null ?
                new ObjectParameter("email", email) :
                new ObjectParameter("email", typeof(string));
    
            var dniParameter = dni != null ?
                new ObjectParameter("dni", dni) :
                new ObjectParameter("dni", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<usp_Login_Result>("usp_Login", emailParameter, dniParameter);
        }
    }
}