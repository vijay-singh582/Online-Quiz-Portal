<%@ Page Title="" Language="C#" MasterPageFile="~/page4.master" AutoEventWireup="true" CodeFile="page5.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    </asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label5" runat="server" Font-Size="XX-Large" ForeColor="DarkTurquoise" Text="Dashboard"></asp:Label>
        &nbsp;</p>
   <table cellpadding="10px" style="height:200px; width:900px;">
  <tr>
   <th style="height:200px; width:700px; border-top-style: solid; border-bottom-style: solid; border-top-width: thick; border-bottom-width: thick; border-top-color: #808080; border-bottom-color: #808080; font-size:large; background-color: #999999;">
  <p style="height:200px; width:700px;"> Instructions
  <marquee behavior="scroll" direction="up" scrollamount="1" style="padding:4px; height:180px; color:#FFFF99; font-size:large;">
 1.) Many Quizs are available for each Course.<br/>
  2.) More than one Courses are availble in this portal.<br/>
  3.) Any student can add any course by himself.<br/>
  4.) Student should be remember password and userid before login portal.<br/>
  5.) Each question of quiz can carry 1 marks.<br/>
  6.) Result showed after the submit of quiz.<br/></marquee>
  </p>
   </th>
   <td style="color: #000000; font-size: large; height:200px; width:200px; border-top: thick solid #808080; border-bottom: thick solid #808080; border-top-color: #FF6600; border-bottom-color: #00FF00;">  
         &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
         Calendar<asp:Calendar ID="Calendar1" 
           runat="server" ForeColor="Black" Height="180px" 
           Width="200px" onselectionchanged="Calendar1_SelectionChanged" 
           BackColor="White" FirstDayOfWeek="Monday" Font-Size="Small"></asp:Calendar>
         Today:  &nbsp;
         <asp:Label ID="Label6" runat="server" Font-Size="Large" ForeColor="Black"></asp:Label>
   </td>
   </tr>
   </table>
   <br/>
                </asp:Content>

