<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Web_Forms_Weather_Forecast._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <asp:Button ID="OneDayForecastButton" runat="server" Height="39px" Text="1 Day Forecast" OnClick="GetOneDayForecast" />

    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="SevenDaysForecastButton" runat="server" Height="39px" Text="7 Days Forecast" OnClick="GetSevenDayForecast" />

    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="ThirtyDaysForecastButton" runat="server" Height="39px" Text="30 Days Forecast" OnClick="GetThirtyDaysDayForecast" />

    <br />

    <asp:ListBox ID="ForecastList" runat="server" Height="350px" Width="100%"></asp:ListBox>

    <br />
    
</asp:Content>
