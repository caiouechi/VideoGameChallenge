angular.module('appRouteModule', ['ngRoute'])
    .config(function ($routeProvider) {
    $routeProvider
        .when('/', {
            templateUrl: 'app/views/browseGame.html',
            controller: 'appComponent'
        })

        .when('/edit', {
            templateUrl: 'app/views/editGame.html',
            controller: 'appEditComponent' 
            })
});