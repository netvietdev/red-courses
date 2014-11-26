var appServices = angular.module('Red.Services', ['ngResource']);

appServices.factory('CourseFactory', ['$resource', function ($resource) {
    return $resource('/api/Course');
}]);