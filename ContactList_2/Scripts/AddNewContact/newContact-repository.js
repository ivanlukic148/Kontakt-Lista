contactsModule.factory('NewContactRepository', function ($http) {
    return {
        save: function(contact) {
            $http.post('/AddNewContact/Save', contact);
        }
    };
});