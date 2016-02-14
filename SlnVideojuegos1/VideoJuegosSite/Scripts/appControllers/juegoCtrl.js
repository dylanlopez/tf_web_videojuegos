angular
    .module('MyApp.ctrl.crud', [])
    .controller('juegoController', [
        '$scope', function ($scope) {

            $scope.juelist = [];

            $scope.dto = {
                Id: '',
                Nombre: '',
                Anho: '',
                FechaLanzamiento: '',
                Estudio: '',
                Precio: '',
                Tags: '',
                Descripcion: ''
            }

            $scope.load;

            $scope.load = function () {

                $.ajax({
                    type: 'GET',
                    contentType: 'application/json; charset=utf-8',
                    url: '/Juego/ListarJuego',
                    success: function (data) {
                        $scope.juelist = data;
                        $scope.$apply();
                    }
                });
            }
            $scope.load();

            $scope.clear = function () {
                $scope.dto.Id = '';
                $scope.dto.Nombre = '';
                $scope.dto.Anho = '';
                $scope.dto.FechaLanzamiento = '';
                $scope.dto.Estudio = '';
                $scope.dto.Precio = '';
                $scope.dto.Tags = '';
                $scope.dto.Descripcion = '';
            };

            $scope.save = function () {
                console.log($scope.dto);
                $.ajax({
                    type: 'POST',
                    contentType: 'application/json; charset=utf-8',
                    data: JSON.stringify($scope.dto),
                    url: '/Juego/InsertarJuego',
                    success: function (data, status) {
                        console.log(data);
                        $scope.clear();
                        $scope.load();
                    },
                    error: function (status) { }
                });
            };

            $scope.delete = function (data) {
                var state = confirm("¿Desea eliminar este genero realmente?");
                if (state == true) {
                    $.ajax({
                        type: 'POST',
                        contentType: 'application/json; charset=utf-8',
                        data: JSON.stringify(data),
                        url: '/Juego/EliminarJuego',
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
                $scope.dto.Nombre = item.Nombre;
                $scope.dto.Anho = item.Anho;
                $scope.dto.FechaLanzamiento = item.FechaLanzamiento;
                $scope.dto.Estudio = item.Estudio;
                $scope.dto.Precio = item.Precio;
                $scope.dto.Tags = item.Tags;
                $scope.dto.Descripcion = item.Descripcion;
            };

            $scope.update = function () {
                $.ajax({
                    type: 'POST',
                    contentType: 'application/json; charset=utf-8',
                    data: JSON.stringify($scope.dto),
                    url: '/Juego/ActualizarJuego',
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