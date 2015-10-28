app.controller('SignUpController', ['$scope', 'vendors', function($scope, vendors) {
  vendors.success(function(data) {
    $scope.vendors = data;  
  });
}]);

function VendorMaker(name, bizname, vendortype, city) {
        this.name: name,
        this.biztype: biztype,
        this.vendortype: vendortype,
        this.city: city
};

var vendor = new VendorMaker(name, bizname, vendortype, city);

    $scope signup = function(){
        $scope 
    //function signup
    //signup click event
    //get all the form elements to send to service (api)
    //after success show message
    //after failure show error
    //after success message send them somewhere???

        
        
