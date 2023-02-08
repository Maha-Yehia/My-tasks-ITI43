
//var regBtn = document.getElementById("regBtn");
//var userName = document.getElementById("userName");
//var age = document.getElementById("age");
//var male = document.getElementById("male");
//var female = document.getElementById("female");
//var color = document.getElementById("color");

document.getElementById("regBtn").onclick = function (e) {
    e.preventDefault();
    location.assign('profile.html');
    setCookie("userName", document.getElementById("userName").value, "11/11/2025",);
    setCookie("age", document.getElementById("age").value, "11/11/2025");
    if (document.getElementsByName("gender")[0].checked) {
        setCookie("gender", document.getElementsByName("gender")[0].value);
    }
    else {
        setCookie("gender", document.getElementsByName("gender")[1].value);
    }
    setCookie("color", document.getElementById("color").value, "11/11/2025");
    setCookie("visits", 1);

    //location.replace("profile.html");


}

