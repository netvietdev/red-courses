appControllers.controller('EditCourseCtrl', ['$scope', '$routeParams', '$location', 'CoursesFactory', function ($scope, $routeParams, $location, coursesFactory) {
    $scope.course = {};

    coursesFactory.get({ id: $routeParams.id }, function (course) {
        $scope.course = course;
    });

    $scope.saveCourse = function () {
        coursesFactory.update({ id: $routeParams.id }, $scope.course, function (successResult) {
            $location.path('/');
        });
    };
}]);
