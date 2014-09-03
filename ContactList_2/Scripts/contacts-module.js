
var contactsModule = angular.module("contactsModule", ['ngRoute', 'ngResource'])
.config(function ($routeProvider, $locationProvider) {
    $routeProvider.when('/Home/Index', { templateUrl: '/templates/contacts.html', controller: 'ContactsController' });
    $routeProvider.when('/AddNewContact/Index', { templateUrl: '/templates/addNewContact.html', controller: 'NewContactController' });
    $locationProvider.html5Mode(true);
});