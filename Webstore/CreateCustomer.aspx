<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CreateCustomer.aspx.cs" Inherits="Webstore.CreateCustomer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="StyleSheet.css" rel="stylesheet" />
     
  
</head>
<body>
    <form id="form1" runat="server">
        <div id="TableDiv">
        
        
        <table>
            <thead>
                <tr>
                    <td style="font-size: large; font-weight: bold; font-family: 'Javanese Text';">Kontaktuppgifter</td>
                </tr>
            </thead>
            <tbody>
                <tr>
                    <td>Förnamn</td>
                    <td>Efternamn</td>
                    <td>Personnummer (ååååmmdd-xxxx)</td>
                </tr>
                <tr>
                    <td>
                        <asp:TextBox ID="textBoxFirstname" runat="server"></asp:TextBox>
                    </td>
                    <td class="auto-style2">
                        <asp:TextBox ID="textBoxLastname" runat="server" ></asp:TextBox>
                    </td>
                    <td class="auto-style3">
                        <asp:TextBox ID="textBoxSSN" runat="server"></asp:TextBox>
                    </td>
                </tr>
            </tbody>
        </table>
        <table class="TableEmail">
            <tbody>
                <tr>
                    <td>E-postadress</td>
                    <td>Bekräfta E-postadress</td>
                </tr>
                <tr>
                    <td>
                        <asp:TextBox ID="textBoxEmail" runat="server" ></asp:TextBox>
                    </td>
                    <td>
                        <asp:TextBox ID="textBoxEmailVerify" runat="server"></asp:TextBox>
                    </td>
                </tr>

                <tr>
                    <td>Ange lösenord</td>
                    <td>Bekräfta lösenord</td>
                </tr>
                <tr>
                    <td>
                        <asp:TextBox ID="textBoxPassword" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        <asp:TextBox ID="textBoxPasswordVerify" runat="server"></asp:TextBox>
                    </td>
                </tr>
            </tbody>
        </table>
        <table class="TableAdress">
            <thead>
                <tr>
                    <td style="font-size: large; font-weight: bold; font-family: 'Javanese Text';">Adress</td>
                    <td>&nbsp;</td>
                    
                </tr>
            </thead>
            <tbody>

                 <tr>
                    <td>Gatuadress</td>
                    <td>Postnummer</td>
                </tr>
                <tr>
                    <td>
                        <asp:TextBox ID="textBoxStreet" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        <asp:TextBox ID="textBoxZIP" runat="server" ></asp:TextBox>
                    </td>
                </tr>

                <tr>
                    <td>Ort</td>
                    <td>Land</td>
                </tr>
                <tr>
                    <td>
                        <asp:TextBox ID="textBoxCity" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        <asp:TextBox ID="textBoxCountry" runat="server"></asp:TextBox>
                    </td>
                </tr>

               
            </tbody>
        </table>
            
        <asp:Button ID="btnCreateCust" runat="server" Height="46px" OnClick="btnCreateCust_Click" Text="Skapa Konto" Width="125px" />
        </div>
    </form>
</body>
</html>
