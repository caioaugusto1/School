var Util = function () {

    function request(endpoint, type, param, dataType, callbackSuccess) {

        $.ajax({
            url: endpoint,
            type: type,
            cache: false,
            param: param,
            dataType: dataType,
            success: function (data) {
                callbackSuccess(data);
            }, error: function (request, status, error) {

            };
        });
    };
}
