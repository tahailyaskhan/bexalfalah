
var Constant = {
    ErrorMethod: "ErrorMethod",
    LoadingClass: "cls-fa-spin",
    Loading: '<div class="cls-fa-spin text-default text-center"><i class="fa fa-cog fa-spin text-red"></i></div>',
    DefaultErrorMessage: 'Something went wrong',
    DefaultErrorClass: 'danger',
    DefaultSuccessClass: 'success',
    LogoutCode: 1000,
    ProfileLanguage: '#ProfileLanguage',
    HrefLoading: '<i class="fa fa-cog fa-spin text-default cls-fa-spin"></i>',
    DefaultRequiredMessage: 'Field is required.',
    DefaultSuccessMessage: 'Operation Successfully.',
    NotifyErrorClass: 'error',
    NotifySuccessClass: 'success'
};

var SubsidaryAccountType = {
    Company_Account: 1,
    Client_Bank_Account: 2,
    Other_Account: 3,
    Merchant_Account: 4
}

var Common = {
    Paging: function (obj, pageNumber, totalRecords, ShowRecord, link, cls, attr) {
        if (Common.CheckIsNull(cls)) {
            cls = 'cls';
        }
        if (Common.CheckIsNull(attr)) {
            attr = 'attr';
        }
        obj.html('');
        totalNoRecords = parseInt(totalRecords);
        link = link.replace("[TotalRecords]", ShowRecord);
        totalPage = parseInt(totalRecords / ShowRecord);
        if ((totalRecords % ShowRecord) > 0) {
            totalPage = totalPage + 1;
        }
        for (var page = 1; page <= totalPage; page++) {
            varname1 = "";
            var clsActive = "";
            if (page == pageNumber) {
                clsActive = "active";
            }
            var newLink = link;
            var newAttr = attr;
            link = link.replace("[page]", page);
            attr = attr.replace("[page]", page);

            varname1 = varname1 + "<li class='" + clsActive + " " + cls + "'><a href='" + link + "' " + attr + ">" + page + "</a></li>";
            obj.append(varname1);
            link = newLink;
            attr = newAttr;
        }
    },

    isNumber: function (number) {
        try {
            number = number.replace(/,/g, '');
            return (number.length == 0 ? 0 : isNaN(number) == false ? parseFloat(number) : 0);
        } catch (ee) {
            return 0;
        }
    },

    CheckIsNull: function (_value) {
        try {
            _value = _value.toString();
            _value = _value.trim();
            return ((_value == null || typeof _value == 'undefined' || _value == 'null' || _value.length == 0) ? true : false);
        } catch (e) {
            return true;
        }
    },

    CheckIsNullAndReplace: function (_value, _replace) {
        return !Common.CheckIsNull(_value) ? _value : _replace;
    },

    ErrorMethod: function (e) {
        $('.cls-fa-spin').remove();
        Common.AddMssage(Constant.DefaultErrorClass, Constant.DefaultErrorMessage, false);
    },

    SeliazeList: function (obj) {
        var list = new Array();
        obj.each(function () {
            list.push(Common.SerilizeToArray($(this).find('input,select').serializeArray()))
        })
        return list;
    },

    SerilizeToArray: function (obj) {
        var json = {};
        var jsonArray = new Array();
        for (var item in obj) {
            /*  * IS KEY ELEMENT IS NOT EXIST
             *  ! IS ELEMENT NOT HAVE MULTIPLE VALUES     */
            if (Common.CheckIsNull(json[obj[item].name])) {
                json[obj[item].name] = obj[item].value.trim();
            } else {
                if (JSON.stringify(json[obj[item].name]).split(',').length == 1) {
                    var a = json[obj[item].name];
                    json[obj[item].name] = new Array();
                    json[obj[item].name].push(a);
                }
                json[obj[item].name].push(obj[item].value.trim());
            }
        }
        return json;
    },

    SerilizeToQueryString: function (obj) {
        var Query = '';
        for (var item in obj) {
            Query = Query + '' + (item == 0 ? '?' : '&') + '' + obj[item].name + '=' + obj[item].value + '';
        }
        return Query;
    },

    AddMssage: function (className, message, isDisappear) {
        if (Common.CheckIsNull(message)) {
            return;
        }
        $.notify(
            message,
            {
                position: "top center",
                className: className,
                autoHide: Common.CheckIsNullAndReplace(isDisappear, true)
            }
        );
    },

    RemoveMssage: function () {
        $(".cls-body-message").fadeTo(2000, 500).slideUp(500, function () {
            $(".cls-body-message").alert('close');
        });
    },

    CommonModal: function (title, body, footer, modalSize) {
        if (Common.CheckElementExist(body)) {
            var mdl = $('.cls-modal-common').first().clone();
            mdl.removeAttr('id');
            mdl.modal('show');
            mdl.find('.modal-title').html(title);
            var _body = $.parseHTML(body);
            var mdlBody = mdl.find('.modal-body');
            mdlBody.css('max-height', ($(window).height() - 50));
            mdlBody.css('overflow', 'auto');
            mdlBody.html(body);
            var dom = $(body);
            dom.filter('script').each(function () {
                $.globalEval(this.text || this.textContent || this.innerHTML || '');
            });
            if (!Common.CheckIsNull(footer)) {
                mdl.find('.modal-footer').html(footer);
            }
            if (!Common.CheckIsNull(modalSize)) {
                mdl.find('.modal-dialog').removeClass('modal-lg');
                mdl.find('.modal-dialog').removeClass('modal-sm');
                mdl.find('.modal-dialog').addClass(modalSize);
            }
        }

    },

    CommonImageModal: function (title, url) {
        var mdl = $('#mdlCommon').clone();
        mdl.modal('show');
        mdl.find('.modal-body').addClass('text-center');
        mdl.find('.modal-title').html(title);
        mdl.find('.modal-body p').append('<img  src="' + url + '" class="img-responsive img-thumbnail"/>')
    },

    CommonModalClose: function () {
        var mdl = $('.cls-modal-common');
        mdl.modal('hide');
    },

    JsonError: function (obj, data) {
        var _dataJson = JSON.parse(data);
        for (var property in _dataJson) {
            var select = obj.find('#' + property);
            var errorClass;
            var chkAttr = 'error-sup-' + select.attr('id');
            if (!Common.CheckIsNull(select.data('error-class'))) {
                chkAttr = select.data('error-class');
            } else {
                select.attr('data-error-class', chkAttr);
            }
            if (!Common.CheckElementExist(obj.find('.' + chkAttr))) {
                var _Error = '';
                if (_dataJson[property].Errors.length > 0) {
                    _Error = _dataJson[property].Errors[0].ErrorMessage;
                }
                select.parent().append("<div class='error-danger " + chkAttr + "'>" + _Error + "</div>");
                errorClass = obj.find(('.' + select.data('error-class')));
            } else {
                errorClass = obj.find(('.' + select.data('error-class')));
                errorClass.html('');
                errorClass.addClass('error-danger');
            }
            if (_dataJson[property].Errors.length > 0) {
                errorClass.html(_dataJson[property].Errors[0].ErrorMessage);
            }
        }
    },

    JsonErrorList: function (obj, data) {
        var serializeClass = obj.attr('serialize-class');
        var _dataJson = JSON.parse(data);

        for (var property in _dataJson) {
            var childJSON = JSON.parse(JSON.stringify(_dataJson[property]));
            var index = property.split('.')[0].replace('[', '').replace(']', '');
            var key = property.split('.')[1];
            var currentList = obj.find('.' + serializeClass + ':eq(' + index + ')');
            for (var item in childJSON) {
                var errorClass = '';
                var select = currentList.find('#' + key + '');

                if (childJSON[item].length > 0) {
                    var chkAttr = 'error-sup-' + currentList.find('#' + key + '').attr('id');
                    if (!Common.CheckIsNull(select.data('error-class'))) {
                        chkAttr = select.data('error-class');
                    } else {
                        select.attr('data-error-class', chkAttr);
                    }

                    if (!Common.CheckElementExist(currentList.find('.' + chkAttr))) {
                        if (childJSON[item].length > 0) {
                            var _Error = childJSON[item][0].ErrorMessage;
                            select.after("<div class='error-danger " + chkAttr + "'>" + _Error + "</div>");
                            errorClass = currentList.find(('.' + select.data('error-class')));
                        }
                    } else {
                        errorClass = currentList.find(('.' + select.data('error-class')));
                        errorClass.html('');
                        errorClass.addClass('error-danger');
                    }

                    if (childJSON[item].length > 0) {
                        errorClass.html(childJSON[item][0].ErrorMessage);
                    }
                }
            }
        }
    },

    CheckElementExist: function (obj) {
        return obj.length == 0 ? false : true;
    },

    getRandomColor: function () {
        var letters = '0123456789ABCDEF';
        var color = '#';
        for (var i = 0; i < 6; i++) {
            color += letters[Math.floor(Math.random() * 16)];
        }
        return color;
    },

    BootAlert: function (data) {
        bootbox.alert(data);
    },

    RandomNumber: function () {
        var d = new Date().getTime();
        var uuid = 'xxxxxxxxxxxx4xxxyxxxxxxxxxxxxxxx'.replace(/[xy]/g, function (c) {
            var r = (d + Math.random() * 16) % 16 | 0;
            d = Math.floor(d / 16);
            return (c == 'x' ? r : (r & 0x3 | 0x8)).toString(16);
        });
        return uuid;
    },

    ObtainedValue: function (Percentage, TotalMarks) {
        return (Common.isNumber(Percentage) * Common.isNumber(TotalMarks)) / 100;
    },

    ShowSwal: function (status, message, isReload) {
        isReload = Common.CheckIsNullAndReplace(isReload, true);
        setTimeout(function () {
            if (status) {
                swal({
                    title: "Success",
                    text: message,
                    type: "success",
                    showCancelButton: false,
                    confirmButtonColor: "#DD6B55",
                    confirmButtonText: "OK",
                    closeOnConfirm: true,
                    showLoaderOnConfirm: true
                }, function () {
                    if (isReload) {
                        location.reload();
                    }
                });
            }
            else {
                swal({
                    title: "Error",
                    text: message,
                    type: "error",
                    showCancelButton: false,
                    confirmButtonColor: "#DD6B55",
                    confirmButtonText: "OK",
                    closeOnConfirm: true,
                    showLoaderOnConfirm: true
                }, function () {
                    if (isReload) {
                        location.reload();
                    }
                });
            }
        }, 100);
    },

    GenerateTree: function (Id) {
        Id.bstree({
            onDataPush: function (values) {
                var def = '<strong class="pull-left">Values:&nbsp;</strong>';
                for (var i in values) {
                    def += '<span class="pull-left">' + values[i] + '&nbsp;</span>';
                }
            },
            updateNodeTitle: function (node, title) {
                //return '[' +  node.attr('data-id') + '] ' + title + ' (' + node.attr('data-level') + ')'
                return title;
            }
        })
    },
    NumberFormat: function (_number) {
        return Common.isNumber(_number).toLocaleString();
    },

    Data_Table: function (Id) {

        var table = $(Id);
        table.dataTable().fnDestroy();
        table.dataTable({
            "lengthMenu": [[10, 15, 20, 25, 30, -1], [10, 15, 20, 25, 30, "All"]], order: [],
            columnDefs: [{ targets: "_all" }]
            , destroy: true,
            "aaSorting": []
        });
        table.find('select').remove();
        table = table.DataTable();
        table.columns('.select-filter').every(function () {
            var column = this;
            var title = $('table.data-table theader th').text();
            var select = $('<select style="width:100%"><option value=""></option></select>')
                .appendTo($(column.header()))
                .on('change', function () {
                    var val = $.fn.dataTable.util.escapeRegex(
                        $(this).val()
                    );

                    column
                        .search(val ? '^' + val + '$' : '', true, false)
                        .draw();
                });

            column.data().unique().sort().each(function (d, j) {
                select.append('<option value="' + d + '">' + d + '</option>')
            });
        });
    },

    BindGrid: function (data, Id, IsDataTable) {
        var _table = $(Id);
        var DivGetRiderGnt = new Vue({
            el: Id,
            data: {
                datas: data
            },
            methods: {
                update: function (obj) {
                    return JSON.stringify(obj);
                },
                SetTitle: function (_title) {
                    return _title;
                },
                NumbeFormat: function (number) {
                    try {
                        var num = Common.NumberFormat(number.toString());
                        return num;
                    } catch (e) {
                        return number;
                    }
                },
            }
        });
        jQuery("time.timeago").timeago();
        if (Common.CheckIsNullAndReplace(IsDataTable, true)) {
            Common.UpdateTable(Id);
        }
    },

    UpdateTable: function (Id) {
        var table = $(Id);
        table.dataTable({
            "lengthMenu": [[10, 15, 20, 25, 30, -1], [10, 15, 20, 25, 30, "All"]], order: []
            , columnDefs: [{ targets: "_all", orderable: true }]
            , destroy: true
            //, dom: 'Bfrtip'
            , buttons: [
                'copy', 'csv', 'excel', 'pdf', 'print'
            ]
        });
    },

    GenerateDataTable: function (Id) {
        var table = $(Id);
        table.dataTable().fnDestroy();
        table.dataTable({
            "lengthMenu": [[10, 15, 20, 25, 30, -1], [10, 15, 20, 25, 30, "All"]], order: [],
            columnDefs: [{ targets: "_all" }]
            , destroy: true,
            "aaSorting": []
        });
        table.find('select').remove();
        table = table.DataTable();
        table.columns('.select-filter').every(function () {
            var column = this;
            var title = $('table.data-table theader th').text();
            var select = $('<select style="width:100%"><option value=""></option></select>')
                .appendTo($(column.header()))
                .on('change', function () {
                    var val = $.fn.dataTable.util.escapeRegex(
                        $(this).val()
                    );

                    column
                        .search(val ? '^' + val + '$' : '', true, false)
                        .draw();
                });

            column.data().unique().sort().each(function (d, j) {
                select.append('<option value="' + d + '">' + d + '</option>')
            });
        });
    },
}