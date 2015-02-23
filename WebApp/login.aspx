<%@ Page Title="" Language="C#" MasterPageFile="~/Masters/Template.master" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="WebApp.login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="cphHead" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphForm" runat="server">

<div class="row" style="margin-top:14%">
    <div class="col-md-6 col-md-offset-3 well">
    
    <div class="row" style="padding:0 50px">
    <div class="alert alert-warning alert-dismissible" id="divAlert" style="display:none;" >
        <asp:Label ID="lbAlert" runat="server" />
    </div>
    </div>
    <div class="row" style="padding:0 50px">
    <div class="alert alert-info alert-dismissible" id="divInfo" style="display:none;" >
        <asp:Label ID="lbInfo" runat="server" />
    </div>
    </div>
    <div class="row">
    <div class="col-md-10 col-md-offset-1">
        <div class="form-group">
            <label>Email</label>
            <asp:TextBox ID="txtName" runat="server" CssClass="form-control" />
        </div>
    </div>
</div>
<div class="row">
    <div class="col-md-10 col-md-offset-1">
        <div class="form-group">
            <label>Password</label>
            <asp:TextBox ID="txtPassword" runat="server" CssClass="form-control" TextMode="Password" />
        </div>
    </div>
</div>
<div class="row">
    <div class="col-md-10 col-md-offset-1">
        <div class="form-group">
            <asp:Button ID="btnLogin" runat="server" Text="Login" CssClass="btn btn-default" 
            onclick="btnLogin_Click" />
        </div>
    </div>
</div>
    
    
    </div>
</div>

<script>
    $(document).ready(function () {
        if (GetQueryStringBool('error') == true)
            $('#divAlert').show();
        else if (GetQueryStringBool('info') == true)
            $('#divInfo').show();
    });
</script>

</asp:Content>