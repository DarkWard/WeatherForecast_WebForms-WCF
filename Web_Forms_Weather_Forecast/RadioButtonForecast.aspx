<%@ Page Title="Radio Buttons" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="RadioButtonForecast.aspx.cs" Inherits="Web_Forms_Weather_Forecast.RadioButtonForecast" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Overline="False" Font-Size="Large" Font-Strikeout="False" Height="30px" Text="Choose forecast period" Width="200px"></asp:Label>
    <br />
    <asp:RadioButtonList ID="RBList" runat="server" Height="78px" Width="78px">
        <asp:ListItem Selected="True" Value=1>1 Day</asp:ListItem>
        <asp:ListItem Value=7>7 Days</asp:ListItem>
        <asp:ListItem Value=30>30 Days</asp:ListItem>
    </asp:RadioButtonList><br />
    
    <asp:Button ID="GetWeather" runat="server" Text="Predict Weather" OnClick="GetForecast" />
    <br /><br />
    
    <asp:CheckBox ID="ChBFeelings" runat="server" Text="Include Feelings" /> <br />
    <asp:ListBox ID="ForecastList" runat="server" Height="350px" Width="100%"></asp:ListBox> <br />

</asp:Content>

