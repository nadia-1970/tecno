<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="SVU_ITE_Bwp401_F23_c3.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="c1" runat="server">
     <asp:Repeater ID="rep" runat="server" OnItemCommand="rep_ItemCommand">

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
         <div class="Technology">
                     <img src="<%#Eval("image") %>" alt="#" />
                     <h3><%#Eval("price") %></h3>
                     <span> <%#Eval("desc") %>  </span>
                  <a class="read_more mar_top" href="WebForm2.aspx?id=<%# Eval("Id") %>"> More Info</a>
                 </div>
     </ItemTemplate>
     <FooterTemplate>
         </div>
     </FooterTemplate>
 </asp:Repeater>
</asp:Content>
