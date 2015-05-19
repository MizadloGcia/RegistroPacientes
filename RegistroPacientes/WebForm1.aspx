<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="RegistroPacientes.WebForm1" %>
<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        <asp:Label ID="Label2" runat="server" Text="Nombres"></asp:Label>
        <asp:TextBox ID="NombresTextBox" runat="server"></asp:TextBox>
    </p>
    <p>
        <asp:Label ID="Label1" runat="server" Text="Apellidos"></asp:Label>
        <asp:TextBox ID="ApellidosTextbox" runat="server"></asp:TextBox>
    </p>
    <p>
        <asp:Label ID="Label3" runat="server" Text="Direccion"></asp:Label>
        <asp:TextBox ID="DireccionTextBox" runat="server"></asp:TextBox>
    </p>
    <p>
        <asp:Label ID="Label4" runat="server" Text="Telefono"></asp:Label>
        <asp:TextBox ID="TelefonoTextBox" runat="server"></asp:TextBox>
    </p>
    <p>
        <asp:Label ID="Label5" runat="server" Text="Celular"></asp:Label>
        <asp:TextBox ID="CelularTextBox" runat="server"></asp:TextBox>
    </p>
    <p>
        <asp:Label ID="Label6" runat="server" Text="Cedula"></asp:Label>
        <asp:TextBox ID="CedulaTextBox" runat="server"></asp:TextBox>
    </p>
    <p>
        <asp:Label ID="Label7" runat="server" Text="Fecha de Nac"></asp:Label>
        <asp:TextBox ID="FechaNacTextBox" runat="server"></asp:TextBox>
    </p>
    <p>
        <asp:Label ID="Label8" runat="server" Text="Fecha Ingreso"></asp:Label>
        <asp:TextBox ID="FechaIngresoTextBox" runat="server"></asp:TextBox>
    </p>
</asp:Content>
