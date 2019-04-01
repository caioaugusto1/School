var Util = function () {

    function request(endpoint, type, param, dataType, callbackSuccess) {

        $.ajax({
            url: endpoint,
            type: type,
            dataType: dataType,
            cache: false,
            data: param,
            success: function (data) {
                callbackSuccess(data);
            }, error: function (request, status, error) {
                $('#messageErro').html(request.responseJSON.message);
                $('#modalError').modal();
            }
        });
    };

    return { request }
}();
