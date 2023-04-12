<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="promedios.aspx.cs" Inherits="p2.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Promedios por depto</title>
    <style>
        /* Estilo para el encabezado de la tabla */
        th {
            background-color: #007bff;
            color: white;
            font-weight: bold;
            text-align: center;
            padding: 10px;
        }
        /* Estilo para las celdas de la tabla */
        td {
            text-align: center;
            padding: 10px;
        }
        /* Estilo para las filas pares */
        tr:nth-child(even) {
            background-color: #f2f2f2;
        }
        /* Estilo para el enlace "Volver" */
        a {
            display: inline-block;
            padding: 10px;
            margin-top: 20px;
            background-color: #007bff;
            color: white;
            text-decoration: none;
            border-radius: 5px;
            transition: background-color 0.3s ease;
        }
        /* Estilo para el enlace "Volver" al pasar el mouse por encima */
        a:hover {
            background-color: #0069d9;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="lblBienvenida" runat="server" Text=""></asp:Label>
        <div>
           <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" Width="1128px">
                <Columns>
                    <asp:BoundField DataField="chuquisaca" HeaderText="Chuquisaca" />
                    <asp:BoundField DataField="lapaz" HeaderText="La Paz" />
                    <asp:BoundField DataField="cochabamba" HeaderText="Cochabamba" />
                    <asp:BoundField DataField="oruro" HeaderText="Oruro" />
                    <asp:BoundField DataField="potosi" HeaderText="Potosi" />
                    <asp:BoundField DataField="tarija" HeaderText="Tarija" />
                    <asp:BoundField DataField="santacruz" HeaderText="Santa Cruz" />
                    <asp:BoundField DataField="beni" HeaderText="Beni" />
                    <asp:BoundField DataField="pando" HeaderText="Pando" />
                    <asp:BoundField DataField="otro" HeaderText="Otro" />
                </Columns>
            </asp:GridView>
        </div>
        <a href="index.aspx">Volver</a>
    </form>
</body>
</html>
