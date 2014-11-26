var appControllers = angular.module('Red.Controllers', ['Red.Services']);

appControllers.controller('WelcomeCtrl', ['$scope', 'CourseFactory', function ($scope, courseFactory) {
    $scope.courses = [];

    courseFactory.query(function (courses) {
        $scope.courses = courses;
    });
}]);