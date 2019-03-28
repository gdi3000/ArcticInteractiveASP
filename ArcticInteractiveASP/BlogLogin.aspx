<%@ Page Title="BlogSpecific" Language="C#" MasterPageFile="Site.Master" AutoEventWireup="true" CodeBehind="BlogLogin.aspx.cs" Inherits="FridaiDKv2.BlogLogin" %>

<asp:Content ID="Content" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <div class="container">
        <div class="d-flex justify-content-center h-100">
            <div class="card">
                <div class="card-header">
                    <h3>Sign In</h3>
                    
                </div>
                <div class="card-body">
                    <form>
                        <div class="input-group form-group">
                            <div class="input-group-prepend">
                                <span class="input-group-text"><i class="fas fa-user"></i></span>
                            </div>
                            <input type="text" id="user" name="user" class="form-control" placeholder="username">
						
                        </div>
                        <div class="input-group form-group">
                            <div class="input-group-prepend">
                                <span class="input-group-text"><i class="fas fa-key"></i></span>
                            </div>
                            <input id="pass" name="pass" type="password" class="form-control" placeholder="pwdHash">
                        </div>
                        <div class="row align-items-center remember">
                            <input type="checkbox">Remember Me
                        </div>
                        <div class="form-group">
                            <input type="submit" onclick="" value="Login" class="btn float-right login_btn">
                            <asp:Button Text="login asp" runat="server" OnClick="Clicked"/>
                        </div>
                    </form>
                </div>
                <div class="card-footer">
                    
                </div>
            </div>
        </div>
    </div>
</asp:Content>
