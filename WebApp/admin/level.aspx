<%@ Page Title="" Language="C#" MasterPageFile="~/Masters/TemplateAuth.master" AutoEventWireup="true" CodeBehind="level.aspx.cs" Inherits="WebApp.admin.level" %>
<asp:Content ID="Content1" ContentPlaceHolderID="cphHead" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphForm" runat="server">
    <h2>Level</h2>
<div class="row">
    <div class="col-md-3">
        <div class="form-group">
            <label>Name</label>
            <asp:TextBox ID="txtName" runat="server" CssClass="form-control" />
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
        OnSorting="gvwLevel_Sorting"
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
