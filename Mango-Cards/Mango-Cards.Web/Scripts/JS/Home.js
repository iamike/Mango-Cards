var Home = {
    viewModel: {
        cardTypes: ko.observableArray(),
        employees: ko.observableArray(),
        wechatuser: {
            Id: ko.observable(),
            NickName: ko.observableArray(),
            Gender: ko.observableArray(),
            Language: ko.observableArray(),
            City: ko.observableArray(),
            Province: ko.observableArray(),
            Country: ko.observableArray(),
            Headimgurl: ko.observableArray(),
        }
    }
};
$(function () {
    ko.applyBindings(Home);
    $.get("/api/CardType/", function (data) {
        ko.mapping.fromJS(data, {}, Home.viewModel.cardTypes);
        $.get("/api/Employee/", function (employees) {
            ko.mapping.fromJS(employees, {}, Home.viewModel.employees);
            $.get("/api/WeChatUser/", function (wechatuser) {
                if (wechatuser != null) {
                    ko.mapping.fromJS(wechatuser, {}, Home.viewModel.wechatuser);
                }
            });
        });
    });
});