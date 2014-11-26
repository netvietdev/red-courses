var app = angular.module('Red', ['ngRoute', 'Red.Controllers']);

app.config(['$routeProvider', function ($routeProvider) {
    $routeProvider
        .when('/',
        {
            templateUrl: "/Home/ListCourses",
            controller: "WelcomeCtrl"
        })
        .otherwise({
            redirectTo: '/'
        });
}]);