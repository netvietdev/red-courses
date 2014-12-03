appControllers.controller('AddVideoCtrl', ['$scope', '$routeParams', '$location', 'CoursesFactory', function ($scope, $routeParams, $location, coursesFactory) {
    $scope.video = new coursesFactory({
        url: '',
        description: ''
    });

    $scope.saveVideo = function () {
        $scope.video.$save({ id: $routeParams.id }, function (successResult) {
            $location.path('/courses/' + $routeParams.id);
        });
    };
}]);