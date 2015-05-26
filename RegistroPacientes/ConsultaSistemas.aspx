<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="ConsultaSistemas.aspx.cs" Inherits="RegistroPacientes.ConsultaSistemas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <asp:Label ID="Label1" runat="server" Text="Sistema Fisiologico: "></asp:Label>
        <asp:TextBox ID="FiltroTextBox" runat="server"></asp:TextBox>
        <asp:Button ID="BuscarButton" runat="server" Text="Buscar" OnClick="BuscarButton_Click" />
        <asp:GridView ID="SistFisGridView" runat="server"></asp:GridView>
    </div>
</asp:Content>
