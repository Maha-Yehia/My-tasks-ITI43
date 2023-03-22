$("#myCar").click(function () {
    $("#myCar").animate({ left: "1250px" }, 3000, "linear");
});

var timer = setInterval(function () {
    var leftVal = Math.round($("#myCar").offset().left);
    $("#myP").text('<img src="12.gif" style="left: ' + leftVal + '/>')
}, 100)






