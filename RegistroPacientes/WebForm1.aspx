<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="RegistroPacientes.WebForm1" %>
<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <asp:Label ID="Label2" runat="server" Text="Nombres"></asp:Label>
        <asp:TextBox ID="NombresTextBox" runat="server"></asp:TextBox>
    </div>
    <div>
        <asp:Label ID="Label1" runat="server" Text="Apellidos"></asp:Label>
        <asp:TextBox ID="ApellidosTextbox" runat="server"></asp:TextBox>
    </div>
    <div>
        <asp:Label ID="Label3" runat="server" Text="Direccion"></asp:Label>
        <asp:TextBox ID="DireccionTextBox" runat="server"></asp:TextBox>
    </div>
    <div>
        <asp:Label ID="Label4" runat="server" Text="Telefono"></asp:Label>
        <asp:TextBox ID="TelefonoTextBox" runat="server"></asp:TextBox>
    </div>
    <div>
        <asp:Label ID="Label5" runat="server" Text="Celular"></asp:Label>
        <asp:TextBox ID="CelularTextBox" runat="server"></asp:TextBox>
    </div>
    <div>
        <asp:Label ID="Label6" runat="server" Text="Cedula"></asp:Label>
        <asp:TextBox ID="CedulaTextBox" runat="server"></asp:TextBox>
    </div>
    <div>
        <asp:Label ID="Label7" runat="server" Text="Fecha de Nac"></asp:Label>
        <asp:TextBox ID="FechaNacTextBox" runat="server" TextMode="Date"></asp:TextBox>
    </div>
    <div>
        <asp:Label ID="Label8" runat="server" Text="Fecha Ingreso"></asp:Label>
        <asp:TextBox ID="FechaIngresoTextBox" runat="server" TextMode="Date"></asp:TextBox>
    </div>
    <div>
        <asp:Label ID="Label9" runat="server" Text="Ocupacion"></asp:Label>
        <asp:TextBox ID="OcupacionTextBox" runat="server"></asp:TextBox>
    </div>
    <div>
        <asp:Label ID="Label10" runat="server" Text="Genero"></asp:Label>
        <asp:DropDownList ID="SexoDropDownList" runat="server">
            <asp:ListItem Value="0">Seleccionar Sexo</asp:ListItem>
            <asp:ListItem Value="1">Femenino</asp:ListItem>
            <asp:ListItem Value="2">Masculino</asp:ListItem>
        </asp:DropDownList>
    </div>
    <div>
        <asp:Button ID="GuardarButton" runat="server" Text="Guardar" OnClick="GuardarButton_Click" />
    </div>
</asp:Content>
