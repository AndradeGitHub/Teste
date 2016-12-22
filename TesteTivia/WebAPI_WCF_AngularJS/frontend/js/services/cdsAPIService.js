angular.module("lojaDeMusica").factory("cdsAPI", function ($http, config) {

	var _getCds = function (titulo, artista, generoMusica, nomeMusica) {
		if (titulo == undefined) titulo = "";
		if (artista == undefined) artista = "";
		if (generoMusica == undefined) generoMusica = "";
		if (nomeMusica == undefined) nomeMusica = "";
		return $http({
			method: "GET",
      url: config.baseUrl + "/api/Cd/GetCd",
			params: { titulo: titulo, artista: artista, generoMusica: generoMusica, nomeMusica: nomeMusica }
		});
	};

	var _saveCd = function (cdAdd) {		
		return $http.post(config.baseUrl + "/api/Cd/AddCd", cdAdd);
	};

	return {
		getCds: _getCds,
		saveCd: _saveCd
	};
});
