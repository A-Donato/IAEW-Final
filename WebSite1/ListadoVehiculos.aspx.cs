using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using RestApi.Controllers;

public partial class Home : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        var idSolicitada = 0;
        var fechaDesde = "";
        var FechaHasta = "";


        var ve = new VehiculosController();
        var res = ve.ConsultarVehiculosDisponibles(1, );
        
    }
}