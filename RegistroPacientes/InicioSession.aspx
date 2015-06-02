<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="InicioSession.aspx.cs" Inherits="RegistroPacientes.InicioSession" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <asp:Label ID="Label1" runat="server" Text="Nombre Usuario"></asp:Label>
        <asp:TextBox ID="NomUsuarioTextBox" runat="server"></asp:TextBox>
    </div>
    <div>
        <asp:Label ID="Label2" runat="server" Text="Password"></asp:Label>
        <asp:TextBox ID="PassTextBox" runat="server" AutoCompleteType="Disabled"></asp:TextBox>
    </div>
    <div>
        <asp:Button ID="LogInButton" runat="server" Text="Log in" OnClick="LogInButton_Click" />
    </div>
</asp:Content>
