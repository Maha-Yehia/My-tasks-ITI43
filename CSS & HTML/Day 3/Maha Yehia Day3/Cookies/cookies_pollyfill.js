conditionizr.add("noCookie", function () {
    return !window.cookie;
})

conditionizr.polyfill("cookielib.js", ["noCookie"]);