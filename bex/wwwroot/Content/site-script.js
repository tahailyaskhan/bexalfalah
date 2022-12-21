$(document).ready(function () {

    $(document).on('change', '.cls-parent-menu', function () {
        obj = $(this);
        childCls = $('.' + obj.data('class-name') + '');
        childCls.prop('checked', obj.prop('checked'));
    });

    $(document).on('change', '.cls-cild-parent-box', function () {
        obj = $(this);
        cls = $('.cls-cild-parent-box');
        //START PARENT CHECKBOX CHECK
        if (!Common.CheckIsNull(obj.data('parent-id')) && obj.prop('checked')) {
            parent = $('#' + obj.data('parent-id'));
            parent.prop('checked', true);
            parent.change();
        }
        //END PARENT CHECKBOX CHECK

        //START DISABLE ALL CHILDREN
        if (!obj.prop('checked')) {
            Children = $(".cls-cild-parent-box[data-parent-id='" + obj.attr('id') + "']");
            Children.each(function () {
                current = $(this);
                current.prop('checked', false);
                current.change();
            });
        }
        //END DISABLE ALL CHILDREN

    });

    $(document).on('click', 'input[type=reset]', function () {
        var obj = $(this);
        var frm = obj.closest('form');
        var title = frm.find('#title');
        setTimeout(function () {
            frm.find('.clear-input').val('');
            title.html('Create');
            frm.find('input[type=submit]').val('Create');
        }, 100);
    });

    $(document).on('change', 'select.change-dropdown', function () {
        var obj = $(this);
        var Query = '';
        var keyName = Common.CheckIsNullAndReplace(obj.data('key'), 'Id');
        var data = {
            KeyName: obj.val()
        };
        var dataList = obj.data();
        for (var i in dataList) {
            data[i] = dataList[i];
        }
        data[keyName] = obj.val();
        AjaxHit(obj, obj.data('url'), data);
    });

    $(document).on('change', 'select.Cascading', function () {
        var obj = $(this);
        var Query = '';
        obj.data('redirect-url', 'Cascading');
        obj.data('form-type', 'json');
        if (!Common.CheckIsNull(obj.val())) {
            if (Array.isArray(obj.val())) {
                for (var i = 0; i < obj.val().length; i++) {
                    if (!Common.CheckIsNull(obj.val()[i])) {
                        if (i == 0) {
                            Query = '?Id=' + obj.val()[i];
                        }
                        else {
                            Query = Query + '&Id=' + obj.val()[i];
                        }
                    }
                }
            }
            else {
                Query = '?Id=' + obj.val();
            }
        }
        AjaxHit(obj, obj.data('url') + Query);
    });

    $(document).on('click', '.tr-select,.tr-select a,.tr-select button', function () {
        var obj = $(this);
        var clsSelect = "bg-black";
        var tagName = obj.prop('tagName').toLowerCase();
        var tr_select = obj.closest('.tr-select');
        var cls = tr_select.closest('table');
        if (tr_select.hasClass(clsSelect) && tagName == 'tr') {
            tr_select.removeClass(clsSelect);
        }
        else {
            cls.find('.tr-select').removeClass(clsSelect);
            tr_select.addClass(clsSelect);
        }
    });

    $(document).on('change', '.cls-checkbox-value', function () {
        var obj = $(this);
        var parent = obj.closest('form');
        var Id = parent.find(obj.data('checkbox-id'));
        Id.val(obj.prop('checked'));
    });

    $(document).on('submit', 'form.ajax-upload', function () {
        var obj = $(this);
        obj.find('.error-danger').html('');
        var disabled = obj.find('*[disabled="disabled"]');
        disabled.removeAttr('disabled');
        var formData = new FormData(obj[0]);
        Ajax.AjaxUpload(obj.attr('action'), obj.data('redirect-url'), obj, formData);
        disabled.attr('disabled', 'disabled');
        return false;
    });

    $(document).on('submit', 'form.ajax-submit', function (event) {
        var obj = $(this);
        var action = obj.attr('action');
        obj.find('.error-danger').remove();
        var disabled = obj.find('*[disabled="disabled"]');
        disabled.removeAttr('disabled');
        AjaxHit(obj, action, Common.SerilizeToArray(obj.serializeArray()));
        disabled.attr('disabled', 'disabled');
        return false;
    });

    $(document).on('click', '.Contract-summary', function () {
        var current = $(this);
        var table = $('#' + current.data('child'));
        var find = current.find('i');
        if (find.hasClass('active')) {
            find.removeClass('active');
            find.removeClass('fa-chevron-down');
            find.addClass('fa-chevron-right');
            table.fadeOut('fast');
        }
        else {
            find.addClass('active');
            find.removeClass('fa-chevron-right');
            find.addClass('fa-chevron-down');
            table.fadeIn('fast');
        }
        return false;
    });

    $(document).on('change', '.DataUploadClient', function () {
        var obj = $(this);
        var form = obj.closest('form');
        obj.data('redirect-url', 'GetHomeUdate');
        obj.data('form-type', 'text');
        var data =
        {
            Client: obj.val()
        };
        AjaxHit(obj, '/Home/_GetDropdown', data);
    });

    $(document).on('click', 'a.ajax-click,button.ajax-button,.custom-ajax', function () {
        $(this).find('.error-danger').html('');
        var obj = $(this);
        if (Common.CheckIsNullAndReplace(obj.data('click-active'), false)) {
            if (obj.hasClass('active')) {
                obj.removeClass('active');
            }
            else {
                obj.addClass('active');
            }
        }
        AjaxHit(obj, obj.attr('href'), obj.data());
        return false;
    });

    $(document).on('submit', '.GetKeyWordRerport', function () {
    	debugger;
    	var obj = $(this);
    	obj.data('redirect-url', 'GetKeyWordRerportRedirect');
    	obj.data('form-type', 'text');
    	var _data =
        {
        	StartDate: obj.find('#startDate').val(),
        	EndDate: obj.find('#endDate').val(),
        	QuizId: obj.find('#BranchId').val(),
        	Mobile: obj.find('#QAOfficer').val()

        };

    	AjaxHit(obj, '/Report/_QAReport', _data);
    	return false;
    });

});

