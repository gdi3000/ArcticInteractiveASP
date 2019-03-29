<%@ Page Title="Blog" Language="C#" MasterPageFile="Site.Master" AutoEventWireup="true" CodeBehind="Blog.aspx.cs" Inherits="ArcticInteractiveASP.Blog" %>

<asp:Content runat="server" ContentPlaceHolderID="head">
   
 
    
    <script src="/Public/Js/ChangeToSpecificBlog.js"></script>
</asp:Content>

<asp:Content ID="Content" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    
    
   
     <div>
         <ul>
             <%
                
                 foreach (var post in BlogPosts)
                 {
                     Response.Write($"<li class=\"row jumbotron\"> {post.Title}" +
                                    $"<button type=\"button\" onclick=\"ChangePage({post.IdBlog})\"> Click here to read</button> " +
                                    $"</li>");
                 }

             %> 
                     
             
        
             
       
       </ul>
     </div>
    

</asp:Content>

