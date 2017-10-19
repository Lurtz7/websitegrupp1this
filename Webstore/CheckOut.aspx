<%@ Page MasterPageFile="~/WebshopMaster.Master" Language="C#" AutoEventWireup="true" CodeBehind="CheckOut.aspx.cs" Inherits="Webstore.CheckOut" %>

<asp:Content ContentPlaceHolderID="main_head" runat="server">
    <link href="StyleSheetWebshop.css" rel="stylesheet" />
</asp:Content>

<asp:Content ContentPlaceHolderID="main_content" runat="server">
    <div>
        <div class="mainContent"><h2>Betala</h2>
        <asp:Label ID="LabelChooseAddress" runat="server" Text="Välj leveransadress"></asp:Label>
        <select>
                 <option value="adress1">Borgarfjordsgatan 4, 123 45 Kista</option>
                 <option value="adress2">Drottninggatan 43, 123 45 Stockholm</option>                 
        </select>

        <div class="divPayment">eller skriv in en ny adress</div>

        <div class="divAdminAddProduct1"><asp:Label ID="LabelAddress" runat="server" Text="Adress"></asp:Label></div>
        <div class="divAdminTextBox1"><asp:TextBox ID="TextBoxAddress" runat="server"></asp:TextBox></div>

        <div class="divAdminAddProduct1"><asp:Label ID="LabelZipCode" runat="server" Text="Postnummer"></asp:Label></div>
        <div class="divAdminTextBox1"><asp:TextBox ID="TextBoxZipCode" runat="server"></asp:TextBox></div>

        <div class="divAdminAddProduct1"><asp:Label ID="LabelCity" runat="server" Text="Postort"></asp:Label></div>
        <div class="divAdminTextBox1"> <asp:TextBox ID="TextBoxCity" runat="server"></asp:TextBox></div>

           <div></div> 
           <div>Välj betalningsmetod:</div>
         <div>
         <input type="radio" name="gender" value="kort" /> Kort
         <input type="radio" name="gender" value="faktura"/> Faktura
         <input type="radio" name="gender" value="kontant"/> Kontant             
            </div>
            <div class="divButtonAddProduct">            
            <input type="button" class="buttonProduct"  id="Buy" value="Godkänn" />
            <input type="button" class="buttonProduct" id="Cancel" value="Avbryt" />
        </div>
        </div>
    </div>
</asp:Content>
