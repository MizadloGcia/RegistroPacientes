<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="RegistroSistema.aspx.cs" Inherits="RegistroPacientes.RegistroSistema" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <asp:Label ID="Label1" runat="server" Text="Sistema Fisiologico: "></asp:Label>
        <asp:TextBox ID="NombreTextBox" runat="server"></asp:TextBox>
        <br />
    </div>
    <div>
        <asp:Button ID="GuardarButton" runat="server" Text="Guardar" OnClick="GuardarButton_Click" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="VerSistButton" runat="server" Text="Ver Sistemas Fisiologicos" OnClick="VerSistButton_Click" />
    </div>
</asp:Content>
