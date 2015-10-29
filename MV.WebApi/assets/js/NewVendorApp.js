var app = angular.module('NewVendorApp', ['ngRoute']);
app.config(function ($routeProvider) {
  $routeProvider
    .when('/', {
      controller: "SignUpController",
      templateUrl: "assets/js/views/signup.html"
    })
});
