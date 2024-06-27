<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="viewcart.aspx.cs" Inherits="SVU_ITE_Bwp401_F23_c3.viewcart" %>
<asp:Content ID="Content1" ContentPlaceHolderID="c1" runat="server">
      <table>
        <tr><td ><img src="images/cart.jpg" /><asp:LinkButton ID="LinkButton1" runat="server" OnClick="cart_click">Your cart is</asp:LinkButton> </td></tr>
        <tr>
            <td class="auto-style4"><asp:Label ID="countlbl" runat="server" Text=""></asp:Label></td>
            </tr>
            <tr>
            <td class="auto-style3"><asp:Label ID="pricelbl" runat="server" Text=""></asp:Label>
                <br />
                <br />
                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Confirm" Width="214px" />
                <br />
                <asp:Label ID="namelbl" runat="server" Font-Bold="True" Text="Enter your name :" Visible="False"></asp:Label>
                <asp:TextBox ID="nametxt" runat="server" Visible="False"></asp:TextBox>
                <br />
                <asp:Label ID="countrylbl" runat="server" Font-Bold="True" Text="Choose your country :" Visible="False"></asp:Label>
                <asp:DropDownList ID="countrydp" runat="server" Visible="False">
                    <asp:ListItem>Syria</asp:ListItem>
                    <asp:ListItem>Egypt</asp:ListItem>
                    <asp:ListItem>Iraq</asp:ListItem>
                    <asp:ListItem>Morocco</asp:ListItem>
                    <asp:ListItem>Algeria</asp:ListItem>
                    <asp:ListItem>Tunisia</asp:ListItem>
                    <asp:ListItem>USA</asp:ListItem>
                </asp:DropDownList>
                <br />
                <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Do it" Visible="False" Width="209px" />
                </td>
            </tr>
     
        </table>
  <asp:Repeater ID="rep" runat="server" >
         <HeaderTemplate>

             <div class="row">
             <div class="col-md-12">
                 <div class="titlepage">
                     <h2>Our Technology</h2>
                 </div>
             </div>
            </div>
             <div class="row">
         </HeaderTemplate>
         <ItemTemplate>
  <div class="col-md-3 col-sm-6">
                 <div class="Technology">
                  <img src=" <%#Eval("image") %>" height="100" width="100" />
                     <h3><%#Eval("name") %></h3>
                     <span><%#Eval("price") %> </span>
                     <a class="read_more mar_top" href="delete.aspx?id=<%#Eval("Id") %>"> Delete</a>
                 </div>
             </div>
         </ItemTemplate>
         <FooterTemplate>
          </div>
         </FooterTemplate>
     </asp:Repeater>
</asp:Content>
