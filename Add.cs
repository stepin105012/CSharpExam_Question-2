@model ExamWebApp.Models.EmpTable

@{
    Layout = null;
}

<!DOCTYPE html>

<html>
<head>
    <meta name="viewport" content="width=device-width" />
    <title>AddEmployee</title>
</head>
<body>
    @using (Html.BeginForm()) 
    {
        @Html.AntiForgeryToken()
        
        <div class="form-horizontal">
            <h4>EmpTable</h4>
            <hr />
            @Html.ValidationSummary(true, "", new { @class = "text-danger" })
            <div class="form-group">
                @Html.LabelFor(model => model.EmpID, htmlAttributes: new { @class = "control-label col-md-2" })
                <div class="col-md-10">
                    @Html.EditorFor(model => model.EmpID, new { htmlAttributes = new { @class = "form-control" } })
                    @Html.ValidationMessageFor(model => model.EmpID, "", new { @class = "text-danger" })
                </div>
            </div>
    
            <div class="form-group">
                @Html.LabelFor(model => model.EmpName, htmlAttributes: new { @class = "control-label col-md-2" })
                <div class="col-md-10">
                    @Html.EditorFor(model => model.EmpName, new { htmlAttributes = new { @class = "form-control" } })
                    @Html.ValidationMessageFor(model => model.EmpName, "", new { @class = "text-danger" })
                </div>
            </div>
    
            <div class="form-group">
                @Html.LabelFor(model => model.EmpAddress, htmlAttributes: new { @class = "control-label col-md-2" })
                <div class="col-md-10">
                    @Html.EditorFor(model => model.EmpAddress, new { htmlAttributes = new { @class = "form-control" } })
                    @Html.ValidationMessageFor(model => model.EmpAddress, "", new { @class = "text-danger" })
                </div>
            </div>
    
            <div class="form-group">
                @Html.LabelFor(model => model.EmpSalary, htmlAttributes: new { @class = "control-label col-md-2" })
                <div class="col-md-10">
                    @Html.EditorFor(model => model.EmpSalary, new { htmlAttributes = new { @class = "form-control" } })
                    @Html.ValidationMessageFor(model => model.EmpSalary, "", new { @class = "text-danger" })
                </div>
            </div>
    
            <div class="form-group">
                <div class="col-md-offset-2 col-md-10">
                    <input type="submit" value="Create" class="btn btn-default" />
                </div>
            </div>
        </div>
    }
    
    <div>
        @Html.ActionLink("Back to List", "Index")
    </div>
</body>
</html>