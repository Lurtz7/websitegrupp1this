<%@ Page MasterPageFile="~/WebshopMaster.Master" Language="C#" AutoEventWireup="true" CodeBehind="AdminPage.aspx.cs" Inherits="Webstore.AdminPage" %>

<asp:Content ContentPlaceHolderID="main_head" runat="server">
    <link href="StyleSheetWebshop.css" rel="stylesheet" />

</asp:Content>

<asp:Content ContentPlaceHolderID="main_content" runat="server">
<div>    
    <div class="mainContent"><h2>Lägg till produkt</h2>

        <div class="divAdminAddProduct"><asp:Label ID="LabelProductName" runat="server" Text="Produktnamn"></asp:Label></div>
        <div class="divAdminTextBox"><asp:TextBox ID="TextBoxProductName" runat="server"></asp:TextBox></div>

        <div class="divAdminAddProduct"><asp:Label ID="LabelPrice" runat="server" Text="Pris"></asp:Label></div>
        <div class="divAdminTextBox"><asp:TextBox ID="TextBoxPrice" runat="server"></asp:TextBox></div> 

        <div class="divAdminAddProduct"><asp:Label ID="LabelImage" runat="server" Text="Url bild"></asp:Label></div>
        <div class="divAdminTextBox"><asp:TextBox ID="TextBoxImage" runat="server"></asp:TextBox></div>

        <div class="divAdminAddProduct"><asp:Label ID="LabelStockNr" runat="server" Text="Artikelnummer"></asp:Label></div>
        <div class="divAdminTextBox"><asp:TextBox ID="TextBoxStockNr" runat="server"></asp:TextBox></div>

        <div class="divAdminAddProduct"><asp:Label ID="LabelSoldNr" runat="server" Text="Lagerstatus"></asp:Label></div>
        <div class="divAdminTextBox"> <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox></div>
        
        <div class="divAdminAddProduct"><asp:Label ID="LabelProductDescription" runat="server" Text="Beskrivning"></asp:Label></div>
        <div class="divAdminTextBox"><asp:TextBox ID="TextBoxProductDescription" runat="server"></asp:TextBox></div>

        <div class="divButtonAddProduct">
            <input type="button" class="buttonProduct" value="Lägg till" />
            <%--<input type="button" class="buttonProduct" value="Radera" />
            <input type="button" class="buttonProduct" value="Uppdatera" />--%></div>
    </div>

</div>
    </asp:Content>