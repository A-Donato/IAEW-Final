<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>TuriCor S.A.</h1>
        <p class="lead">Trabajo Practico Integrador IAEW</p>
    </div>

    <div class="row">
        <div class="col-md-6">
            <h2>Consultar vehiculos</h2>
            <p>
               Conocer la disponibilidad de vehiculos para una ciudad destino. Se solicita el igreso del periodo de tiempo deseado.
            </p>
            <p>
                <a class="btn btn-default" href="/">Consultar</a>
            </p>
        </div>
        <div class="col-md-6">
            <h2>Listado de Reservas</h2>
            <p>
               Conocer las reservas realizadas hasta el momento.
            </p>
            <p>
                <a class="btn btn-default" href="/">Reservas</a>
            </p>
        </div>
    </div>
</asp:Content>
