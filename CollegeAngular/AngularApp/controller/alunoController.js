app.controller('AlunoController', function ($scope, $http) {
    $scope.dado = {};

    function carregarPagina()
    {
        $http({
            method: 'GET',
            url: 'aluno/get'
        }).then(function (response) {
            $scope.alunos = response.data;
        }, function (error) {
            alert('error');
        });
    }

    carregarPagina();

    $scope.adicionar = function () {
        $http({
            method: 'POST',
            url: 'aluno/post',
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
        item.DataNascimento = new Date(item.DataNascimento);
        $scope.dado = angular.copy(item);
    }
});