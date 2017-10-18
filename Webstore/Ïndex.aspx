<%@ Page MasterPageFile="~/WebshopMaster.Master" Language="C#" AutoEventWireup="true" CodeBehind="Ïndex.aspx.cs" Inherits="Webstore.WebForm1" %>

<asp:Content ContentPlaceHolderID="main_head" runat="server">
 
    <link href="StyleSheetWebshop.css" rel="stylesheet" />
</asp:Content>

<asp:Content ContentPlaceHolderID="main_content" runat="server">
    <div class="tableBody">
        <h2>Pennor</h2>
        <div class="tableRow">
            <div class="tableCell">
                <input class="buttonShow" type="button" value="Visa" /></div>
            <div class="tableCell">
                <input class="buttonShow" type="button" value="Visa" /></div>
            <div class="tableCell">
                <input class="buttonShow" type="button" value="Visa" /></div>
        </div>
        <h2>Papper</h2>
        <div class="tableRow">
            <div class="tableCell">
                <input class="buttonShow" type="button" value="Visa" /></div>
            <div class="tableCell">
                <input class="buttonShow" type="button" value="Visa" /></div>
            <div class="tableCell">
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
