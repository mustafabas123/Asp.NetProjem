<%@ Page Title="" Language="C#" MasterPageFile="~/AnaSayfa.Master" AutoEventWireup="true" CodeBehind="OgrenciGuncelle.aspx.cs" Inherits="YazOkuluProjesi.OgrenciGuncelle" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <form id="Form1" runat="server">
        <div class="form-group ml-5 mr-5">
            <div>
                <asp:Label ID="Label6" runat="server" Text="Öğrenci id"></asp:Label>
                <asp:TextBox ID="TxtOgrenciId" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
           <br /> 
            <div>
                <asp:Label ID="Label1" runat="server" Text="Öğrenci Ad"></asp:Label>
                <asp:TextBox ID="TxtOgrenciAd" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <br />
            <div>
                <asp:Label ID="Label2" runat="server" Text="Öğrenci Soyad"></asp:Label>
                <asp:TextBox ID="TxtOgrenciSoyad" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <br />
            <div>
                <asp:Label ID="Label3" runat="server" Text="Öğrenci Foto"></asp:Label>
                <asp:TextBox ID="TxtOgrenciFoto" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <br />
            <div>
                <asp:Label ID="Label4" runat="server" Text="Öğrenci Numara"></asp:Label>
                <asp:TextBox ID="TxtOgrenciNumara" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <br />
            <div>
                <asp:Label ID="Label5" runat="server" Text="Öğrenci Şifre"></asp:Label>
                <asp:TextBox ID="TxtOgrenciSifre" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
        </div>
        <div class="text-center">
            <asp:Button ID="Button1" runat="server" Text="Güncelle" CssClass="btn btn-info pl-5 pr-5" OnClick="Button1_Click" />
        </div>
    </form>
</asp:Content>
