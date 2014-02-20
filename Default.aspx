<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Default.aspx.vb" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    
        <div>
    <h1> Salary Calculator </h1>
            <p> Hours:
                <asp:TextBox ID="HoursTB" runat="server"></asp:TextBox>
            </p>
            <p> Wage:
                <asp:TextBox ID="WageTB" runat="server"></asp:TextBox>
            </p>
            <p> Pre Tax:
                <asp:TextBox ID="PreTaxTB" runat="server"></asp:TextBox>
            </p>
            <p> Post Tax Deductions:
                <asp:TextBox ID="PostTaxTB" runat="server"></asp:TextBox>
            </p>
            <p> Net Pay: <asp:Label ID="NetPayLB" runat="server"></asp:Label>
            </p>
            <p> 
                <asp:Button ID="SubmitButton" runat="server" Text="Submit" Width="80px" />
&nbsp;
                <asp:Button ID="ClearButton" runat="server" Text="Clear" Width="80px" />
            </p>
    
        
        
        
        </div>
    
    
    
    
    </form>
</body>
</html>
