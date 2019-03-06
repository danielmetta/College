app.controller('ProfessorController', function ($scope, $http) {
    $scope.dado = {};

    function carregarPagina() {
        $http({
            method: 'GET',
            url: 'professor/get'
        }).then(function (response) {
            $scope.professores = response.data;
        }, function (error) {
            alert('error');
        });
    }

    carregarPagina();

    $scope.adicionar = function () {
        $http({
            method: 'POST',
            url: 'professor/post',
            headers: {
                'Content-Type': 'application/json'
            },
            data: $scope.dado
        }).then(function (response) {
            $scope.dado = {};
            carregarPagina();
        }, function (error) {
            alert('error');
        });
    }

    $scope.atualizar = function (item) {
        console.log(item);
        item.DataNascimento = new Date(item.DataNascimento);
        $scope.dado = angular.copy(item);
    }
});