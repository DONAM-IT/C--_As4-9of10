<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.5.0/css/bootstrap.min.css" integrity="sha384-9aIt2nRpC12Uk9gS9baDl411NQApFmC26EwAOH8WgZl5MYYxFfc+NcPb1dKGj7Sk" crossorigin="anonymous">
    <script src="https://code.jquery.com/jquery-3.5.1.min.js" type="text/javascript" />
    <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.5.0/js/bootstrap.min.js" integrity="sha384-OgVRvuATP1z7JjHLkuOU7Xw704+h835Lr+6QL9UvYjZE3Ipu6Tp75j7Bh/kR0JKI" crossorigin="anonymous"></script>
    <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.5.0/js/bootstrap.bundle.min.js" integrity="sha384-1CmrxMRARb6aLqgBO7yyAxTOQE2AKb9GfXnEo760AUcUmFx3ibVJJAzGytlQcNXd" crossorigin="anonymous"></script>
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/font-awesome/4.7.0/css/font-awesome.min.css">
</head>
<body>
    <div class="container-fluid d-flex justify-content-center">
    <form id="form1" runat="server">
        <div class="form-group row">
        <div class="col-md-12">
            <h1>Convert currency</h1>
    <label for="text" class="col-form-label">Input: </label> 
      <div class="input-group">
        <div class="input-group-prepend">
          <div class="input-group-text">
            <i class="fa fa-dollar"></i>
          </div>
        </div> 
        <asp:TextBox CssClass="form-control" ID="money" runat="server" placeholder="Input your money" required=""></asp:TextBox><br />
      </div>

            <label>From:</label>
            <asp:DropDownList ID="from" CssClass="form-control" runat="server"></asp:DropDownList>
            <label for="text" class="col-form-label">To:</label>
            <asp:DropDownList CssClass="form-control" ID="to" runat="server"></asp:DropDownList><br />
            <!--<div class="col-md-6">-->
            <div class="justify-content-center">
            <asp:Button CssClass="btn btn-info" ID="convert" runat="server" Text="Convert" OnClick="convert_Click"/><br />
            <br/>
            
            <label>Result:</label>
            <asp:Label ID="lblResult" runat="server" Text=""></asp:Label>
                
                </div>
        <p>
            &nbsp;
        </p>
        </div>
    </form>
        </div>
</body>
</html>
