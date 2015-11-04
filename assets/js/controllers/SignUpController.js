app.controller('SignUpController', ['$scope', 'VendorService', function($scope, VendorService) {

    function VendorMaker(name, bizname, vendortype, city) {
        this.name = name,
        this.bizname = bizname,
        this.vendortype = vendortype,
        this.city = city
    };

    VendorService.getVendors().then(function (vendors) {
        $scope.vendors = vendors;
    })

    $scope.signup = function(vendor){
        //function signup
        //signup click event
        //get all the form elements to send to service (api)
        //after success show message
        //after failure show error
        //after success message send them somewhere??? 
        var vendor = new VendorMaker(vendor.name, vendor.bizname, vendor.vendortype, vendor.city);
        VendorService.addVendor(vendor).then(function (res) {
            debugger;
        });
    }
}]);