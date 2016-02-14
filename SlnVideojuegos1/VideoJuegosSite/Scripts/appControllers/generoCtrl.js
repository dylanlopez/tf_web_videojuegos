angular
    .module('MyApp.ctrl.crud', [])
    .controller('generoController', [
        '$scope', function ($scope) {

            $scope.genlist = [];

            $scope.dto = {
                Id: '',
                Nombre: '',
                Descripcion: ''
            }

            $scope.load;

            $scope.load = function () {
                
                $.ajax({
                    type: 'GET',
                    contentType: 'application/json; charset=utf-8',
                    url: '/Genero/ListarGenero',
                    success: function (data) {
                        $scope.genlist = data;
                        $scope.$apply();
                    }
                });
            }
            $scope.load();

            $scope.clear = function () {
                $scope.dto.Id = '';
                $scope.dto.Nombre = '';
                $scope.dto.Descripcion = '';
            };
           
            $scope.save = function () {
                console.log($scope.dto);
                $.ajax({
                    type: 'POST',
                    contentType: 'application/json; charset=utf-8',
                    data: JSON.stringify($scope.dto),
                    url: '/Genero/InsertarGenero',
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
                        url: '/Genero/EliminarGenero',
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
                $scope.dto.Descripcion = item.Descripcion;
            };

            $scope.update = function () {                
                $.ajax({
                    type: 'POST',
                    contentType: 'application/json; charset=utf-8',
                    data: JSON.stringify($scope.dto),
                    url: '/Genero/ActualizarGenero',
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