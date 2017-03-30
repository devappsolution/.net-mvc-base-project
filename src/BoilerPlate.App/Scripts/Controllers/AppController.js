(function () {
    angular.module("app").controller("AppController", [
        "Emails",
        "$window",
        "$scope",
        AppController
    ]);

    function AppController(Emails, $window, $scope) {

        var _self = this;

        _self.enviarEmail = function () {
            Emails
                .enviar(_self.dados)
                .then(function (response) {
                    _self.info = response.data;
                    delete _self.dados;
                })
                ["catch"](function (response) {
                    _self.erros = response.data;
                })
        }
    }
})();