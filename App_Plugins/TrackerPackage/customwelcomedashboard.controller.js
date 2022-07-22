angular.module("umbraco").controller("CustomWelcomeDashboardController", function ($scope, userService, trackingResource) {
    var vm = this;
    vm.UserName = "guest";
    vm.Trackings = [];

    var user = userService.getCurrentUser().then(function(user) {
        vm.UserName = user.name;
    });

    trackingResource.getAll().then(function (response){
        vm.Trackings = response;
    });
});