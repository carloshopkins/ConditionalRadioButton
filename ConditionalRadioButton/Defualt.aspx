<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Defualt.aspx.cs" Inherits="ConditionalRadioButton.Defualt" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
        <p>
            What is your note taking preference?\</p>
        <p>
            <asp:RadioButton ID="penRadio" runat="server" GroupName="notes" Text="Pen" />
        </p>
        <p>
            <asp:RadioButton ID="pencilRadio" runat="server" GroupName="notes" Text="Pencil" />
        </p>
        <p>
            <asp:RadioButton ID="laptopRadio" runat="server" GroupName="notes" Text="Laptop" />
        </p>
        <p>
            <asp:RadioButton ID="tabletRadio" runat="server" GroupName="notes" Text="Tablet" />
        </p>
        <asp:Button ID="submitButton" runat="server" Text="Submit" OnClick="submitButton_Click" />
        <br />
        <br />
        <asp:Label ID="resultLabel" runat="server"></asp:Label>
        <br />
        <br />
        <asp:Image ID="resultImage" runat="server" />
    </form>
</body>
</html>
