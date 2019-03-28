<%@ Page Title="BlogSpecific" Language="C#" MasterPageFile="Site.Master" AutoEventWireup="true" CodeBehind="BlogSpecific.aspx.cs" Inherits="ArcticInteractiveASP.BlogPost" %>



<asp:Content ID="Content" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    
    <div class="jumbotron">
        
        <% %>
        <h1><% Response.Write(BlogPost.Title); %></h1>
        <h1><% Response.Write(BlogPost.Author); %></h1>
        <h2><% Response.Write(BlogPost.Date); %></h2>
        <p><% Response.Write(BlogPost.Text); %></p>
    
    </div>
    

</asp:Content>
