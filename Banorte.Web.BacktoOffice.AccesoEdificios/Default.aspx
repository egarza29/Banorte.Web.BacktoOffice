<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Banorte.Web.BacktoOffice.AccesoEdificios.Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    <br />
    <br />
    <br />
    <div>
        <div class="col-lg-12" >
            <h3 style="color:white;">
               <font face="Verdana">Logon Page</font>
            </h3>
    
<table>
   <tr>
      <td style="color:white;">Email:</td>
      <td ><input  id="txtUserName" type="text" runat="server"></td>
      <td><ASP:RequiredFieldValidator ControlToValidate="txtUserName"
           Display="Static" ErrorMessage="*" runat="server" 
           ID="vUserName" /></td>
   </tr>
   <tr>
      <td style="color:white;">Password:</td>
      <td><input id="txtUserPass" type="password" runat="server"></td>
      <td><ASP:RequiredFieldValidator ControlToValidate="txtUserPass"
          Display="Static" ErrorMessage="*" runat="server" 
          ID="vUserPass" />
      </td>
   </tr>
   <tr>
      <td style="color:white;">Persistent Cookie:</td>
      <td style="color:white;"><ASP:CheckBox id="chkPersistCookie" runat="server" autopostback="false" /></td>
      <td ></td>
   </tr>
</table>
<asp:Button ID="BtnLogin" runat="server" Text="Login"  CssClass="btn btn-lg btn-info" OnClick="BtnLogin_Click"/><p></p>
<asp:Label id="lblMsg" ForeColor="red" Font-Name="Verdana" Font-Size="10" runat="server" />
            
        </div>
    </div>

    
</asp:Content>