function UpdateDropDown() {
    RefreshDropDown();
}

function AjaxHit(obj, action, data) {
    var async = Common.CheckIsNullAndReplace(obj.data('async'), 'true');
    var dataType = Common.CheckIsNullAndReplace(obj.data('form-type'), 'json');
    var redirect = obj.data('redirect-url');
    isConfirm = Common.CheckIsNullAndReplace(obj.data('is-confirm'), false);
    isInputMessage = Common.CheckIsNullAndReplace(obj.data('is-input-message'), false);
    if (isInputMessage) {
        swal({
            title: Common.CheckIsNullAndReplace(obj.data('title'), 'Write Something'),
            text: "",
            type: "input",
            showCancelButton: true,
            closeOnConfirm: true,
            inputPlaceholder: Common.CheckIsNullAndReplace(obj.data('place-holder'), 'Write Something')
        }, function (inputValue) {
            if (inputValue === false) return false;
            if (inputValue === "") {
                swal.showInputError("You need to write something!");
                return false;
            }
            data.comment = inputValue;
            Ajax.PostAjax(dataType, action, data, Boolean(async), redirect, obj);
            return false;
        });
    }
    else if (!isConfirm) {
        Ajax.PostAjax(dataType, action, data, Boolean(async), redirect, obj);
    }
    else {
        swal({
            title: Common.CheckIsNullAndReplace(obj.data('is-confirm-title'), "Confirmation"),
            text: Common.CheckIsNullAndReplace(obj.data('is-confirm-message'), 'Are you sure?'),
            type: "warning",
            showCancelButton: true,
            confirmButtonColor: "#DD6B55",
            confirmButtonText: "Yes",
            closeOnConfirm: true
        },
            function () {
                {
                    Ajax.PostAjax(dataType, action, data, Boolean(async), redirect, obj);
                }
            });
    }
    return false;
}

function Reload() {
    $('.cls-checkbox-value').bootstrapToggle();
    $(".numeric").numeric();
    $(".integer").numeric(false, function () { this.value = ""; this.focus(); });
    $(".positive").numeric({ negative: false }, function () { this.value = ""; this.focus(); });
    $(".positive-integer").numeric({ decimal: false, negative: false }, function () { this.value = ""; this.focus(); });
    $(".decimal-2-places").numeric({ decimalPlaces: 2 });
    RefreshDropDown();
    /*WHEN MODAL CLOSE CLEAR ALL VALUES AND ERRORS*/
    $(".modal").on('hidden.bs.modal', function () {
        var obj = $(this);
        obj.find("input[type='text']").val('');
        obj.find("input[type='number']").val('');
        obj.find("input[type='hidden']").val('');
        obj.find("select option").removeAttr('selected');
        obj.find("textarea").val('');
        obj.find(".error-danger").html('');
        obj.find('.remove-element').remove();
        obj.remove();
    });
}
function RefreshDropDown() {
    try {
        $('select.chosen').chosen('destroy');
        $("select.chosen").chosen({ disable_search_threshold: 3 });

    } catch (e) {
        console.log(e);
    }
}