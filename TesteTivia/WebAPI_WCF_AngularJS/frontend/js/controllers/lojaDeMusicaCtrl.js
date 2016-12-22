angular.module("lojaDeMusica").controller("lojaDeMusicaCtrl", function ($scope, cdsAPI, musicasAPI) {
	$scope.app = "Teste Tivia";
	$scope.cds = [];
	$scope.musicas = [];

	var carregarCds = function (titulo, artista, generoMusica, nomeMusica) {
		cdsAPI.getCds(titulo, artista, generoMusica, nomeMusica).success(function (data) {
			$scope.cds = data;
		}).error(function (data, status) {
			$scope.error = "Não foi possível carregar os dados!";
		});
	};

	$scope.pesquisarCd = function (titulo, artista, generoMusica, nomeMusica) {
		cdsAPI.getCds(titulo, artista, generoMusica, nomeMusica).success(function (data) {
			$scope.cds = data;
			delete $scope.musica;
			$scope.musicaForm.$setPristine();
			$scope.musicas = [];
		}).error(function (data, status) {
			$scope.error = "Não foi possível carregar os dados!";
		});
	};

	$scope.pesquisarMusica = function (musica) {
		musicasAPI.getMusicas(musica).success(function (data) {
			$scope.musicas = data;
			delete $scope.cd;
			$scope.cdForm.$setPristine();
			$scope.cds = [];
		}).error(function (data, status) {
			$scope.error = "Não foi possível carregar os dados!";
		});
	};

	$scope.adicionarCd = function (cdAdd) {
		var Musicas = [
		    { Nome: cdAdd.Musicas[0].Nome, Genero: cdAdd.musicas[0].genero, Duracao: cdAdd.musicas[0].duracao },
				{ Nome: cdAdd.Musicas[1].Nome, Genero: cdAdd.musicas[1].genero, Duracao: cdAdd.musicas[1].duracao },
				{ Nome: cdAdd.Musicas[2].Nome, Genero: cdAdd.musicas[2].genero, Duracao: cdAdd.musicas[2].duracao }
		];

		cdAdd.Musicas = Musicas;		

		cdsAPI.saveCd(cdAdd).success(function (data) {
			delete $scope.cd;
			$scope.cdForm.$setPristine();
			delete $scope.addCd;
			$scope.addCdForm.$setPristine();
			delete $scope.musica;
			$scope.musicaForm.$setPristine();
			$scope.musicas = [];
			carregarCds(cdAdd.titulo, cdAdd.artista, "", "", "");
		});
	};

	$scope.isContatoSelecionado = function (contatos) {
		return contatos.some(function (contato) {
			return contato.selecionado;
		});
	};
});
