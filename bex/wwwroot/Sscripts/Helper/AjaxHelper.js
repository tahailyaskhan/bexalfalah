function GetOrBindRegions(controlId, selectedValue) {
    // local
    $.get("/AjaxHelper/GetRegions", function (data, status) {
  
    //$.get("/BEXUATPortal/AjaxHelper/GetRegions", function (data, status) {
        
        if (controlId != null && controlId != undefined) {
            $("#" + controlId + "").empty();
            $("#" + controlId + "").append($("<option></option>").val("0").html("Select Region"));
            $.each(data.regions, function (index, value) {
                $("#" + controlId + "").append($("<option></option>").val(value.Id).html(value.Name));
            });
            if (selectedValue == "null" || selectedValue == undefined) {
                $("#" + controlId + "").val("0");
            } else {
                $("#" + controlId + "").val(selectedValue);
            }
        }
        return data.regions;
    });
}
function GetOrBindAreas(controlId, selectedValue) {
    //local 
    $.get("/AjaxHelper/GetAreas", function (data, status) {
    //$.get("/BEXUATPortal/AjaxHelper/GetAreas", function (data, status) {
        if (controlId != null && controlId != undefined) {
            $("#" + controlId + "").empty();
            $("#" + controlId + "").append($("<option></option>").val("0").html("Select Area"));
            $.each(data.areas, function (index, value) {
                $("#" + controlId + "").append($("<option></option>").val(value.Id).html(value.Name));
            });
            if (selectedValue == "null" || selectedValue == undefined) {
                $("#" + controlId + "").val("0");
            } else {
                $("#" + controlId + "").val(selectedValue);
            }
        }
        return data.areas;
    });
}
function GetOrBindDesginations(controlId, selectedValue) {
    // local 
    $.get("/AjaxHelper/GetDesginations", function (data, status) {
   
    //$.get("/BEXUATPortal/AjaxHelper/GetDesginations", function (data, status) {
        if (controlId != null && controlId != undefined) {
            $("#" + controlId + "").empty();
            $("#" + controlId + "").append($("<option></option>").val("0").html("Select Designations"));
            $.each(data.designations, function (index, value) {
                $("#" + controlId + "").append($("<option></option>").val(value.Id).html(value.Name));
            });
            if (selectedValue == "null" || selectedValue == undefined) {
                $("#" + controlId + "").val("0");
            } else {
                $("#" + controlId + "").val(selectedValue);
            }
        }
        return data.designations;
    });
}
function GetOrBindBranches(controlId, selectedValue) {
    // local 
    $.get("/AjaxHelper/GetBranches", function (data, status) {
    //$.get("/BEXUATPortal/AjaxHelper/GetBranches", function (data, status) {
   
        if (controlId != null && controlId != undefined) {
            $("#" + controlId + "").empty();
            $("#" + controlId + "").append($("<option></option>").val("0").html("Select Branch"));
            $.each(data.branches, function (index, value) {
                $("#" + controlId + "").append($("<option></option>").val(value.ID).html(value.BranchName));
            });
            if (selectedValue == "null" || selectedValue == undefined) {
                $("#" + controlId + "").val("0");
            } else {
                $("#" + controlId + "").val(selectedValue);
            }
        }
        return data.branches;
    });
}
function GetOrBindBussinessRegions(controlId, selectedValue) {
    //local   
    $.get("/AjaxHelper/GetBussinessRegions", function (data, status) {
    //$.get("/BEXUATPortal/AjaxHelper/GetBussinessRegions", function (data, status) {
   
        if (controlId != null && controlId != undefined) {
            $("#" + controlId + "").empty();
            $("#" + controlId + "").append($("<option></option>").val("0").html("Select BussinessRegion"));
            $.each(data.bussinessRegions, function (index, value) {
                $("#" + controlId + "").append($("<option></option>").val(value.Id).html(value.Name));
            });
            if (selectedValue == "null" || selectedValue == undefined) {
                $("#" + controlId + "").val("0");
            } else {
                $("#" + controlId + "").val(selectedValue);
            }
        }
        return data.bussinessRegions;
    });
}
function GetOrBindBussinessRegionsByRegion(controlId, selectedValue, regionId) {
    //local 
    $.get("/AjaxHelper/GetBussinessRegionsByRegion", { "regionId": regionId }, function (data, status) {
    //$.get("/BEXUATPortal/AjaxHelper/GetBussinessRegionsByRegion", { "regionId": regionId }, function (data, status) {
  
        if (controlId != null && controlId != undefined) {
            $("#" + controlId + "").empty();
            $("#" + controlId + "").append($("<option></option>").val("0").html("Select BussinessRegion"));
            $.each(data.bussinessRegions, function (index, value) {
                $("#" + controlId + "").append($("<option></option>").val(value.Id).html(value.Name));
            });
            if (selectedValue == "null" || selectedValue == undefined) {
                $("#" + controlId + "").val("0");
            } else {
                $("#" + controlId + "").val(selectedValue);
            }
        }
        return data.bussinessRegions;
    });
}
function GetOrBindAreaByBussinessRegions(controlId, selectedValue, bussinessRegionId) {
    //   
    $.get("/AjaxHelper/GetAreaByBussinessRegions", { "bussinessRegionId": bussinessRegionId }, function (data, status) {
      //$.get("/BEXUATPortal/AjaxHelper/GetAreaByBussinessRegions", { "bussinessRegionId": bussinessRegionId }, function (data, status) {
   
        if (controlId != null && controlId != undefined) {
            $("#" + controlId + "").empty();
            $("#" + controlId + "").append($("<option></option>").val("0").html("Select Area"));
            $.each(data.areas, function (index, value) {
                $("#" + controlId + "").append($("<option></option>").val(value.Id).html(value.Name));
            });
            if (selectedValue == "null" || selectedValue == undefined) {
                $("#" + controlId + "").val("0");
            } else {
                $("#" + controlId + "").val(selectedValue);
            }
        }
        return data.areas;
    });
}