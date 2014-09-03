contactsModule.controller("ContactsController", function ($scope, ContactsRepository) {
    //kad get funkcija vrati promise, ako je resolved izvrsi se prva funkcija, ako je rejected onda druga
    ContactsRepository.get().then(function (contacts) { $scope.contacts = contacts; console.log($scope.contacts)}/*, function () { }*/)
});