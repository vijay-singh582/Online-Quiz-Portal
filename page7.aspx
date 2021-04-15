<%@ Page Title="" Language="C#" MasterPageFile="~/page4.master" AutoEventWireup="true" CodeFile="page7.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style5
        {
            width: 455px;
        font-weight: 700;
    }
        .style20
        {
            width: 224px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;
<asp:Label ID="Label5" runat="server" Font-Size="XX-Large" 
    ForeColor="DarkTurquoise" Text="Update Details"></asp:Label>
<p style="color: #FFFF99; background-color: #00CED1; width: 1320px; height: 25px; font-weight: bold;">
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Update Students Details</p>
    <p>
    <table cellpadding="5px">
    <tr>
    <td class="style5">
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
            CellPadding="4" DataKeyNames="Student_ID" DataSourceID="SqlDataSource1" 
            ForeColor="#333333" GridLines="None" Height="278px" 
            onselectedindexchanged="GridView1_SelectedIndexChanged" Width="701px" 
            onrowdeleted="GridView1_RowDeleted">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:BoundField DataField="Student_ID" HeaderText="Student_ID" ReadOnly="True" 
                    SortExpression="Student_ID">
                <ItemStyle HorizontalAlign="Center" />
                </asp:BoundField>
                <asp:BoundField DataField="Student_Name" HeaderText="Student_Name" 
                    SortExpression="Student_Name">
                <ItemStyle HorizontalAlign="Center" />
                </asp:BoundField>
                <asp:BoundField DataField="S_Password" HeaderText="S_Password" 
                    SortExpression="S_Password">
                <ItemStyle HorizontalAlign="Center" />
                </asp:BoundField>
                <asp:BoundField DataField="Email_ID" HeaderText="Email_ID" 
                    SortExpression="Email_ID">
                <ItemStyle HorizontalAlign="Center" />
                </asp:BoundField>
                <asp:CommandField HeaderText="Select_Row" ShowDeleteButton="True" 
                    ShowSelectButton="True">
                <ItemStyle HorizontalAlign="Center" />
                </asp:CommandField>
            </Columns>
            <EditRowStyle BackColor="#2461BF" />
            <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#EFF3FB" />
            <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#F5F7FB" />
            <SortedAscendingHeaderStyle BackColor="#6D95E1" />
            <SortedDescendingCellStyle BackColor="#E9EBEF" />
            <SortedDescendingHeaderStyle BackColor="#4870BE" />
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
            ConnectionString="<%$ ConnectionStrings:QuizConnectionString3 %>" 
            DeleteCommand="DELETE FROM [Student] WHERE [Student_ID] = @Student_ID" 
            InsertCommand="INSERT INTO [Student] ([Student_ID], [Student_Name], [S_Password], [Email_ID]) VALUES (@Student_ID, @Student_Name, @S_Password, @Email_ID)" 
            SelectCommand="SELECT * FROM [Student]" 
            UpdateCommand="UPDATE [Student] SET [Student_Name] = @Student_Name, [S_Password] = @S_Password, [Email_ID] = @Email_ID WHERE [Student_ID] = @Student_ID">
            <DeleteParameters>
                <asp:Parameter Name="Student_ID" Type="Int32" />
            </DeleteParameters>
            <InsertParameters>
                <asp:Parameter Name="Student_ID" Type="Int32" />
                <asp:Parameter Name="Student_Name" Type="String" />
                <asp:Parameter Name="S_Password" Type="String" />
                <asp:Parameter Name="Email_ID" Type="String" />
            </InsertParameters>
            <UpdateParameters>
                <asp:Parameter Name="Student_Name" Type="String" />
                <asp:Parameter Name="S_Password" Type="String" />
                <asp:Parameter Name="Email_ID" Type="String" />
                <asp:Parameter Name="Student_ID" Type="Int32" />
            </UpdateParameters>
        </asp:SqlDataSource>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
<asp:Label ID="Label10" runat="server" Font-Bold="True" Font-Size="X-Large" 
    ForeColor="#999999" Text="Label" Visible="False"></asp:Label>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    </td>
    <td class="style20">
        <br />
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label6" runat="server" Font-Bold="True" Font-Size="Large" 
            Text="Label" Visible="False"></asp:Label>
        <br />
        <br />
&nbsp;<asp:TextBox ID="TextBox2" runat="server" BorderWidth="2px" Height="25px" 
            Width="212px" ValidationGroup="a"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
            ControlToValidate="TextBox2" ErrorMessage="Student Name is empty" 
            Font-Size="Large" ForeColor="Red" ValidationGroup="a"></asp:RequiredFieldValidator>
        <br />
        <br />
&nbsp;<asp:TextBox ID="TextBox3" runat="server" BorderWidth="2px" Height="25px" 
            Width="212px" ValidationGroup="a"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
            ControlToValidate="TextBox3" ErrorMessage=" Student Password is empty" 
            Font-Size="Large" ForeColor="Red" ValidationGroup="a"></asp:RequiredFieldValidator>
        <br />
        <br />
&nbsp;<asp:TextBox ID="TextBox4" runat="server" BorderWidth="2px" Height="26px" 
            Width="212px" ValidationGroup="a" ontextchanged="TextBox4_TextChanged"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
            ControlToValidate="TextBox3" Display="Dynamic" 
            ErrorMessage="Email  ID is empty" Font-Size="Large" ForeColor="Red" 
            ValidationGroup="a"></asp:RequiredFieldValidator>
        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
            ControlToValidate="TextBox4" Display="Dynamic" ErrorMessage="Invalid Email ID" 
            Font-Size="Large" ForeColor="Red" 
            ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" 
            ValidationGroup="a"></asp:RegularExpressionValidator>
        <br />
        <br />
&nbsp;<asp:Button ID="Button1" runat="server" BackColor="DarkTurquoise" 
            Font-Size="Large" ForeColor="#FFFFCC" Text="Update" Width="212px" 
            BorderColor="DarkTurquoise" ValidationGroup="a" onclick="Button1_Click" />
        <br />
    </td>
    </tr>
    </table>
     </p>
    <p style="background-color: #00CED1; width: 1320px; height: 25px; color: #FFFFCC; font-weight: bold;">
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Update Teachers Details</p>
    <p>
       <table cellpadding="5px">
    <tr>
    <td class="style5">
        <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" 
            DataKeyNames="Teacher_ID" DataSourceID="SqlDataSource2" CellPadding="4" 
            ForeColor="#333333" GridLines="None" Height="278px" 
            onselectedindexchanged="GridView2_SelectedIndexChanged" Width="701px">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:BoundField DataField="Teacher_ID" HeaderText="Teacher_ID" ReadOnly="True" 
                    SortExpression="Teacher_ID" >
                <ItemStyle HorizontalAlign="Center" />
                </asp:BoundField>
                <asp:BoundField DataField="Teacher_Name" HeaderText="Teacher_Name" 
                    SortExpression="Teacher_Name" >
                <ItemStyle HorizontalAlign="Center" />
                </asp:BoundField>
                <asp:BoundField DataField="T_Password" HeaderText="T_Password" 
                    SortExpression="T_Password" >
                <ItemStyle HorizontalAlign="Center" />
                </asp:BoundField>
                <asp:BoundField DataField="Email_ID" HeaderText="Email_ID" 
                    SortExpression="Email_ID" >
                <ItemStyle HorizontalAlign="Center" />
                </asp:BoundField>
                <asp:BoundField DataField="Course_ID" HeaderText="Course_ID" 
                    SortExpression="Course_ID" >
                <ItemStyle HorizontalAlign="Center" />
                </asp:BoundField>
                <asp:CommandField HeaderText="Select_Row" ShowDeleteButton="True" 
                    ShowSelectButton="True">
                <ItemStyle HorizontalAlign="Center" />
                </asp:CommandField>
            </Columns>
            <EditRowStyle BackColor="#2461BF" />
            <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#EFF3FB" />
            <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#F5F7FB" />
            <SortedAscendingHeaderStyle BackColor="#6D95E1" />
            <SortedDescendingCellStyle BackColor="#E9EBEF" />
            <SortedDescendingHeaderStyle BackColor="#4870BE" />
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource2" runat="server" 
            ConnectionString="<%$ ConnectionStrings:QuizConnectionString4 %>" 
            DeleteCommand="DELETE FROM [Teacher] WHERE [Teacher_ID] = @Teacher_ID" 
            InsertCommand="INSERT INTO [Teacher] ([Teacher_ID], [Teacher_Name], [T_Password], [Email_ID], [Course_ID]) VALUES (@Teacher_ID, @Teacher_Name, @T_Password, @Email_ID, @Course_ID)" 
            SelectCommand="SELECT * FROM [Teacher]" 
            
            UpdateCommand="UPDATE [Teacher] SET [Teacher_Name] = @Teacher_Name, [T_Password] = @T_Password, [Email_ID] = @Email_ID, [Course_ID] = @Course_ID WHERE [Teacher_ID] = @Teacher_ID">
            <DeleteParameters>
                <asp:Parameter Name="Teacher_ID" Type="String" />
            </DeleteParameters>
            <InsertParameters>
                <asp:Parameter Name="Teacher_ID" Type="String" />
                <asp:Parameter Name="Teacher_Name" Type="String" />
                <asp:Parameter Name="T_Password" Type="String" />
                <asp:Parameter Name="Email_ID" Type="String" />
                <asp:Parameter Name="Course_ID" Type="String" />
            </InsertParameters>
            <UpdateParameters>
                <asp:Parameter Name="Teacher_Name" Type="String" />
                <asp:Parameter Name="T_Password" Type="String" />
                <asp:Parameter Name="Email_ID" Type="String" />
                <asp:Parameter Name="Course_ID" Type="String" />
                <asp:Parameter Name="Teacher_ID" Type="String" />
            </UpdateParameters>
        </asp:SqlDataSource>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
<asp:Label ID="Label12" runat="server" Font-Bold="True" Font-Size="X-Large" 
    ForeColor="#999999" Text="Label" Visible="False"></asp:Label>
    </td>
    <td class="style20">
        <br />
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label11" runat="server" Font-Bold="True" Font-Size="Large" 
            Text="Label" Visible="False"></asp:Label>
        <br />
        <br />
&nbsp;<asp:TextBox ID="TextBox6" runat="server" BorderWidth="2px" Height="25px" 
            Width="212px" ValidationGroup="b"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" 
            ControlToValidate="TextBox6" ErrorMessage="Teacher Name is empty" 
            Font-Size="Large" ForeColor="Red" ValidationGroup="b"></asp:RequiredFieldValidator>
        <br />
        <br />
&nbsp;<asp:TextBox ID="TextBox7" runat="server" BorderWidth="2px" Height="25px" 
            Width="212px" ValidationGroup="b"></asp:TextBox>
        <br />
        <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" 
            ControlToValidate="TextBox7" ErrorMessage="Teacher Password is empty" 
            Font-Size="Large" ForeColor="Red" ValidationGroup="b"></asp:RequiredFieldValidator>
        <br />
        <br />
&nbsp;<asp:TextBox ID="TextBox8" runat="server" BorderWidth="2px" Height="26px" 
            Width="212px" ValidationGroup="b"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" 
            ControlToValidate="TextBox8" Display="Dynamic" 
            ErrorMessage="Email  ID is empty" Font-Size="Large" ForeColor="Red" 
            ValidationGroup="b"></asp:RequiredFieldValidator>
        <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" 
            ControlToValidate="TextBox8" Display="Dynamic" ErrorMessage="Invalid Email ID" 
            Font-Size="Large" ForeColor="Red" 
            ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" 
            ValidationGroup="b"></asp:RegularExpressionValidator>
        <br />
        <br />
&nbsp;<asp:Button ID="Button2" runat="server" BackColor="DarkTurquoise" 
            Font-Size="Large" ForeColor="#FFFFCC" Text="Update" Width="212px" 
            BorderColor="DarkTurquoise" ValidationGroup="b" onclick="Button2_Click" />
        <br />
    </td>
    </tr>
    </table>
      </p>
</asp:Content>

