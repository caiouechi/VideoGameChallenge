angular.module('appComponentModule', [])
    .controller('appComponent', function ($http, $scope) {
        $scope.userTypeFilter = "";
        $scope.message = 'COMPONENT!';
        $scope.count = 0;

        $scope.filterVideoGamesByName = function (nameToFilter) {
            var apiURL = 'http://localhost:44329/api/videogame/getVideoGamesByName/' + nameToFilter;
            if (nameToFilter == null || nameToFilter == "") apiURL = 'http://localhost:44329/api/videogame';

            $http.get(apiURL)
                .then(function (response) {
                    $scope.videoGameList = response.data;
                })
        };

        $http.get('http://localhost:44329/api/videogame')
            .then(function (response) {
                $scope.videoGameList = response.data;
            })
    });