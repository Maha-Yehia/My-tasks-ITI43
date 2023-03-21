

document.getElementById("regBtn").onclick = function (e) {
    e.preventDefault();
    let userName = document.getElementById("userName").value;
    let title = document.getElementById("title").value;
    let email = document.getElementById("email").value;
    let tel = document.getElementById("tel").value;
    let gen = document.getElementById("gender").value;
    let add = document.getElementById("add").value;
    let win = open('home');
    win.document.write("<h1>Welcome " + title + ' ' + userName + "</h1><hr>");
    win.document.write("<h2>Kindy find your information below</h2> " +
        "<br><br><b>Your address: </b>" + add +
        "<br><br><b>Your email: </b>" + email +
        "<br><br><b>Your mobile number : </b> " + tel +
        "<br><br><b>Your gender is </b> " + gen)

    //var isChrome = /Google Chrome/.test(navigator.userAgent);
    var isChrome = navigator.userAgentData && navigator.userAgentData.brands && navigator.userAgentData.brands.some(b => b.brand === 'Google Chrome');

    if (!isChrome) {
        win.document.write("<br><br><h3>Chrome browser is recommended</h3>");

    }

}

