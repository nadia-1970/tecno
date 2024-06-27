<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="SVU_ITE_Bwp401_F23_c3.WebForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="c1" runat="server">
    <asp:Repeater ID="rep" runat="server" OnItemCommand="rep_ItemCommand">
        <HeaderTemplate>
            <h1>Description</h1>

        </HeaderTemplate>
        <ItemTemplate>
            <div style="height: 300px; width: 600px; border-width: 0px;">
                <div style="height: 300px; width: 200px; border-style: solid; border-width: 1px; float: left">
                    <img src="<%# Eval("image") %>" height="300px" width="200px" />
                </div>
                <div style="height: 300px; width: 395px; border-style: solid; border-width: 1px; float: left">
                    Product name:<%# Eval("name") %><br />Description : <%# Eval("desc") %><br />
                    Price : <%# Eval("price") %><br />
                </div>
            </div>
        </ItemTemplate>
        <FooterTemplate>
        </FooterTemplate>
    </asp:Repeater>
<asp:Button ID="addtocart" runat="server" OnClick="addtocart_Click" Text="Add To Cart" Width="154px" />
<br />
    

    
</asp:Content>
