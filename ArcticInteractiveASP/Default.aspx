<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>



<asp:Content ID="HomePagemain" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <link rel="stylesheet" href="/Content/bootstrap.css" />
    <link rel="stylesheet" href="/Content/Site.css">
      
    <div class="HomePage-main">
    
        <h1>Arctic Interactive</h1>
        <p class="lead">Interactive, Arctic-Cool Games</p>
        <img src ="/images/arctic_logo.png" class="ArcticLogo" alt="Arctic Interactive" />
        <p><a href="http://www.asp.net" class="btn btn-primary btn-lg">Learn more &raquo;</a></p>

       
    </div>

     <script>
$(document).ready(function() {
        // Transition effect for navbar 
        $(window).scroll(function() {
          // checks if window is scrolled more than 1px, adds/removes solid class
          if($(this).scrollTop() > 1) { 
              alert("the navbar is now solid!")
              $('.navbar').addClass('.solid');              
          } else {
              $('.navbar').removeClass('.solid');
          }
        });
});
</script>

    <script>    
        $(document).scroll(function () {
            $('.navbar').toggleClass('.solid', $(this).scrollTop() > 100);
        });
    </script>
  
</asp:Content>


