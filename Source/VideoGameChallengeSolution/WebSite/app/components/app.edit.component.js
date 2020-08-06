angular.module('appEditComponentModule', [])
    .controller('appEditComponent', function ($http, $scope) {
        $scope.userTypeFilter = "";
        $scope.result = "";

        $http.get('http://localhost:44329/api/videogame')
            .then(function (response) {
                $scope.videoGameList = response.data;
            })

        $scope.videoGameSelect = function (videoGameId) {
            $scope.videoGameTarget = JSON.parse(videoGameId);
        };

        $scope.videoGameEdit = function (videoGameId) {
            $scope.videoGameTarget = JSON.parse(videoGameId);
        };

        $scope.submit = function () {
            $http.post('http://localhost:44329/api/VideoGame', $scope.videoGameTarget)
                .then(function (response) {
                    if (response.data) {
                        $scope.result = "Video game updated"
                    } else {
                        $scope.result = "Error on the update"
                    }
                })
        };
    });
