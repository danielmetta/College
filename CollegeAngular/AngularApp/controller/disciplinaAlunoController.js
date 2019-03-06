app.controller('DisciplinaAlunoController', function ($scope, $http) {
    $scope.dado = {};

    function carregarAluno() {
        $http({
            method: 'GET',
            url: 'aluno/get'
        }).then(function (response) {
            $scope.alunos = response.data;
        }, function (error) {
            alert('error');
        });
    }

    function carregarDisciplina() {
        $http({
            method: 'GET',
            url: 'disciplina/get'
        }).then(function (response) {
            $scope.disciplinas = response.data;
        }, function (error) {
            alert('error');
        });
    }

    function carregarPagina() {
        $http({
            method: 'GET',
            url: 'disciplinaAluno/get'
        }).then(function (response) {
            console.log(response.data);
            $scope.disciplinaAlunos = response.data;
        }, function (error) {
            alert('error');
        });
    }

    carregarAluno();
    carregarDisciplina();
    carregarPagina();

    $scope.adicionar = function () {
        $http({
            method: 'POST',
            url: 'disciplinaAluno/post',
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