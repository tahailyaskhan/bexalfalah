var AjaxRedirect = {
    ModalOpen: function (data, obj) {
        Common.CommonModal(obj.data('title'), data, '', Common.CheckIsNullAndReplace(obj.data('modal-size'), 'modal-md'));
        setTimeout(function () {
            Reload();
        }, 500);
    },

    Cascading: function (data, obj) {
        var cascade = obj.closest('form').find(obj.data('cascadeId'));
        var key = cascade.data('key');
        var id = cascade.data('id');

        /// WHEN CHILD DROPDOWN ANOTHER DROPDOWN
        var childCascade = obj.closest('form').find(cascade.data('cascadeId'));

        // REMOVE OPTIONS
        cascade.find('option').remove();
        childCascade.find('option').remove();
        if (data.data.length > 0) {
            var title = Common.CheckIsNullAndReplace('' + cascade.data('default-title') + '', 'Select');
            if (title == 'undefined') {
                title = 'Select';
            }
            title = '<option>' + title + '</option>';
            cascade.append(title);
            for (var i = 0; i < data.data.length; i++) {
                cascade.append('<option value="' + data.data[i][id] + '">' + data.data[i][key] + '</option>');
            }
        }
        RefreshDropDown();
    },

    AppendData: function (data, obj) {
        var appendId = $(obj.data('append-id'));
        if (appendId.length == 0) {
            alert('No Is Found...');
            return;
        }
        appendId.html(data);
        setTimeout(function () {
            Reload();
        }, 500);
    },

    FormSubmit: function (data, obj) {
        if (data.result.Status) {
            obj.find('input[type=reset]').click();
            var frm = $(obj.data('append-id'));
            frm.html(data.html);
            //var mdl = obj.closest('.cls-modal-common');
            //mdl.modal('hide');
        }
        Common.AddMssage(data.result.Status ? Constant.NotifySuccessClass : Constant.NotifyErrorClass, data.result.Message, true);
    },

    GetFileUpload: function (data, obj) {
        var DivInventory = $('#FileUpload');
        DivInventory.html(data);
    },

    GetHomeUdate: function (data, obj) {
        var DivInventory = $('#GetHomeUdate');
        DivInventory.html(data);
    },

    SubmitUplloadData: function (data, obj) {
        if (data.Status) {
            var mdl = obj.closest('.cls-modal-common');
            mdl.modal('hide');
            var frm = $(obj.data('append-id'));
            frm.html(data.html);
        }
        Common.AddMssage(data.result.Status ? Constant.NotifySuccessClass : Constant.NotifyErrorClass, data.result.Message, true);
    },

    Return_Result: function (data, obj) {
        Common.CommonModalClose();
        Common.ShowSwal(data.status, data.message, Common.CheckIsNullAndReplace(obj.data('reload'), false));
        if (data.status && !Common.CheckIsNull(data.html)) {
            if (!Common.CheckIsNull(obj.data('append-id'))) {
                var appendId = $(obj.data('append-id'));
                appendId.html(data.html);
            }
        }
    },

    _GetSubsidaryAccounts: function (data, obj) {
        var div = $('#' + obj.data('div-id'));
        div.html('');
        div.html(data);
    },
}