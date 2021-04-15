<%@ Page Title="" Language="C#" MasterPageFile="~/page17.master" AutoEventWireup="true" CodeFile="page21.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label5" runat="server" Font-Size="XX-Large" 
            ForeColor="DarkTurquoise" Text="View and Update"></asp:Label>
        &nbsp;</p>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Label ID="Label6" runat="server" Font-Size="Large" ForeColor="#666666" 
        Text="Enter Quiz ID"></asp:Label>
&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="TextBox1" runat="server" BorderWidth="2px" Height="28px" 
        Width="153px"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
    <asp:Button ID="Button2" 
        runat="server" BackColor="DarkTurquoise" 
            BorderColor="DarkTurquoise" Font-Size="Large" ForeColor="#FFFF99" 
            Text="View Quiz Details" Width="189px" onclick="Button2_Click1" />
     <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label10" runat="server" Font-Bold="True" Font-Size="X-Large" 
            ForeColor="#999999" Text="Label" Visible="False"></asp:Label>
     &nbsp;<p>

        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox11" runat="server" BorderWidth="2px" Height="36px" 
            Width="958px" Font-Size="Large" TextMode="MultiLine"></asp:TextBox>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;

        </p>
    <p>

        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;

        &nbsp;</p>
        <center>
    <p>

        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;

        &nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="TextBox7" runat="server" BorderWidth="2px" Height="31px" 
        Width="410px" Font-Size="Large" Placeholder="Option A" TextMode="MultiLine"></asp:TextBox>

        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;

        </p>
    <p>

&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="TextBox8" runat="server" BorderWidth="2px" Height="31px" 
        Width="411px" Font-Size="Large" Placeholder="Option B" TextMode="MultiLine"></asp:TextBox>

        </p>
    <p>

&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="TextBox9" runat="server" BorderWidth="2px" Height="31px" 
        Width="410px" Font-Size="Large" Placeholder="Option C" TextMode="MultiLine"></asp:TextBox>

        </p>
    <p>

&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="TextBox10" runat="server" BorderWidth="2px" Height="31px" 
        Width="410px" Font-Size="Large" Placeholder="Option D" TextMode="MultiLine"></asp:TextBox>

        </p>
    <p>

        &nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="TextBox12" runat="server" BorderWidth="2px" Height="31px" 
        Width="410px" Font-Size="Large" Placeholder="Correct Option" 
            TextMode="MultiLine" ></asp:TextBox>

        </p>
            <p>

                <asp:Button ID="Button3" 
        runat="server" BackColor="DarkTurquoise" 
            BorderColor="DarkTurquoise" Font-Size="Large" ForeColor="#FFFF99" 
            Text="Update Questions" Width="189px" onclick="Button3_Click" Visible="False" />

        </p>
        </center>
    <p>

        &nbsp;
        </p>
    <p>

        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False"
            BackColor="White" BorderColor="#999999" BorderWidth="1px" 
            CellPadding="3" DataKeyNames="Question_ID" DataSourceID="SqlDataSource1" 
            GridLines="Vertical" Height="181px" Width="999px" BorderStyle="None" 
            onselectedindexchanged="GridView1_SelectedIndexChanged">
            <AlternatingRowStyle BackColor="#DCDCDC" />
            <Columns>
                <asp:CommandField HeaderText="Select_Row" ShowSelectButton="True" />
                <asp:BoundField DataField="Question_ID" HeaderText="Question_ID" 
                    ReadOnly="True" SortExpression="Question_ID" />
                <asp:BoundField DataField="Course_ID" HeaderText="Course_ID" 
                    SortExpression="Course_ID" />
                <asp:BoundField DataField="Quiz_ID" HeaderText="Quiz_ID" 
                    SortExpression="Quiz_ID" />
                <asp:BoundField DataField="Question" HeaderText="Question" 
                    SortExpression="Question" />
                <asp:BoundField DataField="OptionA" HeaderText="OptionA" 
                    SortExpression="OptionA" />
                <asp:BoundField DataField="OptionB" HeaderText="OptionB" 
                    SortExpression="OptionB" />
                <asp:BoundField DataField="OptionC" HeaderText="OptionC" 
                    SortExpression="OptionC" />
                <asp:BoundField DataField="OptionD" HeaderText="OptionD" 
                    SortExpression="OptionD" />
                <asp:BoundField DataField="Correct" HeaderText="Correct" 
                    SortExpression="Correct" />
            </Columns>
            <FooterStyle BackColor="#CCCCCC" ForeColor="Black" />
            <HeaderStyle BackColor="#000084" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#999999" ForeColor="Black" 
                HorizontalAlign="Center" />
            <RowStyle BackColor="#EEEEEE" ForeColor="Black" />
            <SelectedRowStyle BackColor="#008A8C" ForeColor="White" Font-Bold="True" />
            <SortedAscendingCellStyle BackColor="#F1F1F1" />
            <SortedAscendingHeaderStyle BackColor="#0000A9" />
            <SortedDescendingCellStyle BackColor="#CAC9C9" />
            <SortedDescendingHeaderStyle BackColor="#000065" />
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
            ConnectionString="<%$ ConnectionStrings:QuizConnectionString2 %>" 
            SelectCommand="SELECT * FROM [Question] WHERE ([Quiz_ID] = @Quiz_ID)">
            <SelectParameters>
                <asp:ControlParameter ControlID="TextBox1" Name="Quiz_ID" PropertyName="Text" 
                    Type="String" />
            </SelectParameters>
        </asp:SqlDataSource>

        </p>
</asp:Content>

