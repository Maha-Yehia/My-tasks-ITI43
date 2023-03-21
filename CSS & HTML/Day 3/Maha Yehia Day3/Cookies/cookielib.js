function getCookie(cookieName) {
  if (arguments.length !== 1) {
    throw new Error("Must pass only one name");
  }
  var allCookies = splitCookies(document.cookie);
  return decodeURIComponent(allCookies[cookieName]);
}

function setCookie(cookieName, cookieValue, expiryDate = null) {
  if (arguments.length >= 2 && arguments.length < 4) {
    if (expiryDate && !(expiryDate instanceof Date)) {
      throw new TypeError("Incorrect type of expiryDate");
    }
    if (expiryDate)
      document.cookie =
        cookieName +
        "=" +
        encodeURIComponent(cookieValue) +
        ";expires=" +
        expiryDate;
    else document.cookie = cookieName + "=" + encodeURIComponent(cookieValue);
  } else {
    throw new Error("Incorrent arguments count");
  }
}

function deleteCookie(cookieName) {
  if (arguments.length !== 1) {
    throw new Error("Must pass only one name");
  }
  document.cookie = cookieName + "=;expires=" + new Date();
}

function allCookieList() {
  return splitCookies(document.cookie);
}

function hasCookie(cookieName) {
  if (arguments.length !== 1) {
    throw new Error("Must pass only one name");
  }
  return !!getCookie(cookieName);
}

function splitCookies(cookieString) {
  if (arguments.length !== 1) {
    throw new Error("Must pass only one name");
  }
  if (!(typeof cookieString == "string" || cookieString instanceof String)) {
    throw new TypeError("cookieString must be a string");
  }
  var result = [];
  var cookiesArray = cookieString.split("; ");

  for (var i = 0; i < cookiesArray.length; i++) {
    cookiesArray[i] = cookiesArray[i].split("=");
    result[cookiesArray[i][0]] = cookiesArray[i][1];
  }

  return result;
}
