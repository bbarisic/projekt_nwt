var app = angular.module("airBnb", ['ngRoute']);

app.config(['$routeProvider',
    function ($routeProvider) {
        $routeProvider
        .when('/', {
            title: 'Main Page',
            templateUrl: '/AngularViews/mainPage.html',
            controller: 'mainPageController'
        })
            .when('/Registration', {
                title: 'Registration',
                templateUrl: '/AngularViews/registrationPage.html',
                controller: 'userAccesController'
            })
        .otherwise({
            redirectTo: 'Main Page'
        });
    }]);
