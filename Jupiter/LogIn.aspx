<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="LogIn.aspx.cs" Inherits="Jupiter.LogIn" %>
<asp:Content ID="Content1" ContentPlaceHolderID="NavBar" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PageContent" runat="server">
    <div class="container" style="margin-top:10%">
    <h2>Login</h2>
        <form runat="server" id="FormLogin">
        <!--Sign In Start-->
            <div class="form-horizontal">
                <div class="form-group">
                    <asp:Label runat="server" CssClass="col-md-2 control-label" >Email</asp:Label>
                    <div class="col-md-3">
                    <asp:TextBox runat="server" ID="TextBoxEmail" placeholder="Email" CssClass="form-control"></asp:TextBox>

                    </div>
                    </div>
                <div class="form-group">
                    <asp:Label runat="server" CssClass="col-md-2 control-label">Password</asp:Label>
                    <div class="col-md-3">
                    <asp:TextBox runat="server" placeholder="Password" ID="TextBoxPassword" CssClass="form-control"></asp:TextBox>

                    </div>
                </div>
                <div class="form-group">

                    <div class="col-md-2"></div>
                    <div class="col-md-6">
                        <asp:CheckBox ID="CheckboxRememberMe" runat="server" />
                        <asp:Label ID="LabelRememberMe" runat="server" Text="Remember Me?"></asp:Label>
                    </div>
                </div>
                 <div class="form-group">

                    <div class="col-md-2"></div>
                    <div class="col-md-6">
                    <asp:Button runat="server" Text="Enter" OnClick="ButtonEnter_Click" ID="ButtonEnter"/>
            </div>
                                         </div>
        <!--Sign In End-->
                </div>
</form>
    </div>
    
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="Footer" runat="server">
</asp:Content>
