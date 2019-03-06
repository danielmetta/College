app.controller('DisciplinaController', function ($scope, $http) {
    $scope.dado = {};

    function carregarPagina() {
        $http({
            method: 'GET',
            url: 'disciplina/get'
        }).then(function (response) {
            $scope.disciplinas = response.data;
        }, function (error) {
            alert('error');
        });
    }

    function carregarCurso() {
        $http({
            method: 'GET',
            url: 'curso/get'
        }).then(function (response) {
            $scope.cursos = response.data;
        }, function (error) {
            alert('error');
        });
    }

    function carregarProfessor() {
        $http({
            method: 'GET',
            url: 'professor/get'
        }).then(function (response) {
            $scope.professores = response.data;
        }, function (error) {
            alert('error');
        });
    }

    carregarCurso();
    carregarProfessor();
    carregarPagina();

    $scope.adicionar = function () {
        console.log($scope.dado);
        $http({
            method: 'POST',
            url: 'disciplina/post',
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
        $scope.dado = angular.copy(item);
    }
});