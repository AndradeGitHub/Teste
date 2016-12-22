angular.module("lojaDeMusica").factory("musicasAPI", function ($http, config) {

	var _getMusicas = function (musica) {
		return $http({
			method: "GET",
      url: config.baseUrl + "/api/Musica/GetMusica",
			params: { nome: musica },
			dataType: 'jsonp'
		});
	};

	return {		
		getMusicas: _getMusicas
	};
});
