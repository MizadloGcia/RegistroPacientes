<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="MenuPrincipal.aspx.cs" Inherits="RegistroPacientes.MenuPrincipal" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <asp:Button ID="RegPacButton" runat="server" Text="Registrar Paciente" OnClick="RegPacButton_Click" />
        <asp:Button ID="ConsPacButton" runat="server" Text="Consultar Paciente" OnClick="ConsPacButton_Click" />
        <asp:Button ID="RegRevButton" runat="server" Text="Registrar Revision" OnClick="RegRevButton_Click" />
        <asp:Button ID="ConsRevButton" runat="server" Text="Consultar Revision" />
        <asp:Button ID="RegSistButton" runat="server" Text="Registrar Sistema Fisiologico" OnClick="RegSistButton_Click" />
        <asp:Button ID="CerrarSesButton" runat="server" Text="Cerrar Session" OnClick="CerrarSesButton_Click" />
    </div>
</asp:Content>
