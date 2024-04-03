<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FillingForm.aspx.cs" Inherits="Task01.Register.FillingForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Filling Form</title>
    <style type="text/css">

        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 206px;
        }
        .auto-style3 {
            width: 206px;
            text-align: center;
            height: 21px;
        }
        .auto-style4 {
            width: 206px;
            height: 23px;
        }
        </style>
</head>
<body>
    <form id="FillingForm" runat="server">
        <div>
               <table class="auto-style1">
            <tr>
                <td class="auto-style3" colspan="2" style="background-color: #FFFFFF; color: #000000; font-weight: bold">Đăng ký khách hàng</td>
            </tr>
            <tr>
                <td class="auto-style2" colspan="2" style="color: #FFFFFF; background-color: #0000FF; font-weight: bold;">Thông tin đăng nhập</td>
            </tr>
            <tr>
                <td class="auto-style4">Username</td>
                <td style="color: #FF0000">
                    <asp:TextBox ID="txtUsername" runat="server" Width="690px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rf_Username" runat="server" ControlToValidate="txtUsername" ErrorMessage="The username must be not emtpy">(*)</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Password</td>
                <td style="color: #FF0000">
                    <asp:TextBox ID="txtPassword" runat="server" Width="690px" TextMode="Password"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rf_Password" runat="server" ControlToValidate="txtPassword" ErrorMessage="Password must be not empty">(*)</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Re-Passsword</td>
                <td style="color: #FF0000">
                    <asp:TextBox ID="txtRepassword" runat="server" Width="690px" TextMode="Password"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rf_RePassword" runat="server" ControlToValidate="txtRePassword" ErrorMessage="Re-Password must be not empty">(*)</asp:RequiredFieldValidator>
                    <asp:CompareValidator ID="cv_Repassword" runat="server" ControlToCompare="txtPassword" ControlToValidate="txtRePassword" ErrorMessage="Re-password does not match password/">(*)</asp:CompareValidator>
                </td>
            </tr>
        </table>
        <br />
             <table class="auto-style1">
            <tr>
                <td class="auto-style2" colspan="2" style="color: #FFFFFF; background-color: #0000FF; font-weight: bold;">Customer Detials</td>
            </tr>
            <tr>
                <td class="auto-style4">CustomerName</td>
                <td style="color: #FF0000">
                    <asp:TextBox ID="txtCustomerName" runat="server" Width="690px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rf_CustomerName" runat="server" ControlToValidate="txtCustomerName" ErrorMessage="Customer name must be not empty">(*)</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Birthdate</td>
                <td style="color: #FF0000">
                    <asp:TextBox ID="txtBirthDate" runat="server" Width="690px" TextMode="Date"></asp:TextBox>
                    <asp:CompareValidator ID="cv_BirthDate" runat="server" ControlToValidate="txtBirthDate" ErrorMessage="Invalid birthdate" Operator="DataTypeCheck" Type="Date">(*)</asp:CompareValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Gender</td>
                <td>
                    <asp:RadioButton ID="radMale" runat="server" Text="Male" GroupName="gender" OnCheckedChanged="radMale_CheckedChanged" />
                    <asp:CustomValidator ID="cv_gender" runat="server" ErrorMessage="Gender can not be empty" OnServerValidate="cv_gender_ServerValidate" style="color: #FF0000">(*)</asp:CustomValidator                   
                    <asp:RadioButton ID="radFemale" runat="server" Text="Female" GroupName="gender" OnCheckedChanged="radFemale_CheckedChanged" />  
                    
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Email</td>
                <td style="color: #FF0000">
                    <asp:TextBox ID="txtEmail" runat="server" Width="690px"></asp:TextBox>
                    <asp:RegularExpressionValidator ID="revEmail" runat="server" ControlToValidate="txtEmail" ErrorMessage="Email must be not empty" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*">(*)</asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Income</td>
                <td style="color: #FF0000">
                    <asp:TextBox ID="txtIncome" runat="server" Width="690px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rveIncome" runat="server" ControlToValidate="txtIncome" ErrorMessage="Income must be not empty">(*)</asp:RequiredFieldValidator>                    
                    <asp:RangeValidator ID="rvIncome" runat="server" ControlToValidate="txtIncome" ErrorMessage="Income from 1 million to 50 million vnd" MaximumValue="50000000" MinimumValue="1000000">(*)</asp:RangeValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style3" colspan="2" style="background-color: #FFFFFF; color: #000000; font-weight: bold">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3" colspan="2" style="background-color: #FFFFFF; color: #000000; font-weight: bold">
                    <asp:Button ID="btnRegister" runat="server" Text="Register" OnClick="btnRegister_Click" />
                </td>
            </tr>
            <tr>
                <td class="auto-style3" colspan="2">
                    <asp:Label ID="lblNotification" runat="server"></asp:Label>
                </td>
            </tr>
        </table>
        <asp:ValidationSummary style="color: #FF0000; text-align: center;" ID="vsTonghop" runat="server" HeaderText="Validation error list" />
        <br />
        </div>
    </form>
</body>
</html>
