<%@ Page Title="" Language="C#" MasterPageFile="~/Masters/TemplateAuth.master" AutoEventWireup="true" CodeBehind="user.aspx.cs" Inherits="WebApp.admin.user" %>
<asp:Content ID="Content1" ContentPlaceHolderID="cphHead" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphForm" runat="server">
<h2>User</h2>
<div class="row">
    <div class="col-md-3">
        <div class="form-group">
            <label>Name</label>
            <asp:TextBox ID="txtName" runat="server" CssClass="form-control" />
        </div>
    </div>
    <div class="col-md-3">
        <div class="form-group">
            <label>Email</label>
            <asp:TextBox ID="txtEmail" runat="server" CssClass="form-control" />
        </div>
    </div>
</div>
<div class="row">
    <div class="col-md-3">
        <div class="form-group">
            <label>Password</label>
            <asp:TextBox ID="txtPassword" runat="server" CssClass="form-control" />
        </div>
    </div>
    <div class="col-md-3">
        <div class="form-group">
            <label>Level</label>
            <asp:DropDownList ID="ddlLevel" runat="server" CssClass="form-control" />
        </div>
    </div>
</div>
<div class="row">
    <div class="col-md-3">
        <asp:Button ID="btnAdd" runat="server" Text="Add" CssClass="btn btn-default" 
            onclick="btnAdd_Click" />
    </div>
</div>
<br />
<div class="row">
    <div class="col-md-10">
        <asp:GridView ID="gvwLevel" runat="server"
        CssClass="table table-bordered"
        GridLines="None"
        AutoGenerateColumns="false"
        AllowSorting="true"
        >
        <%--OnSorting="gvwLevel_Sorting"
        AllowSorting="true"
        OnPageIndexChanging="gvwLevel_PageIndexChanging"--%>
        <Columns>
        <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name" />
        </Columns>
        </asp:GridView>
    </div>
</div>
</asp:Content>
