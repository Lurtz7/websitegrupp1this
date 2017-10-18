<%@ Page MasterPageFile="~/WebshopMaster.Master" Language="C#" AutoEventWireup="true" CodeBehind="Ïndex.aspx.cs" Inherits="Webstore.WebForm1" %>

<asp:Content ContentPlaceHolderID="main_head" runat="server">
 
    <link href="StyleSheetWebshop.css" rel="stylesheet" />
</asp:Content>

<asp:Content ContentPlaceHolderID="main_content" runat="server">
    <div class="tableBody">
        <div class="pin1"><asp:Image ID="Image3" runat="server" Height="44px" ImageUrl="http://icon-park.com/imagefiles/pin_green.png" Width="32px" /></div>
        <div class="pin2"><asp:Image ID="Image1" runat="server" Height="44px" ImageUrl="http://icon-park.com/imagefiles/pin_green.png" Width="32px" /></div>
        <br /><br />
        <h2>Pennor</h2>
        <div class="tableRow">
            <div class="tableCell"id="pen1">
                <input class="buttonShow" type="button" value="Visa" /></div>
            <div class="tableCell"id="pen2">
                <input class="buttonShow" type="button" value="Visa" /></div>
            <div class="tableCell"id="pen3">
                <input class="buttonShow" type="button" value="Visa" /></div>
        </div>
        <h2>Papper</h2>
        <div class="tableRow">
            <div class="tableCell" id="paper1">
                <input class="buttonShow" type="button" value="Visa" /></div>
            <div class="tableCell" id="paper2">>
                <input class="buttonShow" type="button" value="Visa" /></div>
            <div class="tableCell" id="paper3">>
                <input class="buttonShow" type="button" value="Visa" /></div>
        </div>
        <h2>Möbler</h2>
        <div class="tableRow">
            <div class="tableCell">
                <input class="buttonShow" type="button" value="Visa" /></div>
            <div class="tableCell">
                <input class="buttonShow" type="button" value="Visa" /></div>
            <div class="tableCell">
                <input class="buttonShow" type="button" value="Visa" /></div>
        </div>
    </div>
</asp:Content>
