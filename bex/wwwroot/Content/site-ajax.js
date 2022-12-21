/*
AJAX REQUEST
*/
var Ajax = {
    /*
    POST AJAX REQUEST
    */
    PostAjax: function (_dataType, _url, _data, _async, _redirect, obj) {
        var loading = $('.page-loader-wrapper');
        var output = "";
        $.ajax({
            dataType: _dataType,
            url: _url,
            type: 'POST',
            data: JSON.stringify(_data),
            async: _async,
            contentType: "application/json ; character=uth-8",
            beforeSend: function (jqXHR, settings) {
                if (Common.CheckIsNullAndReplace(obj.data('is-show-loading'), true)) {
                    loading.show();
                }
            },

            success: function (data) {
                if (!_async) {
                    output = data;
                } else if (_dataType == 'json') {
                    if (data.modelError) {
                        Common.JsonError(obj, data.data);
                    }
                }
                if (!Common.CheckIsNull(_redirect)) {
                    AjaxRedirect[_redirect](data, obj);
                }

                if (Common.CheckIsNullAndReplace(obj.data('is-show-loading'), true)) {
                    loading.hide();
                }
            },
            error: function (e) {
                try {
                    // location.reload();
                } catch (e) { }
            },
        });
        return output;
    },

    /*
    GET AJAX REQUEST
    */

    GetAjax: function (_dataType, _url, _async, _redirect, obj) {
        var loading = $('.page-loader-wrapper');
        var output = "";
        $.ajax({
            dataType: _dataType,
            url: _url,
            type: 'GET',
            async: _async,
            contentType: "application/json ; character=uth-8",
            success: function (data) {
                if (!_async) {
                    output = data;
                } else
                    if (!Common.CheckIsNull(_redirect)) {
                        AjaxRedirect[_redirect](data, obj);
                    }
            },
            error: function (e) {
                try {
                    if (e.status == 200) {
                        location.reload();
                    }
                } catch (e) { }
            },
        });
        return output;
    },

    AjaxUpload: function (_url, _redirect, obj, formData) {
        var loading = $('.page-loader-wrapper');
        $.ajax({
            url: _url,
            type: 'POST',
            processData: false, // important
            contentType: false, // important
            dataType: 'json',
            data: formData,
            beforeSend: function (jqXHR, settings) {
                var show = true;
                show = Common.CheckIsNullAndReplace(obj.data('is-loader'), true);
                if (show) {
                    loading.show();
                }
            },
            success: function (data) {
                if (data.modelError) {
                    Common.JsonError(obj, data.data);
                }
                AjaxRedirect[_redirect](data, obj);

                show = Common.CheckIsNullAndReplace(obj.data('is-loader'), true);
                if (show) {
                    loading.hide();
                }
            },
            error: function () { },
        });
    },
}