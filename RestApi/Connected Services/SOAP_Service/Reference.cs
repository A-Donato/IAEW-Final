//------------------------------------------------------------------------------
// <generado automáticamente>
//     Este código fue generado por una herramienta.
//     //
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </generado automáticamente>
//------------------------------------------------------------------------------

namespace SOAP_Service
{
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Credentials", Namespace="http://schemas.datacontract.org/2004/07/ServicioWeb")]
    public partial class Credentials : object
    {
        
        private string UserNameField;
        
        private string PasswordField;
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public string UserName
        {
            get
            {
                return this.UserNameField;
            }
            set
            {
                this.UserNameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=1)]
        public string Password
        {
            get
            {
                return this.PasswordField;
            }
            set
            {
                this.PasswordField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ConsultarVehiculosRequest", Namespace="http://schemas.datacontract.org/2004/07/WCFReservaVehiculos.Business.Entities")]
    public partial class ConsultarVehiculosRequest : object
    {
        
        private int IdCiudadField;
        
        private System.DateTime FechaHoraRetiroField;
        
        private System.DateTime FechaHoraDevolucionField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int IdCiudad
        {
            get
            {
                return this.IdCiudadField;
            }
            set
            {
                this.IdCiudadField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=1)]
        public System.DateTime FechaHoraRetiro
        {
            get
            {
                return this.FechaHoraRetiroField;
            }
            set
            {
                this.FechaHoraRetiroField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=2)]
        public System.DateTime FechaHoraDevolucion
        {
            get
            {
                return this.FechaHoraDevolucionField;
            }
            set
            {
                this.FechaHoraDevolucionField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ConsultarVehiculosDisponiblesResponse", Namespace="http://schemas.datacontract.org/2004/07/WCFReservaVehiculos.Business.Entities")]
    public partial class ConsultarVehiculosDisponiblesResponse : object
    {
        
        private System.DateTime TimeStampField;
        
        private SOAP_Service.VehiculoModel[] VehiculosEncontradosField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime TimeStamp
        {
            get
            {
                return this.TimeStampField;
            }
            set
            {
                this.TimeStampField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public SOAP_Service.VehiculoModel[] VehiculosEncontrados
        {
            get
            {
                return this.VehiculosEncontradosField;
            }
            set
            {
                this.VehiculosEncontradosField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="VehiculoModel", Namespace="http://schemas.datacontract.org/2004/07/WCFReservaVehiculos.Business.Entities")]
    public partial class VehiculoModel : object
    {
        
        private int CantidadDisponibleField;
        
        private int CantidadPuertasField;
        
        private int CiudadIdField;
        
        private int IdField;
        
        private string MarcaField;
        
        private string ModeloField;
        
        private decimal PrecioPorDiaField;
        
        private string PuntajeField;
        
        private bool TieneAireAconField;
        
        private bool TieneDireccionField;
        
        private string TipoCambioField;
        
        private int VehiculoCiudadIdField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int CantidadDisponible
        {
            get
            {
                return this.CantidadDisponibleField;
            }
            set
            {
                this.CantidadDisponibleField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int CantidadPuertas
        {
            get
            {
                return this.CantidadPuertasField;
            }
            set
            {
                this.CantidadPuertasField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int CiudadId
        {
            get
            {
                return this.CiudadIdField;
            }
            set
            {
                this.CiudadIdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id
        {
            get
            {
                return this.IdField;
            }
            set
            {
                this.IdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Marca
        {
            get
            {
                return this.MarcaField;
            }
            set
            {
                this.MarcaField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Modelo
        {
            get
            {
                return this.ModeloField;
            }
            set
            {
                this.ModeloField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal PrecioPorDia
        {
            get
            {
                return this.PrecioPorDiaField;
            }
            set
            {
                this.PrecioPorDiaField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Puntaje
        {
            get
            {
                return this.PuntajeField;
            }
            set
            {
                this.PuntajeField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool TieneAireAcon
        {
            get
            {
                return this.TieneAireAconField;
            }
            set
            {
                this.TieneAireAconField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool TieneDireccion
        {
            get
            {
                return this.TieneDireccionField;
            }
            set
            {
                this.TieneDireccionField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string TipoCambio
        {
            get
            {
                return this.TipoCambioField;
            }
            set
            {
                this.TipoCambioField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int VehiculoCiudadId
        {
            get
            {
                return this.VehiculoCiudadIdField;
            }
            set
            {
                this.VehiculoCiudadIdField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="StatusResponse", Namespace="http://schemas.datacontract.org/2004/07/WCFReservaVehiculos.Business.ExceptionHan" +
        "dling")]
    public partial class StatusResponse : object
    {
        
        private int ErrorCodeField;
        
        private string ErrorDescriptionField;
        
        private string InnerExceptionDescriptionField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ErrorCode
        {
            get
            {
                return this.ErrorCodeField;
            }
            set
            {
                this.ErrorCodeField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ErrorDescription
        {
            get
            {
                return this.ErrorDescriptionField;
            }
            set
            {
                this.ErrorDescriptionField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string InnerExceptionDescription
        {
            get
            {
                return this.InnerExceptionDescriptionField;
            }
            set
            {
                this.InnerExceptionDescriptionField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ReservarVehiculoRequest", Namespace="http://schemas.datacontract.org/2004/07/WCFReservaVehiculos.Business.Entities")]
    public partial class ReservarVehiculoRequest : object
    {
        
        private string ApellidoNombreClienteField;
        
        private System.DateTime FechaHoraDevolucionField;
        
        private System.DateTime FechaHoraRetiroField;
        
        private int IdVehiculoCiudadField;
        
        private SOAP_Service.LugarRetiroDevolucion LugarDevolucionField;
        
        private SOAP_Service.LugarRetiroDevolucion LugarRetiroField;
        
        private string NroDocumentoClienteField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ApellidoNombreCliente
        {
            get
            {
                return this.ApellidoNombreClienteField;
            }
            set
            {
                this.ApellidoNombreClienteField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime FechaHoraDevolucion
        {
            get
            {
                return this.FechaHoraDevolucionField;
            }
            set
            {
                this.FechaHoraDevolucionField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime FechaHoraRetiro
        {
            get
            {
                return this.FechaHoraRetiroField;
            }
            set
            {
                this.FechaHoraRetiroField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int IdVehiculoCiudad
        {
            get
            {
                return this.IdVehiculoCiudadField;
            }
            set
            {
                this.IdVehiculoCiudadField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public SOAP_Service.LugarRetiroDevolucion LugarDevolucion
        {
            get
            {
                return this.LugarDevolucionField;
            }
            set
            {
                this.LugarDevolucionField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public SOAP_Service.LugarRetiroDevolucion LugarRetiro
        {
            get
            {
                return this.LugarRetiroField;
            }
            set
            {
                this.LugarRetiroField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string NroDocumentoCliente
        {
            get
            {
                return this.NroDocumentoClienteField;
            }
            set
            {
                this.NroDocumentoClienteField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="LugarRetiroDevolucion", Namespace="http://schemas.datacontract.org/2004/07/WCFReservaVehiculos.Business.Entities")]
    public enum LugarRetiroDevolucion : int
    {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Aeropuerto = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        TerminalBuses = 1,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Hotel = 2,
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ReservarVehiculoResponse", Namespace="http://schemas.datacontract.org/2004/07/WCFReservaVehiculos.Business.Entities")]
    public partial class ReservarVehiculoResponse : object
    {
        
        private SOAP_Service.ReservaEntity ReservaField;
        
        private System.DateTime TimeStampField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public SOAP_Service.ReservaEntity Reserva
        {
            get
            {
                return this.ReservaField;
            }
            set
            {
                this.ReservaField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime TimeStamp
        {
            get
            {
                return this.TimeStampField;
            }
            set
            {
                this.TimeStampField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ReservaEntity", Namespace="http://schemas.datacontract.org/2004/07/WCFReservaVehiculos.Business.DataBaseMode" +
        "l")]
    public partial class ReservaEntity : object
    {
        
        private string ApellidoNombreClienteField;
        
        private string CodigoReservaField;
        
        private SOAP_Service.EstadoReservaEnum EstadoField;
        
        private System.Nullable<System.DateTime> FechaCancelacionField;
        
        private System.DateTime FechaHoraDevolucionField;
        
        private System.DateTime FechaHoraRetiroField;
        
        private System.DateTime FechaReservaField;
        
        private int IdField;
        
        private string LugarDevolucionField;
        
        private string LugarRetiroField;
        
        private string NroDocumentoClienteField;
        
        private decimal TotalReservaField;
        
        private string UsuarioCancelacionField;
        
        private string UsuarioReservaField;
        
        private SOAP_Service.VehiculoPorCiudadEntity VehiculoPorCiudadEntityField;
        
        private int VehiculoPorCiudadIdField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ApellidoNombreCliente
        {
            get
            {
                return this.ApellidoNombreClienteField;
            }
            set
            {
                this.ApellidoNombreClienteField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string CodigoReserva
        {
            get
            {
                return this.CodigoReservaField;
            }
            set
            {
                this.CodigoReservaField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public SOAP_Service.EstadoReservaEnum Estado
        {
            get
            {
                return this.EstadoField;
            }
            set
            {
                this.EstadoField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.DateTime> FechaCancelacion
        {
            get
            {
                return this.FechaCancelacionField;
            }
            set
            {
                this.FechaCancelacionField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime FechaHoraDevolucion
        {
            get
            {
                return this.FechaHoraDevolucionField;
            }
            set
            {
                this.FechaHoraDevolucionField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime FechaHoraRetiro
        {
            get
            {
                return this.FechaHoraRetiroField;
            }
            set
            {
                this.FechaHoraRetiroField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime FechaReserva
        {
            get
            {
                return this.FechaReservaField;
            }
            set
            {
                this.FechaReservaField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id
        {
            get
            {
                return this.IdField;
            }
            set
            {
                this.IdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string LugarDevolucion
        {
            get
            {
                return this.LugarDevolucionField;
            }
            set
            {
                this.LugarDevolucionField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string LugarRetiro
        {
            get
            {
                return this.LugarRetiroField;
            }
            set
            {
                this.LugarRetiroField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string NroDocumentoCliente
        {
            get
            {
                return this.NroDocumentoClienteField;
            }
            set
            {
                this.NroDocumentoClienteField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal TotalReserva
        {
            get
            {
                return this.TotalReservaField;
            }
            set
            {
                this.TotalReservaField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string UsuarioCancelacion
        {
            get
            {
                return this.UsuarioCancelacionField;
            }
            set
            {
                this.UsuarioCancelacionField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string UsuarioReserva
        {
            get
            {
                return this.UsuarioReservaField;
            }
            set
            {
                this.UsuarioReservaField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public SOAP_Service.VehiculoPorCiudadEntity VehiculoPorCiudadEntity
        {
            get
            {
                return this.VehiculoPorCiudadEntityField;
            }
            set
            {
                this.VehiculoPorCiudadEntityField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int VehiculoPorCiudadId
        {
            get
            {
                return this.VehiculoPorCiudadIdField;
            }
            set
            {
                this.VehiculoPorCiudadIdField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="VehiculoPorCiudadEntity", Namespace="http://schemas.datacontract.org/2004/07/WCFReservaVehiculos.Business.DataBaseMode" +
        "l")]
    public partial class VehiculoPorCiudadEntity : object
    {
        
        private int CantidadDisponibleField;
        
        private SOAP_Service.CiudadEntity CiudadEntityField;
        
        private int CiudadIdField;
        
        private int IdField;
        
        private SOAP_Service.VehiculoEntity VehiculoEntityField;
        
        private int VehiculoIdField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int CantidadDisponible
        {
            get
            {
                return this.CantidadDisponibleField;
            }
            set
            {
                this.CantidadDisponibleField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public SOAP_Service.CiudadEntity CiudadEntity
        {
            get
            {
                return this.CiudadEntityField;
            }
            set
            {
                this.CiudadEntityField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int CiudadId
        {
            get
            {
                return this.CiudadIdField;
            }
            set
            {
                this.CiudadIdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id
        {
            get
            {
                return this.IdField;
            }
            set
            {
                this.IdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public SOAP_Service.VehiculoEntity VehiculoEntity
        {
            get
            {
                return this.VehiculoEntityField;
            }
            set
            {
                this.VehiculoEntityField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int VehiculoId
        {
            get
            {
                return this.VehiculoIdField;
            }
            set
            {
                this.VehiculoIdField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="EstadoReservaEnum", Namespace="http://schemas.datacontract.org/2004/07/WCFReservaVehiculos.Business.DataBaseMode" +
        "l")]
    public enum EstadoReservaEnum : int
    {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Activa = 1,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Cancelada = 2,
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CiudadEntity", Namespace="http://schemas.datacontract.org/2004/07/WCFReservaVehiculos.Business.DataBaseMode" +
        "l")]
    public partial class CiudadEntity : object
    {
        
        private int IdField;
        
        private string NombreField;
        
        private SOAP_Service.PaisEntity PaisEntityField;
        
        private int PaisIdField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id
        {
            get
            {
                return this.IdField;
            }
            set
            {
                this.IdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Nombre
        {
            get
            {
                return this.NombreField;
            }
            set
            {
                this.NombreField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public SOAP_Service.PaisEntity PaisEntity
        {
            get
            {
                return this.PaisEntityField;
            }
            set
            {
                this.PaisEntityField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int PaisId
        {
            get
            {
                return this.PaisIdField;
            }
            set
            {
                this.PaisIdField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="VehiculoEntity", Namespace="http://schemas.datacontract.org/2004/07/WCFReservaVehiculos.Business.DataBaseMode" +
        "l")]
    public partial class VehiculoEntity : object
    {
        
        private int CantidadPuertasField;
        
        private int IdField;
        
        private string MarcaField;
        
        private string ModeloField;
        
        private decimal PrecioPorDiaField;
        
        private string PuntajeField;
        
        private bool TieneAireAconField;
        
        private bool TieneDireccionField;
        
        private string TipoCambioField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int CantidadPuertas
        {
            get
            {
                return this.CantidadPuertasField;
            }
            set
            {
                this.CantidadPuertasField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id
        {
            get
            {
                return this.IdField;
            }
            set
            {
                this.IdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Marca
        {
            get
            {
                return this.MarcaField;
            }
            set
            {
                this.MarcaField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Modelo
        {
            get
            {
                return this.ModeloField;
            }
            set
            {
                this.ModeloField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal PrecioPorDia
        {
            get
            {
                return this.PrecioPorDiaField;
            }
            set
            {
                this.PrecioPorDiaField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Puntaje
        {
            get
            {
                return this.PuntajeField;
            }
            set
            {
                this.PuntajeField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool TieneAireAcon
        {
            get
            {
                return this.TieneAireAconField;
            }
            set
            {
                this.TieneAireAconField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool TieneDireccion
        {
            get
            {
                return this.TieneDireccionField;
            }
            set
            {
                this.TieneDireccionField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string TipoCambio
        {
            get
            {
                return this.TipoCambioField;
            }
            set
            {
                this.TipoCambioField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="PaisEntity", Namespace="http://schemas.datacontract.org/2004/07/WCFReservaVehiculos.Business.DataBaseMode" +
        "l")]
    public partial class PaisEntity : object
    {
        
        private int IdField;
        
        private string NombreField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id
        {
            get
            {
                return this.IdField;
            }
            set
            {
                this.IdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Nombre
        {
            get
            {
                return this.NombreField;
            }
            set
            {
                this.NombreField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ConsultarReservasRequest", Namespace="http://schemas.datacontract.org/2004/07/WCFReservaVehiculos.Business.Entities")]
    public partial class ConsultarReservasRequest : object
    {
        
        private string CodigoReservaField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string CodigoReserva
        {
            get
            {
                return this.CodigoReservaField;
            }
            set
            {
                this.CodigoReservaField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ConsultarReservasResponse", Namespace="http://schemas.datacontract.org/2004/07/WCFReservaVehiculos.Business.Entities")]
    public partial class ConsultarReservasResponse : object
    {
        
        private SOAP_Service.ReservaEntity ReservaField;
        
        private System.DateTime TimeStampField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public SOAP_Service.ReservaEntity Reserva
        {
            get
            {
                return this.ReservaField;
            }
            set
            {
                this.ReservaField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime TimeStamp
        {
            get
            {
                return this.TimeStampField;
            }
            set
            {
                this.TimeStampField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CancelarReservaRequest", Namespace="http://schemas.datacontract.org/2004/07/WCFReservaVehiculos.Business.Entities")]
    public partial class CancelarReservaRequest : object
    {
        
        private string CodigoReservaField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string CodigoReserva
        {
            get
            {
                return this.CodigoReservaField;
            }
            set
            {
                this.CodigoReservaField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CancelarReservaResponse", Namespace="http://schemas.datacontract.org/2004/07/WCFReservaVehiculos.Business.Entities")]
    public partial class CancelarReservaResponse : object
    {
        
        private SOAP_Service.ReservaEntity ReservaField;
        
        private System.DateTime TimeStampField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public SOAP_Service.ReservaEntity Reserva
        {
            get
            {
                return this.ReservaField;
            }
            set
            {
                this.ReservaField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime TimeStamp
        {
            get
            {
                return this.TimeStampField;
            }
            set
            {
                this.TimeStampField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ConsultarCiudadesRequest", Namespace="http://schemas.datacontract.org/2004/07/WCFReservaVehiculos.Business.Entities")]
    public partial class ConsultarCiudadesRequest : object
    {
        
        private int IdPaisField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int IdPais
        {
            get
            {
                return this.IdPaisField;
            }
            set
            {
                this.IdPaisField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ConsultarCiudadesResponse", Namespace="http://schemas.datacontract.org/2004/07/WCFReservaVehiculos.Business.Entities")]
    public partial class ConsultarCiudadesResponse : object
    {
        
        private SOAP_Service.CiudadEntity[] CiudadesField;
        
        private System.DateTime TimeStampField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public SOAP_Service.CiudadEntity[] Ciudades
        {
            get
            {
                return this.CiudadesField;
            }
            set
            {
                this.CiudadesField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime TimeStamp
        {
            get
            {
                return this.TimeStampField;
            }
            set
            {
                this.TimeStampField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ConsultarPaisesResponse", Namespace="http://schemas.datacontract.org/2004/07/WCFReservaVehiculos.Business.Entities")]
    public partial class ConsultarPaisesResponse : object
    {
        
        private SOAP_Service.PaisEntity[] PaisesField;
        
        private System.DateTime TimeStampField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public SOAP_Service.PaisEntity[] Paises
        {
            get
            {
                return this.PaisesField;
            }
            set
            {
                this.PaisesField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime TimeStamp
        {
            get
            {
                return this.TimeStampField;
            }
            set
            {
                this.TimeStampField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="SOAP_Service.IWCFReservaVehiculos")]
    public interface IWCFReservaVehiculos
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWCFReservaVehiculos/ConsultarVehiculosDisponibles", ReplyAction="http://tempuri.org/IWCFReservaVehiculos/ConsultarVehiculosDisponiblesResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(SOAP_Service.StatusResponse), Action="http://tempuri.org/IWCFReservaVehiculos/ConsultarVehiculosDisponiblesStatusRespon" +
            "seFault", Name="StatusResponse", Namespace="http://schemas.datacontract.org/2004/07/WCFReservaVehiculos.Business.ExceptionHan" +
            "dling")]
        System.Threading.Tasks.Task<SOAP_Service.ConsultarVehiculosDisponiblesResponse1> ConsultarVehiculosDisponiblesAsync(SOAP_Service.ConsultarVehiculosDisponiblesRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWCFReservaVehiculos/ReservarVehiculo", ReplyAction="http://tempuri.org/IWCFReservaVehiculos/ReservarVehiculoResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(SOAP_Service.StatusResponse), Action="http://tempuri.org/IWCFReservaVehiculos/ReservarVehiculoStatusResponseFault", Name="StatusResponse", Namespace="http://schemas.datacontract.org/2004/07/WCFReservaVehiculos.Business.ExceptionHan" +
            "dling")]
        System.Threading.Tasks.Task<SOAP_Service.ReservarVehiculoResponse1> ReservarVehiculoAsync(SOAP_Service.ReservarVehiculoRequest1 request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWCFReservaVehiculos/ConsultarReserva", ReplyAction="http://tempuri.org/IWCFReservaVehiculos/ConsultarReservaResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(SOAP_Service.StatusResponse), Action="http://tempuri.org/IWCFReservaVehiculos/ConsultarReservaStatusResponseFault", Name="StatusResponse", Namespace="http://schemas.datacontract.org/2004/07/WCFReservaVehiculos.Business.ExceptionHan" +
            "dling")]
        System.Threading.Tasks.Task<SOAP_Service.ConsultarReservaResponse> ConsultarReservaAsync(SOAP_Service.ConsultarReservaRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWCFReservaVehiculos/CancelarReserva", ReplyAction="http://tempuri.org/IWCFReservaVehiculos/CancelarReservaResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(SOAP_Service.StatusResponse), Action="http://tempuri.org/IWCFReservaVehiculos/CancelarReservaStatusResponseFault", Name="StatusResponse", Namespace="http://schemas.datacontract.org/2004/07/WCFReservaVehiculos.Business.ExceptionHan" +
            "dling")]
        System.Threading.Tasks.Task<SOAP_Service.CancelarReservaResponse1> CancelarReservaAsync(SOAP_Service.CancelarReservaRequest1 request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWCFReservaVehiculos/ConsultarCiudades", ReplyAction="http://tempuri.org/IWCFReservaVehiculos/ConsultarCiudadesResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(SOAP_Service.StatusResponse), Action="http://tempuri.org/IWCFReservaVehiculos/ConsultarCiudadesStatusResponseFault", Name="StatusResponse", Namespace="http://schemas.datacontract.org/2004/07/WCFReservaVehiculos.Business.ExceptionHan" +
            "dling")]
        System.Threading.Tasks.Task<SOAP_Service.ConsultarCiudadesResponse1> ConsultarCiudadesAsync(SOAP_Service.ConsultarCiudadesRequest1 request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWCFReservaVehiculos/ConsultarPaises", ReplyAction="http://tempuri.org/IWCFReservaVehiculos/ConsultarPaisesResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(SOAP_Service.StatusResponse), Action="http://tempuri.org/IWCFReservaVehiculos/ConsultarPaisesStatusResponseFault", Name="StatusResponse", Namespace="http://schemas.datacontract.org/2004/07/WCFReservaVehiculos.Business.ExceptionHan" +
            "dling")]
        System.Threading.Tasks.Task<SOAP_Service.ConsultarPaisesResponse1> ConsultarPaisesAsync(SOAP_Service.ConsultarPaisesRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ConsultarVehiculosDisponibles", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class ConsultarVehiculosDisponiblesRequest
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="")]
        public SOAP_Service.Credentials Credentials;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public SOAP_Service.ConsultarVehiculosRequest ConsultarVehiculosRequest;
        
        public ConsultarVehiculosDisponiblesRequest()
        {
        }
        
        public ConsultarVehiculosDisponiblesRequest(SOAP_Service.Credentials Credentials, SOAP_Service.ConsultarVehiculosRequest ConsultarVehiculosRequest)
        {
            this.Credentials = Credentials;
            this.ConsultarVehiculosRequest = ConsultarVehiculosRequest;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ConsultarVehiculosDisponiblesResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class ConsultarVehiculosDisponiblesResponse1
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public SOAP_Service.ConsultarVehiculosDisponiblesResponse ConsultarVehiculosDisponiblesResult;
        
        public ConsultarVehiculosDisponiblesResponse1()
        {
        }
        
        public ConsultarVehiculosDisponiblesResponse1(SOAP_Service.ConsultarVehiculosDisponiblesResponse ConsultarVehiculosDisponiblesResult)
        {
            this.ConsultarVehiculosDisponiblesResult = ConsultarVehiculosDisponiblesResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ReservarVehiculo", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class ReservarVehiculoRequest1
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="")]
        public SOAP_Service.Credentials Credentials;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public SOAP_Service.ReservarVehiculoRequest ReservarVehiculoRequest;
        
        public ReservarVehiculoRequest1()
        {
        }
        
        public ReservarVehiculoRequest1(SOAP_Service.Credentials Credentials, SOAP_Service.ReservarVehiculoRequest ReservarVehiculoRequest)
        {
            this.Credentials = Credentials;
            this.ReservarVehiculoRequest = ReservarVehiculoRequest;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ReservarVehiculoResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class ReservarVehiculoResponse1
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public SOAP_Service.ReservarVehiculoResponse ReservarVehiculoResult;
        
        public ReservarVehiculoResponse1()
        {
        }
        
        public ReservarVehiculoResponse1(SOAP_Service.ReservarVehiculoResponse ReservarVehiculoResult)
        {
            this.ReservarVehiculoResult = ReservarVehiculoResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ConsultarReserva", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class ConsultarReservaRequest
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="")]
        public SOAP_Service.Credentials Credentials;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ConsultarReservaRequest", Namespace="http://tempuri.org/", Order=0)]
        public SOAP_Service.ConsultarReservasRequest ConsultarReservaRequest1;
        
        public ConsultarReservaRequest()
        {
        }
        
        public ConsultarReservaRequest(SOAP_Service.Credentials Credentials, SOAP_Service.ConsultarReservasRequest ConsultarReservaRequest1)
        {
            this.Credentials = Credentials;
            this.ConsultarReservaRequest1 = ConsultarReservaRequest1;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ConsultarReservaResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class ConsultarReservaResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public SOAP_Service.ConsultarReservasResponse ConsultarReservaResult;
        
        public ConsultarReservaResponse()
        {
        }
        
        public ConsultarReservaResponse(SOAP_Service.ConsultarReservasResponse ConsultarReservaResult)
        {
            this.ConsultarReservaResult = ConsultarReservaResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="CancelarReserva", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class CancelarReservaRequest1
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="")]
        public SOAP_Service.Credentials Credentials;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public SOAP_Service.CancelarReservaRequest CancelarReservaRequest;
        
        public CancelarReservaRequest1()
        {
        }
        
        public CancelarReservaRequest1(SOAP_Service.Credentials Credentials, SOAP_Service.CancelarReservaRequest CancelarReservaRequest)
        {
            this.Credentials = Credentials;
            this.CancelarReservaRequest = CancelarReservaRequest;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="CancelarReservaResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class CancelarReservaResponse1
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public SOAP_Service.CancelarReservaResponse CancelarReservaResult;
        
        public CancelarReservaResponse1()
        {
        }
        
        public CancelarReservaResponse1(SOAP_Service.CancelarReservaResponse CancelarReservaResult)
        {
            this.CancelarReservaResult = CancelarReservaResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ConsultarCiudades", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class ConsultarCiudadesRequest1
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="")]
        public SOAP_Service.Credentials Credentials;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public SOAP_Service.ConsultarCiudadesRequest ConsultarCiudadesRequest;
        
        public ConsultarCiudadesRequest1()
        {
        }
        
        public ConsultarCiudadesRequest1(SOAP_Service.Credentials Credentials, SOAP_Service.ConsultarCiudadesRequest ConsultarCiudadesRequest)
        {
            this.Credentials = Credentials;
            this.ConsultarCiudadesRequest = ConsultarCiudadesRequest;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ConsultarCiudadesResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class ConsultarCiudadesResponse1
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public SOAP_Service.ConsultarCiudadesResponse ConsultarCiudadesResult;
        
        public ConsultarCiudadesResponse1()
        {
        }
        
        public ConsultarCiudadesResponse1(SOAP_Service.ConsultarCiudadesResponse ConsultarCiudadesResult)
        {
            this.ConsultarCiudadesResult = ConsultarCiudadesResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ConsultarPaises", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class ConsultarPaisesRequest
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="")]
        public SOAP_Service.Credentials Credentials;
        
        public ConsultarPaisesRequest()
        {
        }
        
        public ConsultarPaisesRequest(SOAP_Service.Credentials Credentials)
        {
            this.Credentials = Credentials;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ConsultarPaisesResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class ConsultarPaisesResponse1
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public SOAP_Service.ConsultarPaisesResponse ConsultarPaisesResult;
        
        public ConsultarPaisesResponse1()
        {
        }
        
        public ConsultarPaisesResponse1(SOAP_Service.ConsultarPaisesResponse ConsultarPaisesResult)
        {
            this.ConsultarPaisesResult = ConsultarPaisesResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    public interface IWCFReservaVehiculosChannel : SOAP_Service.IWCFReservaVehiculos, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    public partial class WCFReservaVehiculosClient : System.ServiceModel.ClientBase<SOAP_Service.IWCFReservaVehiculos>, SOAP_Service.IWCFReservaVehiculos
    {
        
    /// <summary>
    /// Implemente este método parcial para configurar el punto de conexión de servicio.
    /// </summary>
    /// <param name="serviceEndpoint">El punto de conexión para configurar</param>
    /// <param name="clientCredentials">Credenciales de cliente</param>
    static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public WCFReservaVehiculosClient() : 
                base(WCFReservaVehiculosClient.GetDefaultBinding(), WCFReservaVehiculosClient.GetDefaultEndpointAddress())
        {
            this.Endpoint.Name = EndpointConfiguration.BasicHttpBinding_IWCFReservaVehiculos.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public WCFReservaVehiculosClient(EndpointConfiguration endpointConfiguration) : 
                base(WCFReservaVehiculosClient.GetBindingForEndpoint(endpointConfiguration), WCFReservaVehiculosClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public WCFReservaVehiculosClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(WCFReservaVehiculosClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public WCFReservaVehiculosClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(WCFReservaVehiculosClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public WCFReservaVehiculosClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<SOAP_Service.ConsultarVehiculosDisponiblesResponse1> SOAP_Service.IWCFReservaVehiculos.ConsultarVehiculosDisponiblesAsync(SOAP_Service.ConsultarVehiculosDisponiblesRequest request)
        {
            return base.Channel.ConsultarVehiculosDisponiblesAsync(request);
        }
        
        public System.Threading.Tasks.Task<SOAP_Service.ConsultarVehiculosDisponiblesResponse1> ConsultarVehiculosDisponiblesAsync(SOAP_Service.Credentials Credentials, SOAP_Service.ConsultarVehiculosRequest ConsultarVehiculosRequest)
        {
            SOAP_Service.ConsultarVehiculosDisponiblesRequest inValue = new SOAP_Service.ConsultarVehiculosDisponiblesRequest();
            inValue.Credentials = Credentials;
            inValue.ConsultarVehiculosRequest = ConsultarVehiculosRequest;
            return ((SOAP_Service.IWCFReservaVehiculos)(this)).ConsultarVehiculosDisponiblesAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<SOAP_Service.ReservarVehiculoResponse1> SOAP_Service.IWCFReservaVehiculos.ReservarVehiculoAsync(SOAP_Service.ReservarVehiculoRequest1 request)
        {
            return base.Channel.ReservarVehiculoAsync(request);
        }
        
        public System.Threading.Tasks.Task<SOAP_Service.ReservarVehiculoResponse1> ReservarVehiculoAsync(SOAP_Service.Credentials Credentials, SOAP_Service.ReservarVehiculoRequest ReservarVehiculoRequest)
        {
            SOAP_Service.ReservarVehiculoRequest1 inValue = new SOAP_Service.ReservarVehiculoRequest1();
            inValue.Credentials = Credentials;
            inValue.ReservarVehiculoRequest = ReservarVehiculoRequest;
            return ((SOAP_Service.IWCFReservaVehiculos)(this)).ReservarVehiculoAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<SOAP_Service.ConsultarReservaResponse> SOAP_Service.IWCFReservaVehiculos.ConsultarReservaAsync(SOAP_Service.ConsultarReservaRequest request)
        {
            return base.Channel.ConsultarReservaAsync(request);
        }
        
        public System.Threading.Tasks.Task<SOAP_Service.ConsultarReservaResponse> ConsultarReservaAsync(SOAP_Service.Credentials Credentials, SOAP_Service.ConsultarReservasRequest ConsultarReservaRequest1)
        {
            SOAP_Service.ConsultarReservaRequest inValue = new SOAP_Service.ConsultarReservaRequest();
            inValue.Credentials = Credentials;
            inValue.ConsultarReservaRequest1 = ConsultarReservaRequest1;
            return ((SOAP_Service.IWCFReservaVehiculos)(this)).ConsultarReservaAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<SOAP_Service.CancelarReservaResponse1> SOAP_Service.IWCFReservaVehiculos.CancelarReservaAsync(SOAP_Service.CancelarReservaRequest1 request)
        {
            return base.Channel.CancelarReservaAsync(request);
        }
        
        public System.Threading.Tasks.Task<SOAP_Service.CancelarReservaResponse1> CancelarReservaAsync(SOAP_Service.Credentials Credentials, SOAP_Service.CancelarReservaRequest CancelarReservaRequest)
        {
            SOAP_Service.CancelarReservaRequest1 inValue = new SOAP_Service.CancelarReservaRequest1();
            inValue.Credentials = Credentials;
            inValue.CancelarReservaRequest = CancelarReservaRequest;
            return ((SOAP_Service.IWCFReservaVehiculos)(this)).CancelarReservaAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<SOAP_Service.ConsultarCiudadesResponse1> SOAP_Service.IWCFReservaVehiculos.ConsultarCiudadesAsync(SOAP_Service.ConsultarCiudadesRequest1 request)
        {
            return base.Channel.ConsultarCiudadesAsync(request);
        }
        
        public System.Threading.Tasks.Task<SOAP_Service.ConsultarCiudadesResponse1> ConsultarCiudadesAsync(SOAP_Service.Credentials Credentials, SOAP_Service.ConsultarCiudadesRequest ConsultarCiudadesRequest)
        {
            SOAP_Service.ConsultarCiudadesRequest1 inValue = new SOAP_Service.ConsultarCiudadesRequest1();
            inValue.Credentials = Credentials;
            inValue.ConsultarCiudadesRequest = ConsultarCiudadesRequest;
            return ((SOAP_Service.IWCFReservaVehiculos)(this)).ConsultarCiudadesAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<SOAP_Service.ConsultarPaisesResponse1> SOAP_Service.IWCFReservaVehiculos.ConsultarPaisesAsync(SOAP_Service.ConsultarPaisesRequest request)
        {
            return base.Channel.ConsultarPaisesAsync(request);
        }
        
        public System.Threading.Tasks.Task<SOAP_Service.ConsultarPaisesResponse1> ConsultarPaisesAsync(SOAP_Service.Credentials Credentials)
        {
            SOAP_Service.ConsultarPaisesRequest inValue = new SOAP_Service.ConsultarPaisesRequest();
            inValue.Credentials = Credentials;
            return ((SOAP_Service.IWCFReservaVehiculos)(this)).ConsultarPaisesAsync(inValue);
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        public virtual System.Threading.Tasks.Task CloseAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginClose(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndClose));
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IWCFReservaVehiculos))
            {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                return result;
            }
            throw new System.InvalidOperationException(string.Format("No se pudo encontrar un punto de conexión con el nombre \"{0}\".", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IWCFReservaVehiculos))
            {
                return new System.ServiceModel.EndpointAddress("http://services-1712917028.us-east-1.elb.amazonaws.com/turicor/WCFReservaVehiculo" +
                        "s.svc/basic");
            }
            throw new System.InvalidOperationException(string.Format("No se pudo encontrar un punto de conexión con el nombre \"{0}\".", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding()
        {
            return WCFReservaVehiculosClient.GetBindingForEndpoint(EndpointConfiguration.BasicHttpBinding_IWCFReservaVehiculos);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress()
        {
            return WCFReservaVehiculosClient.GetEndpointAddress(EndpointConfiguration.BasicHttpBinding_IWCFReservaVehiculos);
        }
        
        public enum EndpointConfiguration
        {
            
            BasicHttpBinding_IWCFReservaVehiculos,
        }
    }
}
