function submitData() {
    var userName = document.getElementById("Name");
    var userAge = document.getElementById("Age");
    var userGender = document.querySelector('input[name="Gender"]:checked');
    var userColor = document.getElementById("Color").value;
    
    location.replace("welcome.html");
    
    setCookie(userName.name, userName.value);
    setCookie(userAge.name, userAge.value);
    setCookie(userGender.name, userGender.value);
    setCookie("Color", userColor);
    setCookie("visitCount", 0);

}

function displayData() {
    var userName = getCookie("Name");
    var visitCount = parseInt(getCookie("visitCount"));
    var userColor = getCookie("Color");
    var userGender = getCookie("Gender");


    document.getElementById("Name").innerHTML = userName;
    document.getElementById("count").innerHTML = ++visitCount;
    
    if (userGender == "male")
        document.getElementById("image").src = "1.jpg";
    else
        document.getElementById("image").src = "2.jpg";

    setCookie("visitCount", visitCount.toString());

}