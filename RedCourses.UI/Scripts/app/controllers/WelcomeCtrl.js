appControllers.controller('WelcomeCtrl', ['$scope', '$location', 'CoursesFactory', function ($scope, $location, coursesFactory) {
    $scope.courses = [];

    var getCourses = function () {
        coursesFactory.query(function (courses) {
            $scope.courses = courses;
        });
    };

    getCourses();

    $scope.deleteCourse = function (course) {
        coursesFactory.delete({ id: course.id }, function (successResult) {
            getCourses();
        });
    };

    $scope.editCourse = function (course) {
        $location.path('/courses/edit/' + course.id);
    };
}]);
