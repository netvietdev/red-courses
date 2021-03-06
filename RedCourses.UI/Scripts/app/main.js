﻿var app = angular.module('Red', ['ngRoute', 'Red.Controllers']);

app.config(['$routeProvider', function ($routeProvider) {
    $routeProvider
        .when('/',
            {
                templateUrl: "/Home/ListCourses",
                controller: "WelcomeCtrl"
            })
        .when('/courses/new',
            {
                templateUrl: "/Home/AddCourse",
                controller: "AddCourseCtrl"
            })
        .when('/courses/edit/:id',
            {
                templateUrl: "/Home/AddCourse",
                controller: "EditCourseCtrl"
            })
        .when('/courses/:id/video/new',
            {
                templateUrl: "/Home/AddVideo",
                controller: "AddVideoCtrl"
            })
        .when('/courses/:id/video/edit/:videoId',
            {
                templateUrl: "/Home/AddVideo",
                controller: "AddVideoCtrl"
            })
        .when('/courses/:id',
            {
                templateUrl: "/Home/ViewCourse",
                controller: "ViewCourseCtrl"
            })
        .otherwise({
            redirectTo: '/'
        });
}]);