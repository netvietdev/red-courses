var appServices = angular.module('Red.Services', ['ngResource']);

appServices.factory('CoursesFactory', ['$resource', function ($resource) {
    return $resource('/api/Courses');
}]);

appServices.factory('CourseFactory', ['$resource', function ($resource) {
    return $resource('/api/Courses/:id',
        { id: "@id" });
}]);