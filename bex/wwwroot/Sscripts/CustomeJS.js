function  ValidateEmail(email) {

    var testEmail = /^[A-Z0-9._%+-]+@([A-Z0-9-]+\.)+[A-Z]{2,4}$/i;
 
    //var patternForEmail = /^([a-zA-Z0-9_\-\.]+)((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})$/i;
    if (testEmail.test(email)) {
        return 'pass';
    }
    else {
        //alert('failed');
       return 'fail';
    }
};

function SearchFilter(tblBody) {
    $("#myInput").on("keyup", function () {
        var value = $(this).val().toLowerCase();
        $("#" + tblBody + " tr").filter(function () {
            $(this).toggle($(this).text().toLowerCase().indexOf(value) > -1)
        });
    });
}