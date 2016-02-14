angular
    .module('MyApp.ctrl.crud', [])
    .controller('juegoGeneroController', [
        '$scope', function ($scope) {

            $scope.jugelist = [];

            $scope.genlist = [];

            $scope.juelist = [];

            $scope.dto = {
                Id: '',
                IdJuego: '',
                IdGenero: ''
            }

            $scope.load;

            $scope.load = function () {
                $.ajax({
                    type: 'GET',
                    contentType: 'application/json; charset=utf-8',
                    url: '/JuegoGenero/ListarJuegoGenero',
                    success: function (data) {
                        $scope.jugelist = data;
                        $scope.$apply();
                    }
                });

                $.ajax({
                    type: 'GET',
                    contentType: 'application/json; charset=utf-8',
                    url: '/Genero/ListarGenero',
                    success: function (data) {
                        $scope.genlist = data;
                        $scope.$apply();
                    }
                });

                $.ajax({
                    type: 'GET',
                    contentType: 'application/json; charset=utf-8',
                    url: '/Juego/ListarJuego',
                    success: function (data) {
                        $scope.juelist = data;
                        $scope.$apply();
                    }
                });
            };

            $scope.updateGenero = function () {
                $scope.dto.IdGenero = $scope.selectedGenero.Id;
            };

            $scope.updateJuego = function () {
                $scope.dto.IdJuego = $scope.selectedJuego.Id;
            };

            $scope.load();

            $scope.clear = function () {
                $scope.dto.Id = '';
                $scope.dto.IdJuego = '';
                $scope.dto.IdGenero = '';
            };

            $scope.save = function () {
                console.log($scope.dto);
                $.ajax({
                    type: 'POST',
                    contentType: 'application/json; charset=utf-8',
                    data: JSON.stringify($scope.dto),
                    url: '/JuegoGenero/InsertarJuegoGenero',
                    success: function (data, status) {
                        console.log(data);
                        $scope.clear();
                        $scope.load();
                    },
                    error: function (status) { }
                });
            };

            $scope.delete = function (data) {
                var state = confirm("¿Desea eliminar este genero del juego realmente?");
                if (state == true) {
                    $.ajax({
                        type: 'POST',
                        contentType: 'application/json; charset=utf-8',
                        data: JSON.stringify(data),
                        url: '/JuegoGenero/EliminarJuegoGenero',
                        success: function (status) {
                            console.log(status);
                            $scope.load();
                        },
                        error: function (status) { }
                    });
                }
            }

            $scope.edit = function (item) {
                $scope.dto.Id = item.Id;
                $scope.dto.IdJuego = item.IdJuego;
                $scope.dto.IdGenero = item.IdGenero;
            };

            $scope.update = function () {
                $.ajax({
                    type: 'POST',
                    contentType: 'application/json; charset=utf-8',
                    data: JSON.stringify($scope.dto),
                    url: '/JuegoGenero/ActualizarJuegoGenero',
                    success: function (data, status) {
                        console.log(data);
                        $scope.clear();
                        $scope.load();
                    },
                    error: function (status) { }
                });
            };
        }
    ]);