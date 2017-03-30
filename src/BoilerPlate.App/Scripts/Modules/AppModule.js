(function () {
    var app = angular.module("app", []);

    app.factory("AppHttpInterceptor", [
       "$q",
       "$window",
       AppHttpInterceptor
    ]);

    app.config([
        "$locationProvider",
        "$httpProvider",
        AppConfiguration
    ]);

    function AppConfiguration($locationProvider, $httpProvider) {
        $httpProvider.interceptors.push("AppHttpInterceptor");
    }

    $('a[href*="#"]:not([href="#"])').click(function () {
        if (location.pathname.replace(/^\//, '') == this.pathname.replace(/^\//, '') && location.hostname == this.hostname) {
            var target = $(this.hash);
            target = target.length ? target : $('[name=' + this.hash.slice(1) + ']');
            if (target.length) {
                $('html, body').animate({
                    scrollTop: target.offset().top - 60
                }, 1000);
                return false;
            }
        }
    });

    if (window.addEventListener)
        window.addEventListener('DOMMouseScroll', wheel, false);

    window.onmousewheel = document.onmousewheel = wheel;

    function wheel(event) {
        var delta = 0;
        if (event.wheelDelta) delta = event.wheelDelta / 120;
        else if (event.detail) delta = -event.detail / 3;

        handle(delta);
        if (event.preventDefault) event.preventDefault();
        event.returnValue = false;
    }

    function handle(delta) {
        var time = 300;
        var distance = 450;

        $('html, body').stop().animate({
            scrollTop: $(window).scrollTop() - (distance * delta)
        }, time);
    }

    function AppHttpInterceptor($q, $window) {

        return {
            "request": function (config) {
                return config || $q.when(config);
            },
            "requestError": function (rejection) {
                return $q.reject(rejection);
            },
            "response": function (response) {
                return response || $q.when(response);
            },
            "responseError": function (rejection) {

                if (rejection.status === 401 && $window.location.pathname != "/Login")
                    $window.location.href = "/Login";

                if (rejection.status === 500)
                    $window.location.href = "/RequisicaoNaoCompletada";

                return $q.reject(rejection);
            }
        };
    }
})();