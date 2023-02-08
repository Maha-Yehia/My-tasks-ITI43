function getCookie(cname) {

    if (arguments.length !== 1) {
        throw ("Please enter one parameter");
    }

    if (typeof cname != "string") {
        throw ("Please enter a string value")
    }

    let name = cname + "=";
    let decodedCookie = decodeURIComponent(document.cookie);
    let ca = decodedCookie.split(';');
    for (let i = 0; i < ca.length; i++) {
        let c = ca[i];
        while (c.charAt(0) == ' ') {
            c = c.substring(1);
        }
        if (c.indexOf(name) == 0) {
            return c.substring(name.length, c.length);
        }
    }
    throw ("Cookie not found")
}
function setCookie(cname, cvalue, exdays) {

    if (arguments.length !== 3 && arguments.length !== 2) {
        throw ("Please enter two or three parameters only");
    }

    if (typeof cname != "string") {
        throw ("Please enter a string value for Cookie name")
    }

    const d = new Date();
    d.setTime(d.getTime() + (exdays * 24 * 60 * 60 * 1000));
    let expires = "expires=" + d.toUTCString();
    document.cookie = cname + "=" + cvalue + ";" + expires + ";path=/";
}
function hasCookie(cname) {

    if (arguments.length !== 1) {
        throw ("Please enter one parameter");
    }
    if (typeof cname != "string") {
        throw ("Please enter a string value")
    }
    let value = getCookie(cname);
    if (value != "") {
        return true;
    } else {
        return false;
    }
}
function deleteCookie(cname) {
    if (arguments.length !== 1) {
        throw ("Please enter one parameter");
    }
    document.cookie = cname + "=;expires=Thu, 01 Jan 1970 00:00:00 UTC; path=/;";
}
function allCookieList() {
    var carr = [];
    for (ind in document.cookie.split(";")) {
        carr[document.cookie.split(";")[ind].split("=")[0]] = document.cookie.split(";")[ind].split("=")[1];
    }
    return carr;
}