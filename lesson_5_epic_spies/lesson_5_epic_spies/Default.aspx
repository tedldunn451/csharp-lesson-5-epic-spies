<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="lesson_5_epic_spies.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Image ID="spyImage" runat="server" Height="190px" ImageUrl="epic-spies-logo.jpg" />
            <br />
            <br />
            <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Names="Arial" Font-Overline="False" Font-Size="X-Large" Text="Spy New Assignment Form"></asp:Label>
            <br />
            <br />
            Spy Code Name: <asp:TextBox ID="codeNameTextBox" runat="server"></asp:TextBox>
            <br />
            <br />
            New Assignment Name:
            <asp:TextBox ID="assignmentNameTextBox" runat="server"></asp:TextBox>
            <br />
            <br />
            End Date of Previous Assignment:<asp:Calendar ID="endPreviousCalendar" runat="server"></asp:Calendar>
            <br />
            <br />
            Start Date of New Assignment:<asp:Calendar ID="startNewCalendar" runat="server"></asp:Calendar>
            <br />
            <br />
            Projected End Date of New Assignment:<asp:Calendar ID="endNewCalendar" runat="server"></asp:Calendar>
            <br />
            <br />
            <asp:Button ID="assignButton" runat="server" OnClick="assignButton_Click" Text="Assign Spy" />
            <br />
            <br />
            <asp:Label ID="resultLabel" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
