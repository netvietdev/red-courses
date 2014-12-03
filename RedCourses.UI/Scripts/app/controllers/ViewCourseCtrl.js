appControllers.controller('ViewCourseCtrl', ['$scope', '$routeParams', 'CoursesFactory', function ($scope, $routeParams, coursesFactory) {
    $scope.course = {};

    coursesFactory.get({ id: $routeParams.id }, function (course) {
        $scope.course = course;
    });

    $scope.deleteVideo = function (video) {
        coursesFactory.delete({ id: $scope.course.id, videoId: video.id }, function (successResult) {
            $scope.course.videos.splice($scope.course.videos.indexOf(video), 1);
        });
    };

    $scope.deleteVideo = function (video) {
        $location.path('/courses/edit/' + course.id);
    };
}]);
