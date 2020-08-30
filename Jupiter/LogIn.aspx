<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="LogIn.aspx.cs" Inherits="Jupiter.LogIn" %>

<asp:Content ID="Content2" ContentPlaceHolderID="PageContent" runat="server">
    
    <form runat="server" id="FormLogin">
        <div class="container"style="margin-top:20%">
            <h2>Login</h2>
    <div class="form-horizontal">
        <div class="form-group">
            <asp:Label runat="server" CssClass="control-label alert-danger" Text=" " ID="LabelWarning"></asp:Label>
        </div>
        <div class="from-group">
            <asp:Label CssClass="col-md-2 control-label" runat="server" Text="Email"></asp:Label>
            <div class="col-md-3">
                <asp:TextBox runat ="server" CssClass="form-control" ID="TextBoxEmail"></asp:TextBox>
            </div>

        </div>
        <div class="form-group">
             <asp:Label CssClass="col-md-2 control-label" runat="server">Password</asp:Label>
            <div class="col-md-3">
                <asp:TextBox runat ="server" CssClass="form-control" ID="TextBoxPassword"></asp:TextBox>
            </div>
        </div>
        <div class="form-group">
            <div class="col-md-2"></div>
            <asp:CheckBox runat="server"  ID="CheckBoxRememberPassword" Checked="false"/>
            <asp:Label runat="server" CssClass="control-label">Rmember me?</asp:Label>
            </div>
        </div>
        <div class="form-group">
            <div class="col-md-2"></div>
            <div class="col-md-6">
            <asp:Button runat="server" ID="ButtonEnter"  CssClass="btn btn-success btn-lg" OnClick="ButtonEnter_Click" Text="Enter"/>

            </div>

            
        </div>
        </div>
    
    
    </form>

</asp:Content>

