namespace CatanLayoutGenerator {

    angular.module('CatanLayoutGenerator', ['ui.router', 'ngResource', 'smoothScroll']).config((
        $stateProvider: ng.ui.IStateProvider,
        $urlRouterProvider: ng.ui.IUrlRouterProvider,
        $locationProvider: ng.ILocationProvider
    ) => {
        // Define routes
        $stateProvider
            .state('home', {
                url: '/',
                templateUrl: '/ngApp/views/home.html',
                controller: CatanLayoutGenerator.Controllers.HomeController,
                controllerAs: 'controller'
            })
            .state('secret', {
                url: '/secret',
                templateUrl: '/ngApp/views/secret.html',
                controller: CatanLayoutGenerator.Controllers.SecretController,
                controllerAs: 'controller'
            })
            .state('login', {
                url: '/login',
                templateUrl: '/ngApp/views/login.html',
                controller: CatanLayoutGenerator.Controllers.LoginController,
                controllerAs: 'controller'
            })
            .state('register', {
                url: '/register',
                templateUrl: '/ngApp/views/register.html',
                controller: CatanLayoutGenerator.Controllers.RegisterController,
                controllerAs: 'controller'
            })
            .state('externalRegister', {
                url: '/externalRegister',
                templateUrl: '/ngApp/views/externalRegister.html',
                controller: CatanLayoutGenerator.Controllers.ExternalRegisterController,
                controllerAs: 'controller'
            })
            .state('playerProfile', {
                url: '/playerProfile',
                templateUrl: '/ngApp/views/playerProfile.html',
                controller: CatanLayoutGenerator.Controllers.PlayerProfileController,
                controllerAs: 'controller'
            })
            .state('boardLayouts', {
                url: '/boardLayouts',
                templateUrl: '/ngApp/views/boardLayouts.html',
                controller: CatanLayoutGenerator.Controllers.BoardLayoutController,
                controllerAs: 'controller'
            })
            .state('about', {
                url: '/about',
                templateUrl: '/ngApp/views/about.html',
                controller: CatanLayoutGenerator.Controllers.AboutController,
                controllerAs: 'controller'
            })
            .state('contact', { //TODO: Add controller!
                url: '/contact',
                templateUrl: '/ngApp/views/contact.html'
            }).state('generator', { //TODO: Add controller!
                url: '/generator',
                templateUrl: '/ngApp/views/generator.html'
            })
            .state('notFound', {
                url: '/notFound',
                templateUrl: '/ngApp/views/notFound.html'
            });

        // Handle request for non-existent route
        $urlRouterProvider.otherwise('/notFound');

        // Enable HTML5 navigation
        $locationProvider.html5Mode(true);
    });


    angular.module('CatanLayoutGenerator').factory('authInterceptor', (
        $q: ng.IQService,
        $window: ng.IWindowService,
        $location: ng.ILocationService
    ) =>
        ({
            request: function (config) {
                config.headers = config.headers || {};
                config.headers['X-Requested-With'] = 'XMLHttpRequest';
                return config;
            },
            responseError: function (rejection) {
                if (rejection.status === 401 || rejection.status === 403) {
                    $location.path('/login');
                }
                return $q.reject(rejection);
            }
        })
    );

    angular.module('CatanLayoutGenerator').config(function ($httpProvider) {
        $httpProvider.interceptors.push('authInterceptor');
    });



}
