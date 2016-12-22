angular.module("lojaDeMusica").filter("subs", function () {
	return function (input, size) {
		var output = input.toString().substring(0,(size || 4));
		return output;
	};
});
