<%@ Page Title="" Language="C#" MasterPageFile="~/Masters/Template.master" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="WebApp._default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="cphHead" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphForm" runat="server">
<br /><br /><br /><br /><br />
<p>O sistema foi desenvolvido com Visual Studio 2010, aplicando as seguintes tecnologias e padrões:</p>
<p>Asp.Net 4 com WebForms, ADO EntityFramework 4, 
Jquery 2, Bootstrap 3, SQL Server 2012 Express (o backup se encontra na pasta DOCS/ do projeto web, onde o nome da database é SalesDB)
</p>
<p>A solução esta dividida em 3 camadas: web, BLL e DAL, as connectionStrings estão definidas em 2 arquivos DAL/App.Config e WebApp/web.config</p>
</asp:Content>
