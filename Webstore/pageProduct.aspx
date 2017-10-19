<%@ Page MasterPageFile="~/WebshopMaster.Master" Language="C#" AutoEventWireup="true" CodeBehind="pageProduct.aspx.cs" Inherits="Webstore.pageProduct" %>

<asp:Content ContentPlaceHolderID="main_head" runat="server">
    <link href="StyleSheetWebshop.css" rel="stylesheet" />
</asp:Content>
<asp:Content ContentPlaceHolderID="main_content" runat="server">
    <div class="mainContent" id="Productid">

        <asp:Image ID="ImageProduct" runat="server" />
        <div id="divPrice">
        <asp:Label ID="labelProductPrice" runat="server" Text="Label"></asp:Label> <br /><br/><br />
        <asp:TextBox ID="textBoxAmount" runat="server" Width="50px"></asp:TextBox> <br /><br />
        <asp:Button ID="buttonAddProduct" runat="server" Text="Lägg till i varukorg" OnClick="buttonAddProduct_Click" />
        </div>
        <asp:Label ID="labelProductInfo" runat="server" Text="Label"></asp:Label>


    </div>

    <%--     
            <div class="divProductPrice">

                   
                            <td style="width: 30%">Lagerstatus:</td>
                            <td id="lagerStatus" class="auto-style9" style="width: 70%">I lager</td>                      
                    </tr>
                    <tr>
                        <td id="productPrice" class="auto-style4">49,00 kr</td>                                             
                    </tr>
                    <tr>
                        <td style="width: 30%" >Antal</td>
                        <td id="productAmount" class="auto-style1" style="width: 70%">
                            <asp:TextBox ID="textBoxAmount" runat="server" Width="23px"></asp:TextBox></td>                          
                    </tr>
                    <tr>                        
                        <td colspan="2"><input type="button" id="buttonAddProduct" value="Lägg till" class="auto-style5" /></td>
                    </tr>
                </table></div>--%>
</asp:Content>
