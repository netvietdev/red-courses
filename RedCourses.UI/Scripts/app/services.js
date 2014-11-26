var appServices = angular.module('Red.Services', ['ngResource']);

appServices.factory('CoursesFactory', ['$resource', function ($resource) {
    return $resource('/api/Courses/:id',
        { id: "@id" },
        { 'update': { method: 'PUT' } });
}]);
