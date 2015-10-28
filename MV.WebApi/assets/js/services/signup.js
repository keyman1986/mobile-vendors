app.factory('vendor', ['$http', function($http) {

    return $http.push('http://mobile-vendors.azurewebsites.net/api/vendors')
    .success(function(data) {
       return data;
       })
     .error(function(err) {
       return err;
       });
    return $http.get('http://mobile-vendors.azurewebsites.net/api/vendors')
    .success(function(data) {
       return "Thanks! You are now enrolled in roaming-vendors.com";
       })
     .error(function(err) {
       return err;
       });
    
}]);
