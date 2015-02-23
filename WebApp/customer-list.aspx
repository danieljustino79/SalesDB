<%@ Page Title="" Language="C#" MasterPageFile="~/Masters/TemplateAuth.master" AutoEventWireup="true" CodeBehind="customer-list.aspx.cs" Inherits="WebApp.customer_list" %>
<asp:Content ID="Content1" ContentPlaceHolderID="cphHead" runat="server">
    <link href="Content/bootstrap-datetimepicker.min.css" rel="stylesheet" type="text/css" />
    <script src="Scripts/bootstrap-datetimepicker.min.js" type="text/javascript"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphForm" runat="server">
<h2>Customer List</h2>
<div class="row">
    <div class="col-md-4">
        <div class="form-group">
            <label>Name</label>
            <asp:TextBox ID="txtName" runat="server" CssClass="form-control" />
        </div>
    </div>
    <div class="col-md-4">
        <div class="form-group">
            <label>Gender</label>
            <asp:DropDownList ID="ddlGender" runat="server" CssClass="form-control" />
        </div>
    </div>
    <div class="col-md-4 ">
        <div class="form-group pull-right">
            <br />
            <asp:Button ID="Button1" runat="server" Text="Search" CssClass="btn btn-default" />
        </div>
    </div>
</div>
<div class="row">
    <div class="col-md-4">
        <div class="form-group">
            <label>City</label>
            <asp:DropDownList ID="ddlCity" runat="server" CssClass="form-control" />
        </div>
    </div>
    <div class="col-md-4">
        <div class="form-group">
            <label>Region</label>
            <asp:DropDownList ID="ddlRegion" runat="server" CssClass="form-control" />
        </div>
    </div>
    <div class="col-md-4 ">
        <div class="form-group pull-right">
            <br />
            <asp:Button ID="Button2" runat="server" Text="Clear Fields" CssClass="btn btn-default" />
        </div>
    </div>
</div>
<div class="row">
    <div class="col-md-4">
        <div class="form-group ">
        <label>Last Purchase</label>
        <div class="input-group ">
         <asp:TextBox ID="TextBox1" runat="server" CssClass="form-control datepicker" />
         <div class="input-group-addon "><span class="glyphicon glyphicon-calendar"></span></div>
        </div>
        </div>
    </div>
    <div class="col-md-4">
        <div class="form-group">
            <label>Until</label>
            <div class="input-group">
                <asp:TextBox ID="TextBox2" runat="server" CssClass="form-control datepicker" />
                <div class="input-group-addon "><span class="glyphicon glyphicon-calendar"></span></div>
            </div>
        </div>
    </div>
</div>
<div class="row">
    <div class="col-md-4" id="divSeller" runat="server" visible="false">
        <div class="form-group ">
        <label>Seller</label>
        <asp:DropDownList ID="ddlSeller" runat="server" CssClass="form-control" />
        </div>
    </div>
</div>
<div class="row">
    <div class="col-md-10">
        <asp:GridView ID="gvwCustomer" runat="server"
        CssClass="table table-bordered"
        GridLines="None"
        AutoGenerateColumns="false"
        >
        <Columns>
        <asp:BoundField DataField="Customer.Name" HeaderText="Name"  />
        <asp:BoundField DataField="Customer.Phone" HeaderText="Phone" SortExpression="Phone" />
        <asp:BoundField DataField="Customer.GenderId" HeaderText="Gender" SortExpression="GenderId" />
        <asp:BoundField DataField="City.Name" HeaderText="City"  />
        </Columns>
        </asp:GridView>
    </div>
</div>

<script>
    $(document).ready(function () {
        $('.datepicker').datepicker();
    });
</script>
</asp:Content>
