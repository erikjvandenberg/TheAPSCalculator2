<%@ Page Language="C#" AutoEventWireup="true" CodeFile="myResults.aspx.cs" Inherits="myResults" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Maths6"></asp:Label>
            <br /><input id="myMaths" runat="server" type="text" /><br />
            <asp:Label ID="Label2" runat="server" Text="English"></asp:Label>
            <br /><input id="myEnglish" runat="server" type="text" /><br />
            <asp:Label ID="Label3" runat="server" Text="Physical Sciences"></asp:Label>
            <br /><input id="myPhysicalSciences" runat="server" type="text" />
            <br /><asp:Button ID="doCalculations" runat="server" Text="Calculate" OnClick="doCalculations_Click" />
        </div>
    </form>
</body>
</html>
