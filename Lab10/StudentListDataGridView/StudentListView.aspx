<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StudentListView.aspx.cs" Inherits="StudentListDataGridView.StudentListView" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<style>
    .gridview th {
    padding: 8px; /* Add padding to the header cells */
    }

    .gridview td {
        padding: 8px; /* Add padding to the data cells */
    }

    .pagination {
        padding: 0px;
        background-color: rgb(0, 141, 218);
        color: white;
        text-align: -webkit-center;
    }
</style>
<body>
    <form id="form1" runat="server">
        <h1>Student name list</h1>
        <asp:GridView ID="GridView" runat="server" AutoGenerateColumns="False" GridLines="None" Width="100%" OnRowDataBound="GridView_RowDataBound" OnRowCreated="GridView_RowCreated" OnRowDeleting="GridView_RowDeleting" AllowPaging="true" OnPageIndexChanging="grdSV_OnPageIndexChanging" PageSize="5" CssClass="gridview" OnRowCancelingEdit="GridView_RowCancelingEdit" OnRowEditing="GridView_RowEditing" OnRowUpdating="GridView_RowUpdating" OnSelectedIndexChanged="GridView_SelectedIndexChanged">
            <Columns>
                <asp:TemplateField SortExpression="Action">
                    <ItemTemplate>
                        <asp:LinkButton ID="Edit" runat="server" CausesValidation="False" CommandName="Edit" Text="Edit"></asp:LinkButton>
                        <asp:LinkButton ID="Delete" runat="server" CausesValidation="False" CommandName="Delete" Text="Delete"></asp:LinkButton>
                        <asp:LinkButton ID="Select" runat="server" CausesValidation="False" CommandName="Select" Text="Select"></asp:LinkButton>
                    </ItemTemplate>
                    <EditItemTemplate>
                        <asp:LinkButton ID="Update" runat="server" CausesValidation="True" CommandName="Update" Text="Update"></asp:LinkButton>
                        <asp:LinkButton ID="Cancel" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancel"></asp:LinkButton>
                    </EditItemTemplate>
                </asp:TemplateField>
            
                <asp:TemplateField HeaderText="Student Id" SortExpression="StudentId" >
                    <ItemTemplate>
                        <asp:Label ID="LabelStudentId" runat="server" Text='<%# Eval("StudentId") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>

                <asp:TemplateField HeaderText="Student Name" SortExpression="StudentName">
                    <ItemTemplate>
                        <asp:Label ID="LabelStudentName" runat="server" Text='<%# Eval("StudentName") %>'></asp:Label>
                    </ItemTemplate>
                    <EditItemTemplate>
                        <asp:TextBox ID="TextBoxStudentName" runat="server" Text='<%# Bind("StudentName") %>'></asp:TextBox>
                    </EditItemTemplate>
                </asp:TemplateField>

                <asp:TemplateField HeaderText="Gender" SortExpression="Gender">
                    <ItemTemplate>
                        <asp:CheckBox ID="CheckBoxGender" runat="server" />
                    </ItemTemplate>
                </asp:TemplateField>
                
                <asp:TemplateField HeaderText="Class Name" SortExpression="ClassName">
                    <ItemTemplate>
                        <asp:Label ID="LabelClassName" runat="server" Text='<%# Eval("ClassName") %>'></asp:Label>
                    </ItemTemplate>
                    <EditItemTemplate>
                        <asp:TextBox ID="TextBoxClassName" runat="server" Text='<%# Bind("ClassName") %>'></asp:TextBox>
                    </EditItemTemplate>
                </asp:TemplateField>
          
            </Columns>
            <PagerStyle CssClass="pagination" />
            <HeaderStyle BackColor="#6699FF" ForeColor="White" BorderStyle="None" HorizontalAlign="Left" />
        </asp:GridView>
    </form>

</body>
</html>