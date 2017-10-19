<%@ Page MasterPageFile="~/WebshopMaster.Master" Language="C#" AutoEventWireup="true" CodeBehind="ShoppingCart.aspx.cs" Inherits="Webstore.ShoppingCart" %>

<asp:Content ContentPlaceHolderID="main_head" runat="server">
    <link href="StyleSheetWebshop.css" rel="stylesheet" />
</asp:Content>

<asp:Content ContentPlaceHolderID="main_content" runat="server">
    <div>
        <div class="mainContent"><h2>Varukorg</h2>

            <table style="width: 95%;margin-left: 5%;margin-top: 5%;">
                <tr>
                    <th>Produkt</th>
                    <th>Artikelnummer</th>
                    <th>Antal</th>
                    <th>Pris</th>
                </tr>
                <tr>
                    <td>Penna</td>
                    <td>100254</td>
                    <td>5</td>
                    <td>59,00</td>
                </tr>
                <tr>
                    <td>Penna</td>
                    <td>100254</td>
                    <td>5</td>
                    <td>59,00</td>
                </tr>
            </table>

        <div class="divButtonAddProduct">            
            <input type="button" class="buttonProduct" value="Betala" />
            <input type="button" class="buttonProduct" value="Ta bort" />
        </div>
    </div>
    </div>
</asp:Content>
