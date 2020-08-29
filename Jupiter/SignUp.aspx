<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="SignUp.aspx.cs" Inherits="Jupiter.SignUp" %>

<asp:Content ID="Content2" ContentPlaceHolderID="PageContent" runat="server">
    

   <div class="container" style="margin-top:10%">
       <p class="col-lg-10">Sign Up</p>
       <form id="FormSignUp" runat="server">
           <asp:Label ID="LabelWarningMessage" runat="server"></asp:Label>
           <label class="col-xs-11">First Name:</label>
           <asp:TextBox ID="TextBoxFirstName" runat="server" CssClass="form-control" placeholder="First Name"></asp:TextBox>
           <label  class="col-xs-11">Last Name:</label>
           <asp:TextBox ID="TextBoxLastName" runat="server" CssClass="form-control" placeholder="Last Name"></asp:TextBox>
           <label  class="col-xs-11">Email:</label>
           <asp:TextBox ID="TextBoxEmail" runat="server" CssClass="form-control" placeholder="Email"></asp:TextBox>
           <label  class="col-xs-11">Password:</label>
           <asp:TextBox ID="TextBoxPassword" runat="server" CssClass="form-control" placeholder="Password"></asp:TextBox>
           <label  class="col-xs-11">Confrim Password:</label>
            <asp:TextBox ID="TextBoxConfirmPassword" runat="server" CssClass="form-control" placeholder="Confirm Password"></asp:TextBox>
           <br />
           <asp:Button runat="server" Text="Submit" CssClass="btn btn-success btn-lg" OnClick="Button_OnClick_Submit" ID="Button_Submit" />
           

       </form>

   </div>
    
</asp:Content>
