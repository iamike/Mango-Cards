var LoginConfirmation = {
    viewModel: {
        
    }
};
function getQueryStringByName(name) {
    var result = location.search.match(new RegExp("[\?\&]" + name + "=([^\&]+)", "i"));
    if (result == null || result.length < 1) {
        return "";
    }
    return result[1];
}
LoginConfirmation.viewModel.Confirmation = function () {
    var model = {
        code: getQueryStringByName("code")
    };
    $.get('/api/HeaderSetting/', function (base64) {
        $.ajax({
            type: "get",
            data:model,
            url: "http://WeChatService.mangoeasy.com/api/WeChartUserInfo/",
            beforeSend: function (xhr) { //beforeSend定义全局变量
                xhr.setRequestHeader("Authorization", base64); //Authorization 需要授权,即身体验证
            },
            success: function (xmlDoc, textStatus, xhr) {
                if (xhr.status == 200) {
                  
                    alert(JSON.stringify(xhr.responseJSON));
                    
                }
            }
        });
    });
};
$(function () {
    ko.applyBindings(LoginConfirmation);
   
});