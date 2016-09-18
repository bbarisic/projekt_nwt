app.controller("userAccesController", function ($scope, $http) {

    $scope.isRegistered = false;

    $scope.register = function () {
        if ($scope.user.password != $scope.confirmPassword) {
            alert("Password must match!")
        } else {
            $http({
                method: 'POST',
                url: '',
                data: {
                    user: $scope.user
                }
            }).then(function (response) {
                if (response.data == "OK") {
                    $scope.isRegistered = true;
                    alert("USER REGISTRED!");
                } else {
                    alert("ERROR");
                }
            })
        }   
    }

    $scope.login = function () {
        if ($scope.username != undefined && $scope.password != undefined) {
            $http({
                method: 'POST',
                url: '',
                data: {
                    user: $scope.user
                }
            }).then(function (response) {
                if (response.data.message == "OK") {
                    $scope.username = response.data.username
                    $scope.isRegistered = true;
                    alert("USER REGISTRED!");
                } else {
                    alert("ERROR");
                }
            })
        }
    }
})