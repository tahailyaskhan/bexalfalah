function bindDropdownList(controlId, data, selectedValue, SelectedText)
{
    $("#" + controlId + "").append($("<option></option>").val("0").html("Select"));
    $.each(data, function (index, value) {
        $("#" + controlId + "").append($("<option></option>").val(value.Id).html(value.Name));
    });
    $("#" + controlId + "").val(selectedValue);
}

// For Branches (this type of)
function bindDropdownListBranhces(controlId, data, selectedValue, SelectedText) {
    $("#" + controlId + "").append($("<option></option>").val("0").html("Select"));
    $.each(data, function (index, value) {
        $("#" + controlId + "").append($("<option></option>").val(value.ID).html(value.BranchName));
    });
    $("#" + controlId + "").val(selectedValue);
}