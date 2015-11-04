var app = angular.module('vendorApp', []);

app.controller('MainController', MainController);

function MainController(){
	var vm = this;
	vm.showloginForm = false;
	
	vm.toggleLoginForm = function(){
	  vm.showloginForm = !vm.showloginForm;
	  vm.loginView = 'login';
	}
	
	vm.toggleLoginView = function(view){
		vm.loginView = view;
	}
}