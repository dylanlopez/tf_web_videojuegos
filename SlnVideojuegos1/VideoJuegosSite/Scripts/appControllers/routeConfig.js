

angular
    .module('MyApp', [
    'ngRoute',
    'MyApp.ctrl.crud'
    ])
    .config(['$routeProvider', '$locationProvider', function ($routeProvider, $locationProvider) {

        $routeProvider.when('/', {
            templateUrl: '/Home/Index',
            controller: 'generoController'
        });

        $routeProvider.when('/Genero/GeneroMain', {
            templateUrl: '/Genero/GeneroView',
            controller: 'generoController'
        });

        $routeProvider.when('/Juego/JuegoMain', {
            templateUrl: '/Juego/JuegoView',
            controller: 'juegoController'
        });

        $routeProvider.when('/Pack/PackMain', {
            templateUrl: '/Pack/PackView',
            controller: 'packController'
        });

        $routeProvider.when('/JuegoGenero/JuegoGeneroMain', {
            templateUrl: '/JuegoGenero/JuegoGeneroView',
            controller: 'juegoGeneroController'
        });

        $routeProvider.when('/PackDetalle/PackDetalleMain', {
            templateUrl: '/PackDetalle/PackDetalleView',
            controller: 'packDetalleController'
        });

        $locationProvider.html5Mode({
            enabled: true,
            requireBase: false
        });

    }]);