/// <reference path="Scripts/knockout-2.2.1.js" />
/// <reference path="Scripts/jquery-1.4.1.js" />


function ViewModel() {
    var self = this;
    self.firstName = ko.observable('sai');
}


$(function () {
    ko.applyBindings(new ViewModel());
});