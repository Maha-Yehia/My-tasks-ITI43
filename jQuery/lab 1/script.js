
$("#btnAbout").click(function () {
    $("div").hide();
    $("#myP").slideToggle();
})


$("#btnGallery").click(function () {
    $("div").hide();
    $("#container").slideToggle();
})

var i = 0;
var arr = ["1.jpg", "2.jpg", "3.jpg", "4.jpg", "5.jpg", "6.jpg", "7.jpg", "8.jpg"]


$("#movePicRight").click(function () {
    if (i < arr.length - 1) {
        i++;
        $('.active').attr('src', arr[i]);
    }
})

$("#movePicLeft").click(function () {
    if (i < arr.length) {
        i--;
        $('.active').attr('src', arr[i]);
    }
})


$("#btnServices").click(function () {
    $("div").hide();
    $("#list").slideToggle();

})

$("#btnComplain").click(function () {
    $("div").hide();
    $("#compPage").slideToggle();
})

$("#send").click(function () {
    $("div").hide();
    $("#sendPage").show();

    _compText = document.getElementById("complainText").value;
    _name = document.getElementById("name").value;
    _email = document.getElementById("email").value;
    _phone = document.getElementById("phone").value;

    $("#showComp").html(_compText)
    $("#showName").html(_name)
    $("#showEmail").html(_email)
    $("#showPhone").html(_phone)

})

$("#backToEdit").click(function () {
    $("div").hide();
    $("#compPage").show();
})













