<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ForCarcade._Default" %>


<asp:Content runat="server" ContentPlaceHolderID="MainContent">
    
    <asp:UpdatePanel runat="server">
        <ContentTemplate>
            <div class="row">
                <div class="col-sm-12">
                    Название компании: <asp:TextBox runat="server" id="SearchCompanyNameInput"></asp:TextBox>
                    Дата платежа: <asp:TextBox runat="server" type="date" id="SearchPaymentDateInput"/>
                    <asp:Button runat="server" Text="Отфильтровать" id="FilterButton" OnClick="FilterButton_Click"/>
                </div>
            <div class="row">
                <div class="col-sm-12">
                    <asp:GridView runat="server" ID="MyGrid" OnPageIndexChanging="ChangePage" CssClass="table table-condensed table-hover">
                        <Columns>
                            <asp:BoundField  DataField="Name" HeaderText="Контрагент" 
                                             InsertVisible ="False" ReadOnly="True" SortExpression="Name" />

                            <asp:BoundField  DataField="Sum" HeaderText="Платеж" 
                                             InsertVisible ="False" ReadOnly="True" SortExpression="Sum" />

                            <asp:BoundField  DataField="Time" HeaderText="Дата платежа" 
                                             InsertVisible ="False" ReadOnly="True" SortExpression="Time" />
                        </Columns>
                    </asp:GridView>
                </div>
            </div>
        </ContentTemplate>   
    </asp:UpdatePanel>

</asp:Content>