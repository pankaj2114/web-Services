<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Students.aspx.cs" Inherits="Calculator.Students" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
   
</head>
     <script type="text/javascript" lang="javascript">
         function GetStudentByIds() {
             console.log("Mai aa raha hu");
             let id = document.getElementById("txtId").value;
             Calculator.StudentService.GetDetailsById(id, SuccessCallbackGetStudent, FailedCallbackGetStudent);
             //document.getElementById("txtName").value = studentObj.name;
             console.log("mai aa gaya hu");
         }
         function SuccessCallbackGetStudent(Result) {
             document.getElementById("txtName").value = Result["name"];
             document.getElementById("txtAge").value = Result["age"];
             document.getElementById("txtMarks").value = Result["marks"];
         }
         function FailedCallbackGetStudent(errors) {
             alert(errors.get_message());
         }

     </script>
<body>
    <form id="form1" runat="server">
        <asp:ScriptManager ID="ScriptManager1" runat="server">
            <Services>
                <asp:ServiceReference Path="~/StudentService.asmx" />
            </Services>
        </asp:ScriptManager>
        <div>
             <table>
                <tr>
                    <td>Id</td>
                    <td>:</td>
                    <td><asp:TextBox runat="server" ID="txtId"></asp:TextBox></td>
                    <td><input type="button" id="button" value="Get Student" onclick="GetStudentByIds()"/></td>
                </tr>
                <tr>
                    <td>Name</td>
                    <td>:</td>
                    <td><asp:TextBox runat="server" ID="txtName"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Age</td>
                    <td>:</td>
                    <td><asp:TextBox runat="server" ID="txtAge"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Marks</td>
                    <td>:</td>
                    <td><asp:TextBox runat="server" ID="txtMarks"></asp:TextBox></td>
                </tr>

               
               
            </table>
        </div>
    </form>
</body>
</html>
