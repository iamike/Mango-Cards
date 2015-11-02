var Home = {
    viewModel: {
        cards: ko.observableArray(),
        employees: ko.observableArray(),
    }
};
$(function () {
    ko.applyBindings(Location);
    $.get("/api/")
});