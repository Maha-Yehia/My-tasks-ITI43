
console.log(getCookie("userName"));
console.log(getCookie("age"));
console.log(getCookie("gender"));
console.log(getCookie("color"));
console.log(getCookie("visits"));
console.log(allCookieList());


var myImg = document.images[0];
myImg.src = getCookie("gender");

window.onload = function () {
    setCookie("visits", parseInt(getCookie("visits")) + 1);
}

var display = document.getElementById("myh1");
display.innerHTML = "Welcome <span style='color:" + getCookie("color") + ";'> " + getCookie("userName") +
    "</span> You Have visited this site <span style='color:" + getCookie("color") + ";'> " + getCookie("visits") + "</span> times";