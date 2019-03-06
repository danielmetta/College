app.controller('HomeController', function ($scope, $http) {
    $scope.dado = {};

    function carregarPagina() {
        $http({
            method: 'GET',
            url: 'home/dashboard'
        }).then(function (response) {
            $scope.dashboard = response.data;
        }, function (error) {
            alert('error');
        });

        $http({
            method: 'GET',
            url: 'disciplina/RelatorioDisciplina'
        }).then(function (response) {
            $scope.relatorioDisciplina = response.data;
        }, function (error) {
            alert('error');
        });
    }

    carregarPagina();
});