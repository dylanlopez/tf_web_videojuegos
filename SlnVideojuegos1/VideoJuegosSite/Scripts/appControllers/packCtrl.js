angular
    .module('MyApp.ctrl.crud', [])
    .controller('packController', [
        '$scope', function ($scope) {

            $scope.paclist = [];

            $scope.dto = {
                Id: '',
                Nombre: '',
                Precio: '',
                Descripcion: ''
            }

            $scope.load;

            $scope.load = function () {

                $.ajax({
                    type: 'GET',
                    contentType: 'application/json; charset=utf-8',
                    url: '/Pack/ListarPack',
                    success: function (data) {
                        $scope.paclist = data;
                        $scope.$apply();
                    }
                });
            }
            $scope.load();

            $scope.clear = function () {
                $scope.dto.Id = '';
                $scope.dto.Nombre = '';
                $scope.dto.Precio = '';
                $scope.dto.Descripcion = '';
            };

            $scope.save = function () {
                console.log($scope.dto);
                $.ajax({
                    type: 'POST',
                    contentType: 'application/json; charset=utf-8',
                    data: JSON.stringify($scope.dto),
                    url: '/Pack/InsertarPack',
                    success: function (data, status) {
                        console.log(data);
                        $scope.clear();
                        $scope.load();
                    },
                    error: function (status) { }
                });
            };

            $scope.delete = function (data) {
                var state = confirm("¿Desea eliminar este pack realmente?");
                if (state == true) {
                    $.ajax({
                        type: 'POST',
                        contentType: 'application/json; charset=utf-8',
                        data: JSON.stringify(data),
                        url: '/Pack/EliminarPack',
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
                $scope.dto.Precio = item.Precio;
                $scope.dto.Descripcion = item.Descripcion;
            };

            $scope.update = function () {
                $.ajax({
                    type: 'POST',
                    contentType: 'application/json; charset=utf-8',
                    data: JSON.stringify($scope.dto),
                    url: '/Pack/ActualizarPack',
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