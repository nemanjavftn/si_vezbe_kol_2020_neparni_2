<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Teams.aspx.cs" Inherits="WebApplicationKolokvijum.Teams" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:ListBox ID="ListBoxTeams" runat="server" Height="187px" OnSelectedIndexChanged="ListBoxTeams_SelectedIndexChanged" Width="428px"></asp:ListBox>

    <asp:Label ID="LabelName" runat="server" Text="Name"></asp:Label>
    <asp:TextBox ID="TextBoxName" runat="server"></asp:TextBox>
    <asp:Label ID="LabelCouch" runat="server" Text="Couch"></asp:Label>

</asp:Content>
