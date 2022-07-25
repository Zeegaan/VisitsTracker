angular.module("umbraco").controller("CustomWelcomeDashboardController", function ($scope, userService, trackingResource) {
    var vm = this;
    vm.Trackings = [];

    trackingResource.getAll().then(function (response){
        vm.Trackings = response;
    });
});