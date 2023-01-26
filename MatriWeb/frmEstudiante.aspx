<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmEstudiante.aspx.cs" Inherits="MatriWeb.frmEstudiante" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 23px;
        }
        .auto-style2 {
            height: 23px;
            width: 132px;
        }
        .auto-style3 {
            width: 132px;
        }
        .auto-style4 {
            height: 23px;
            width: 325px;
        }
        .auto-style5 {
            width: 325px;
        }
        .auto-style6 {
            margin-left: 3px;
        }
        .auto-style7 {
            margin-left: 6px;
        }
        .auto-style8 {
            width: 132px;
            height: 26px;
        }
        .auto-style9 {
            width: 325px;
            height: 26px;
        }
        .auto-style10 {
            height: 26px;
        }
    </style>
    <link href="~/StyleMenu.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div id ="menu">
            <div>
                <ul>
                    <li><a href="frmProfesor.aspx">Profesor</a></li>
                </ul>
                <ul>
                    <li><a href="frmMatricula.aspx">Matricula</a></li>
                </ul>
                <ul>
                    <li><a href="frmGrupo.aspx">Grupo</a></li>
                </ul>
                <ul>
                    <li><a href="frmAula.aspx">Aula</a></li>
                </ul>
                <ul>
                    <li><a href="frmCurso.aspx">Curso</a></li>
                </ul>
                <ul>
                    <li><a href="frmHorario.aspx">Horario</a></li>
                </ul>
            </div>
        </div>
        <table style="width:100%;">
            <tr>
                <td class="auto-style2">
                    &nbsp;</td>
                <td class="auto-style4">
                    &nbsp;</td>
                <td class="auto-style1">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">
                    &nbsp;</td>
                <td class="auto-style4">
                    <asp:Label ID="Label3" runat="server" Text="Formulario de Estudiante"></asp:Label>
                </td>
                <td class="auto-style1">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">
                    &nbsp;</td>
                <td class="auto-style4">
                    &nbsp;</td>
                <td class="auto-style1">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="Label1" runat="server" Text="Grupo_id:"></asp:Label>
                </td>
                <td class="auto-style4">
                    <asp:DropDownList ID="ddlGrupo" runat="server" Height="16px" Width="130px">
                    </asp:DropDownList>
                </td>
                <td class="auto-style1"></td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="Label2" runat="server" Text="Cedula:"></asp:Label>
                </td>
                <td class="auto-style4">
                    <asp:TextBox ID="txtEstudiante_cedula" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style1"></td>
            </tr>
            <tr>
                <td class="auto-style3">Nombre:</td>
                <td class="auto-style5">
                    <asp:TextBox ID="txtEstudiante_nombre" runat="server"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">Primer Apellido:</td>
                <td class="auto-style5">
                    <asp:TextBox ID="txtEstudiante_primerApellido" runat="server"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">Segundo Apellido:</td>
                <td class="auto-style5">
                    <asp:TextBox ID="txtEstudiante_segundoApellido" runat="server"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style8">Telefono:</td>
                <td class="auto-style9">
                    <asp:TextBox ID="txtEstudiante_telefono" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style10"></td>
            </tr>
            <tr>
                <td class="auto-style3">Email:</td>
                <td class="auto-style5">
                    <asp:TextBox ID="txtEstudiante_correoElectronico" runat="server"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">Dirección:</td>
                <td class="auto-style5">
                    <asp:TextBox ID="txtEstudiante_direccion" runat="server"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style5">
                    <asp:Button ID="btnInsertar" runat="server" OnClick="btnInsertar_Click" Text="Insertar" Width="87px" />
                &nbsp;<asp:Button ID="btnEliminar" runat="server" CssClass="auto-style6" OnClick="btnEliminar_Click" Text="Eliminar" Width="87px" />
                    <asp:Button ID="btnModificar" runat="server" CssClass="auto-style7" OnClick="btnModificar_Click" Text="Modificar" Width="87px" />
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style5">
                    <asp:Label ID="lblSuccessMessage" runat="server" ForeColor="Green"></asp:Label>
                </td>
                <td>&nbsp;</td>
            </tr>
        </table>
        <br />
        <asp:GridView ID="dgvEstudiante" runat="server" OnRowDataBound="dgvEstudiante_RowDataBound" Width="773px" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3">
        
            <Columns>
                <asp:TemplateField>
                    <ItemTemplate>
                        <asp:LinkButton ID="lnkView" runat="server" CommandArgument='<%# Eval("Estudiante_id") %>' OnClick="lnk_OnClick">View</asp:LinkButton>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        
            <FooterStyle BackColor="White" ForeColor="#000066" />
            <HeaderStyle BackColor="#006699" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Left" />
            <RowStyle ForeColor="#000066" />
            <SelectedRowStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F1F1F1" />
            <SortedAscendingHeaderStyle BackColor="#007DBB" />
            <SortedDescendingCellStyle BackColor="#CAC9C9" />
            <SortedDescendingHeaderStyle BackColor="#00547E" />
        
        </asp:GridView>
        
        <br />
    </form>
</body>
</html>
