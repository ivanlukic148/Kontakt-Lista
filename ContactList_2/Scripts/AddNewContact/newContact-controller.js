contactsModule.controller("NewContactController", function ($scope, NewContactRepository) {
    $scope.save = function (contact) {
        NewContactRepository.save(contact)           
    };
});