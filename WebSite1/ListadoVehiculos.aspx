<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ListadoVehiculos.aspx.cs" Inherits="Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div>
                <a>Id de ciudad deseada</a><input />
                <a>Fecha desde</a><input dir="auto" />
                <a>Fecha hasta</a><input />
            </div>


            <table class="table table-striped">
                <thead class="thead-dark">
                    <tr>
                        <th scope="col">Id Vehiculo</th>
                        <th scope="col">Cantidad Disponible</th>
                        <th scope="col">Cantidad Puertas</th>
                        <th scope="col">Id Ciudad</th>
                        <th scope="col">Id Vehiculo</th>
                        <th scope="col">Marca</th>
                        <th scope="col">Modelo</th>
                        <th scope="col">Precio por dia</th>
                        <th scope="col">Puntaje</th>
                        <th scope="col">Tiene Aire acondicionado</th>
                        <th scope="col">Tiene Direccion</th>
                        <th scope="col">Tipo de Cambio</th>
                        <th scope="col">Vehiculo Ciudad ID</th>
                    </tr>
                </thead>
                <tbody>
                    <tr>
                        <th scope="row">1</th>
                        <td>Mark</td>
                        <td>Otto</td>
                        <td>@mdo</td>
                </tbody>
            </table>
        </div>
    </form>
</body>
</html>
