appControllers.controller('AddCourseCtrl', ['$scope', '$routeParams', '$location', 'CoursesFactory', function ($scope, $routeParams, $location, coursesFactory) {
    $scope.course = new coursesFactory({
        name: '',
        description: ''
    });

    $scope.saveCourse = function () {
        $scope.course.$save(function (successResult) {
            $location.path('/');
        });
    };
}]);
