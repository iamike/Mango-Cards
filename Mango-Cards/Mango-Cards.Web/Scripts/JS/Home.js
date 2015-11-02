var Home = {
    viewModel: {
        cards: ko.observableArray(),
        employees: ko.observableArray(),
    }
};
$(function () {
    ko.applyBindings(Home);
    $.get("/api/CardDemo/", function (demos) {
        ko.mapping.fromJS(demos, {}, Home.viewModel.cards);
        $.get("/api/Employee/", function (demos) {
            ko.mapping.fromJS(demos, {}, Home.viewModel.employees);
        })
    })
});