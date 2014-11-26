var appControllers = angular.module('Red.Controllers', ['Red.Services']);

appControllers.controller('WelcomeCtrl', ['$scope', 'CoursesFactory', function ($scope, coursesFactory) {
    $scope.courses = [];

    coursesFactory.query(function (courses) {
        $scope.courses = courses;
    });
}]);

appControllers.controller('ViewCourseCtrl', ['$scope', '$routeParams', 'CourseFactory', function ($scope, $routeParams, courseFactory) {
    $scope.course = {};
    courseFactory.get({ id: $routeParams.id }, function (course) {
        $scope.course = course;
    });
}]);