contactsModule.factory('ContactsRepository', function ($http, $q) {
    return {
        //q - promise library -> olaksava hendlanje asinkrone komunikacije
        get: function () {
            var deffered = $q.defer();
            $http.get('/Home/Index').success(deffered.resolve).error(deffered.reject);
            return deffered.promise;    //ovo znaci da obecaje da ce poslati obavijest je li akcija bila uspjesna ili ne
        }
    }
});