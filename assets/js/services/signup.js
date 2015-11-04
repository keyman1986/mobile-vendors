app.factory('VendorService', ['$http', function($http) {

    return {
        addVendor: function (vendor) {
            return $http.post('/api/vendors/add', vendor)
                .success(function (res) {
                    debugger
                })
                .error(function (res) {
                    debugger
                })
        },
        getVendors: function () {
            return $http.get('/api/vendors')
                .success(function (res) {
                    debugger
                    return res.data;
                })
                .error(function (res) {
                    debugger
                })
        }
    }

    //return $http.push('http://mobile-vendors.azurewebsites.net/api/vendors')
    //.success(function(data) {
    //   return data;
    //   })
    // .error(function(err) {
    //   return err;
    //   });
    //return $http.get('http://mobile-vendors.azurewebsites.net/api/vendors')
    //.success(function(data) {
    //   return "Thanks! You are now enrolled in roaming-vendors.com";
    //   })
    // .error(function(err) {
    //   return err;
    //   });
    
}]);
