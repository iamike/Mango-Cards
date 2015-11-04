var GetMangoCard = {
    viewModel: {
        cardTypes: ko.observableArray(),
        employees: ko.observableArray(),
    }
};
$(function () {
    ko.applyBindings(GetMangoCard);
    $.get("/api/GetWechatLoginQRCode/", function (result) {
        $('#qrcode').empty();
        $('#qrcode').qrcode(result);       
    });
    function longPolling() {
        $.getJSON('/comet/LongPolling', function (data) {
            if (data.d) {
                $('#logs').append(data.d + "<br/>");
            }
            longPolling();
        });
    }
    longPolling();
});