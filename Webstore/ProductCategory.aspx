<%@ Page MasterPageFile="~/WebshopMaster.Master" Language="C#" AutoEventWireup="true" CodeBehind="productCategory.aspx.cs" Inherits="Webstore.ProductCategory" %>

<asp:Content ContentPlaceHolderID="main_head" runat="server">

    <link href="StyleSheetWebshop.css" rel="stylesheet" />
</asp:Content>
<asp:Content ContentPlaceHolderID="main_content" runat="server">
    <div class="tableBody">
        <asp:Label ID="labelOrientation" runat="server" Text="Startsida > Pennor"></asp:Label>
        <table id="tableCategorySortBy" style="width: 100%;">
            <tr>
                <td class="auto-style1" style="width: 70%">
                    <h2>Pennor</h2>
                </td>
                <td class="tdCategorySortBy" style="width: 30%">Sortera efter
             <select>
                 <option value="popularity">Popularitet</option>
                 <option value="lowToHigh">Pris stigande</option>
                 <option value="highToLow">Pris fallande</option>
             </select></td>
            </tr>
        </table>
        <div class="tableRow">
            <div class="tableCell">
                <input class="buttonShow" type="button" value="Köp" /></div>
            <div class="tableCell">
                <input class="buttonShow" type="button" value="Köp" /></div>
            <div class="tableCell">
                <input class="buttonShow" type="button" value="Köp" /></div>
        </div>
        <div class="tableRow">
            <div class="tableCell">
                <input class="buttonShow" type="button" value="Köp" /></div>
            <div class="tableCell">
                <input class="buttonShow" type="button" value="Köp" /></div>
            <div class="tableCell">
                <input class="buttonShow" type="button" value="Köp" /></div>
        </div>
        <div class="tableRow">
            <div class="tableCell">
                <input class="buttonShow" type="button" value="Köp" /></div>
            <div class="tableCell">
                <input class="buttonShow" type="button" value="Köp" /></div>
            <div class="tableCell">
                <input class="buttonShow" type="button" value="Köp" /></div>
        </div>
        <asp:Label ID="labelBack" runat="server" Text="Tillbaka"></asp:Label>
    </div>

</asp:Content>
