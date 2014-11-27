var appControllers = angular.module('Red.Controllers', ['Red.Services']);

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
}]);

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